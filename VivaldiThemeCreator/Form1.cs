﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VivaldiThemeCreator
{
    public partial class Form1 : Form
    {
        String htmlOriginal { get; set; }
        String htmlBackup { get; set; }
        String customCss { get; set; }

        Style style { get; set; }
        Style internetExplorerStyle { get; set; }
        Style basicStyle { get; set; }

        String username { get; set; }
        String root { get; set; }
        String buildNumber { get; set; }

        public Form1()
        {
            InitializeComponent();

            username = Environment.UserName;
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

            initializeLocations();
            addStylesToComboBox();
            getStyle();
            
            UpDateTipsAndTriicks();
        }

        private void addStylesToComboBox()
        {
            cbStyles.Items.Add(basicStyle);
            cbStyles.Items.Add(internetExplorerStyle);

            cbStyles.SelectedIndex = 0;
        }

        private void addStylesToComboBox(string p)
        {
            cbStyles.SelectedIndex = -1;
            cbStyles.Items.Clear();

            cbStyles.Items.Add(basicStyle);
            cbStyles.Items.Add(internetExplorerStyle);

            if (p == "Basic")
            {
                cbStyles.SelectedIndex = 0;
            }
            else
            {
                cbStyles.SelectedIndex = 1;
            }
        }

        private void getStyle()
        {
            style = cbStyles.SelectedItem as Style;
        }

        private void initializeLocations()
        {
            //buildNumber = "1.0.435.38";
            //buildNumber = "1.0.435.42";
            buildNumber = "1.2.490.43";

            // note1: use '@' to insert unmodified path, otherwise will need to use escape char '\' in path
            htmlOriginal = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\browser.html";
            htmlBackup = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\browserBackup.html";
            customCss = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\style\custom.css";

            internetExplorerStyle = new InternetExplorerStyle(customCss);
            basicStyle = new BasicStyle(customCss);
        }

        private void initializeLocations(string customBuildNumber)
        {
            buildNumber = customBuildNumber;

            // note1: use '@' to insert unmodified path, otherwise will need to use escape char '\' in path
            htmlOriginal = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\browser.html";
            htmlBackup = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\browserBackup.html";
            customCss = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\" + buildNumber + @"\resources\vivaldi\style\custom.css";

            internetExplorerStyle = new InternetExplorerStyle(customCss);
            basicStyle = new BasicStyle(customCss);

            addStylesToComboBox(style.GetName());
            getStyle();
        }

        // creates a copy of original file
        // if copy already exist, do not overwrite
        // ****    ****    check for existing copy not implemented
        private void btnCreateCopyOfOriginalHtml_Click(object sender, EventArgs e)
        {
            getStyle();

            try
            {
                String original = System.IO.File.ReadAllText(htmlOriginal);
                System.IO.File.WriteAllText(htmlBackup, original);
                MessageBox.Show("Backup file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        // add line of html code to include custom source
        // note1: use '\' as escape character for paths
        private void btnPatchVivaldi_Click(object sender, EventArgs e)
        {
            getStyle();

            String[] originalLines;
            List<String> newLines;
           
            try
            {
                originalLines = System.IO.File.ReadAllLines(htmlOriginal);
                newLines = new List<String>();

                for (int i = 0; i < originalLines.Length; i++)
                {
                    // already patched
                    if (originalLines[i] == "<link rel=\"stylesheet\" href=\"style/custom.css\" />")
                    {
                        MessageBox.Show("Already patched");
                        return;
                    }

                    if (originalLines[i] == "    <link rel=\"stylesheet\" href=\"style/common.css\" />")
                    {
                        newLines.Add("<link rel=\"stylesheet\" href=\"style/custom.css\" />");
                    }
                    newLines.Add(originalLines[i]);
                }
                
                // note2: wrap the StreamWriter in using(){}, otherwise use Dispose()
                // note3: this method overrride old document bѕ creating new emptyDocument, then fill with content of 'List<String> newLines'
                using (System.IO.StreamWriter file = new System.IO.StreamWriter(htmlOriginal))
                {
                    foreach (string line in newLines)
                    {
                        file.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
                return;
            }

            MessageBox.Show("Vivaldi is sucessfully patched");
        }

        // apply style and colors to custom.css
        // first delete previous configuration, then apply what user chose
        private void btnApplyStyle_Click(object sender, EventArgs e)
        {
            if (tbVersion.Text.Trim().Length > 0)
            {
                initializeLocations(tbVersion.Text.Trim());
            }

            getStyle();

            try
            {
                style.ApplyStyle();
                if (cbCustomColors.Checked == true)
                {
                    UpdateColorsFromButtons();
                    style.ApplyCustomColors();
                    
                    if (cbWideAdressbarColor.Checked == true)
                    {
                        style.FixWideAdressbarColor();
                    }
                }
                
                MessageBox.Show("Style applied sucessfully. Restart Vivaldi to see changes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // reset the UI by creating empty custom.css file
        private void btnResetToDefault_Click(object sender, EventArgs e)
        {
            getStyle();

            try{
                using (System.IO.File.Create(customCss)) ;
                MessageBox.Show("Theme has been restored to default one. Restart Vivaldi to see the changes");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            style = cbStyles.SelectedItem as Style;
            
            if (style == null)
            {
                return;
            }

            if (style.GetName() == "Basic")
            {
                pbDefault.Visible = true;
                pbInternetExplorer.Visible= false;
            }
            if (style.GetName() == "Internet Explorer")
            {
                pbInternetExplorer.Visible = true;
                pbDefault.Visible = false;
            }
        }

        private void btnFrame_Click(object sender, EventArgs e)
        {
            SetColor(btnFrame);
        }

        private void btnInactiveTab_Click(object sender, EventArgs e)
        {
            SetColor(btnInactiveTab);
        }

        private void btnAcriveTab_Click(object sender, EventArgs e)
        {
            SetColor(btnAcriveTab);
        }

        private void btnPanelColor_Click(object sender, EventArgs e)
        {
            SetColor(btnPanelColor);
        }

        private void SetColor(Button button)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK){
                button.BackColor = cd.Color;
            }
        }

        private void UpdateColorsFromButtons()
        {
            style.SetFrameColor(btnFrame.BackColor);
            style.SetPanelColor(btnPanelColor.BackColor);
            style.SetActiveTabColor(btnAcriveTab.BackColor);
            style.SetInactiveTabColor(btnInactiveTab.BackColor);
        }

        private void UpDateTipsAndTriicks()
        {
            // use '/r/n' to write new line
            // note1: TextBox stores text in array of lines. 
            // note2: You can use TextBox.Lines to acces lines or
            // use '/r/n' write new line bu using only array of one line
            StringBuilder sb = new StringBuilder();
            sb.Append("Internet Explorer:\r\n");
            sb.Append("Use same color for Window frame, Panel, and Inactive tabs, chose deferent color for Active tab.\r\n");

            sb.Append("\r\n");
            sb.Append("Basic:\r\n");
            sb.Append("Use same color for Window frame and inactive tabs. Use other color for Panel and Active tab\r\n");

            tbTipsAndTricks.Text = sb.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout about = new FormAbout();
            about.Show();
        }

        private void reportProblemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/bokiscout/VivaldiThemeCreator/issues");
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/bokiscout/VivaldiThemeCreator/releases");
        }

    }
}
