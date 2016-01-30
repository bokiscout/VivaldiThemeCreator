using System;
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
        String templateInternetExplorer { get; set; }

        Style style { get; set; }

        String username { get; set; }
        String root { get; set; }

        public Form1()
        {
            InitializeComponent();

            username = Environment.UserName;
            root = Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System));

            // note1: use '@' to insert unmodified path, otherwise will need to use escape char '\' in path
            htmlOriginal = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\1.0.344.37\resources\vivaldi\browser.html";
            htmlBackup = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\1.0.344.37\resources\vivaldi\browserBackup.html";
            customCss = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\1.0.344.37\resources\vivaldi\style\custom.css";

            // templateInternetExplorer = @"D:\Copy\vivaldi_internet_explorer_style.css";
            templateInternetExplorer = root + @"Users\" + username + @"\AppData\Local\Vivaldi\Application\1.0.344.37\resources\vivaldi\style\vivaldi_internet_explorer_style.css";

            Style internetExplorerStyle = new InternetExplorerStyle(customCss, templateInternetExplorer);
            Style basicStyle = new BasicStyle(customCss, templateInternetExplorer);

            cbStyles.Items.Add(basicStyle);
            cbStyles.Items.Add(internetExplorerStyle);

            // note1: 'SelectedIndex = <someNumber>' should select 'BasicStyle'
            // note2:  index of 'BasicStyle' might change to other value when new styles are being added to 'cbStyles'
            cbStyles.SelectedIndex = 0;

            UpDateTipsAndTriicks();
        }

        // creates a copy of original file
        // if copy already exist, do not overwrite
        // ****    ****    check for existing copy not implemented
        private void btnCreateCopyOfOriginalHtml_Click(object sender, EventArgs e)
        {
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
            using (System.IO.File.Create(customCss)) ;
        }

        private void cbStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            style = cbStyles.SelectedItem as Style;
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
            sb.Append("Use same color for Window frape, Panel, and Inactive tabs. Chose deferent color for Active tab.\r\n");

            sb.Append("\r\n");
            sb.Append("Basic:\r\n");
            sb.Append("Use same color for Window frame and inactive tabs. Use same color for Panel and Active tab\r\n");

            tbTipsAndTricks.Text = sb.ToString();
        }

    }
}
