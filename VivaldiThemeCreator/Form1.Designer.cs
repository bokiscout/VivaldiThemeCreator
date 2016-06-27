namespace VivaldiThemeCreator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCreateCopyOfOriginalHtml = new System.Windows.Forms.Button();
            this.btnPatchVivaldi = new System.Windows.Forms.Button();
            this.btnApplyStyle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnResetToDefault = new System.Windows.Forms.Button();
            this.cbStyles = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWideAdressbarColor = new System.Windows.Forms.CheckBox();
            this.cbCustomColors = new System.Windows.Forms.CheckBox();
            this.btnPanelColor = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAcriveTab = new System.Windows.Forms.Button();
            this.btnInactiveTab = new System.Windows.Forms.Button();
            this.btnFrame = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbInternetExplorer = new System.Windows.Forms.PictureBox();
            this.pbDefault = new System.Windows.Forms.PictureBox();
            this.gbCustomColors = new System.Windows.Forms.GroupBox();
            this.gbTipsAndTricks = new System.Windows.Forms.GroupBox();
            this.tbTipsAndTricks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVersion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportProblemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).BeginInit();
            this.gbCustomColors.SuspendLayout();
            this.gbTipsAndTricks.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCopyOfOriginalHtml
            // 
            this.btnCreateCopyOfOriginalHtml.Location = new System.Drawing.Point(10, 391);
            this.btnCreateCopyOfOriginalHtml.Name = "btnCreateCopyOfOriginalHtml";
            this.btnCreateCopyOfOriginalHtml.Size = new System.Drawing.Size(197, 23);
            this.btnCreateCopyOfOriginalHtml.TabIndex = 0;
            this.btnCreateCopyOfOriginalHtml.Text = "Create backup";
            this.btnCreateCopyOfOriginalHtml.UseVisualStyleBackColor = true;
            this.btnCreateCopyOfOriginalHtml.Click += new System.EventHandler(this.btnCreateCopyOfOriginalHtml_Click);
            // 
            // btnPatchVivaldi
            // 
            this.btnPatchVivaldi.Location = new System.Drawing.Point(10, 419);
            this.btnPatchVivaldi.Name = "btnPatchVivaldi";
            this.btnPatchVivaldi.Size = new System.Drawing.Size(197, 23);
            this.btnPatchVivaldi.TabIndex = 1;
            this.btnPatchVivaldi.Text = "Patch Vivaldi";
            this.btnPatchVivaldi.UseVisualStyleBackColor = true;
            this.btnPatchVivaldi.Click += new System.EventHandler(this.btnPatchVivaldi_Click);
            // 
            // btnApplyStyle
            // 
            this.btnApplyStyle.Location = new System.Drawing.Point(10, 477);
            this.btnApplyStyle.Name = "btnApplyStyle";
            this.btnApplyStyle.Size = new System.Drawing.Size(197, 23);
            this.btnApplyStyle.TabIndex = 2;
            this.btnApplyStyle.Text = "Apply custom theme";
            this.btnApplyStyle.UseVisualStyleBackColor = true;
            this.btnApplyStyle.Click += new System.EventHandler(this.btnApplyStyle_Click);
            // 
            // btnResetToDefault
            // 
            this.btnResetToDefault.Location = new System.Drawing.Point(10, 448);
            this.btnResetToDefault.Name = "btnResetToDefault";
            this.btnResetToDefault.Size = new System.Drawing.Size(197, 23);
            this.btnResetToDefault.TabIndex = 5;
            this.btnResetToDefault.Text = "Don\'t use custom themes";
            this.btnResetToDefault.UseVisualStyleBackColor = true;
            this.btnResetToDefault.Click += new System.EventHandler(this.btnResetToDefault_Click);
            // 
            // cbStyles
            // 
            this.cbStyles.FormattingEnabled = true;
            this.cbStyles.Location = new System.Drawing.Point(10, 364);
            this.cbStyles.Name = "cbStyles";
            this.cbStyles.Size = new System.Drawing.Size(197, 21);
            this.cbStyles.TabIndex = 6;
            this.cbStyles.SelectedIndexChanged += new System.EventHandler(this.cbStyles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 348);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Chose style";
            // 
            // cbWideAdressbarColor
            // 
            this.cbWideAdressbarColor.AutoSize = true;
            this.cbWideAdressbarColor.Checked = true;
            this.cbWideAdressbarColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWideAdressbarColor.Location = new System.Drawing.Point(13, 225);
            this.cbWideAdressbarColor.Name = "cbWideAdressbarColor";
            this.cbWideAdressbarColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbWideAdressbarColor.Size = new System.Drawing.Size(222, 30);
            this.cbWideAdressbarColor.TabIndex = 9;
            this.cbWideAdressbarColor.Text = "Wide adressbar of Internet Exploerer style\r\nuses same color as Acrive tab";
            this.cbWideAdressbarColor.UseVisualStyleBackColor = true;
            // 
            // cbCustomColors
            // 
            this.cbCustomColors.AutoSize = true;
            this.cbCustomColors.Location = new System.Drawing.Point(56, 19);
            this.cbCustomColors.Name = "cbCustomColors";
            this.cbCustomColors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCustomColors.Size = new System.Drawing.Size(179, 17);
            this.cbCustomColors.TabIndex = 8;
            this.cbCustomColors.Text = "Use custom colors                      ";
            this.cbCustomColors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbCustomColors.UseVisualStyleBackColor = true;
            // 
            // btnPanelColor
            // 
            this.btnPanelColor.Location = new System.Drawing.Point(160, 96);
            this.btnPanelColor.Name = "btnPanelColor";
            this.btnPanelColor.Size = new System.Drawing.Size(75, 23);
            this.btnPanelColor.TabIndex = 7;
            this.btnPanelColor.UseVisualStyleBackColor = true;
            this.btnPanelColor.Click += new System.EventHandler(this.btnPanelColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Panel";
            // 
            // btnAcriveTab
            // 
            this.btnAcriveTab.Location = new System.Drawing.Point(160, 127);
            this.btnAcriveTab.Name = "btnAcriveTab";
            this.btnAcriveTab.Size = new System.Drawing.Size(75, 23);
            this.btnAcriveTab.TabIndex = 5;
            this.btnAcriveTab.UseVisualStyleBackColor = true;
            this.btnAcriveTab.Click += new System.EventHandler(this.btnAcriveTab_Click);
            // 
            // btnInactiveTab
            // 
            this.btnInactiveTab.Location = new System.Drawing.Point(160, 156);
            this.btnInactiveTab.Name = "btnInactiveTab";
            this.btnInactiveTab.Size = new System.Drawing.Size(75, 23);
            this.btnInactiveTab.TabIndex = 4;
            this.btnInactiveTab.UseVisualStyleBackColor = true;
            this.btnInactiveTab.Click += new System.EventHandler(this.btnInactiveTab_Click);
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(160, 67);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(75, 23);
            this.btnFrame.TabIndex = 3;
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Window frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inactive tabs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acrive tab";
            // 
            // pbInternetExplorer
            // 
            this.pbInternetExplorer.Image = ((System.Drawing.Image)(resources.GetObject("pbInternetExplorer.Image")));
            this.pbInternetExplorer.Location = new System.Drawing.Point(0, 27);
            this.pbInternetExplorer.Name = "pbInternetExplorer";
            this.pbInternetExplorer.Size = new System.Drawing.Size(841, 154);
            this.pbInternetExplorer.TabIndex = 10;
            this.pbInternetExplorer.TabStop = false;
            // 
            // pbDefault
            // 
            this.pbDefault.Image = ((System.Drawing.Image)(resources.GetObject("pbDefault.Image")));
            this.pbDefault.Location = new System.Drawing.Point(0, 27);
            this.pbDefault.Name = "pbDefault";
            this.pbDefault.Size = new System.Drawing.Size(841, 154);
            this.pbDefault.TabIndex = 11;
            this.pbDefault.TabStop = false;
            // 
            // gbCustomColors
            // 
            this.gbCustomColors.Controls.Add(this.cbCustomColors);
            this.gbCustomColors.Controls.Add(this.btnInactiveTab);
            this.gbCustomColors.Controls.Add(this.btnAcriveTab);
            this.gbCustomColors.Controls.Add(this.label5);
            this.gbCustomColors.Controls.Add(this.label3);
            this.gbCustomColors.Controls.Add(this.label1);
            this.gbCustomColors.Controls.Add(this.btnPanelColor);
            this.gbCustomColors.Controls.Add(this.btnFrame);
            this.gbCustomColors.Controls.Add(this.label4);
            this.gbCustomColors.Controls.Add(this.cbWideAdressbarColor);
            this.gbCustomColors.Location = new System.Drawing.Point(580, 187);
            this.gbCustomColors.Name = "gbCustomColors";
            this.gbCustomColors.Size = new System.Drawing.Size(246, 271);
            this.gbCustomColors.TabIndex = 12;
            this.gbCustomColors.TabStop = false;
            this.gbCustomColors.Text = "Custom colors";
            // 
            // gbTipsAndTricks
            // 
            this.gbTipsAndTricks.Controls.Add(this.tbTipsAndTricks);
            this.gbTipsAndTricks.Location = new System.Drawing.Point(254, 187);
            this.gbTipsAndTricks.Name = "gbTipsAndTricks";
            this.gbTipsAndTricks.Size = new System.Drawing.Size(288, 308);
            this.gbTipsAndTricks.TabIndex = 13;
            this.gbTipsAndTricks.TabStop = false;
            this.gbTipsAndTricks.Text = "Tips";
            // 
            // tbTipsAndTricks
            // 
            this.tbTipsAndTricks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTipsAndTricks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipsAndTricks.Location = new System.Drawing.Point(6, 19);
            this.tbTipsAndTricks.Multiline = true;
            this.tbTipsAndTricks.Name = "tbTipsAndTricks";
            this.tbTipsAndTricks.Size = new System.Drawing.Size(276, 283);
            this.tbTipsAndTricks.TabIndex = 1;
            this.tbTipsAndTricks.Text = "Tips and tricks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Build and tested against Vivaldi 1.2.490.43";
            // 
            // tbVersion
            // 
            this.tbVersion.Location = new System.Drawing.Point(63, 311);
            this.tbVersion.Name = "tbVersion";
            this.tbVersion.Size = new System.Drawing.Size(144, 20);
            this.tbVersion.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(212, 91);
            this.label7.TabIndex = 16;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 314);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Version:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.reportProblemToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportProblemToolStripMenuItem
            // 
            this.reportProblemToolStripMenuItem.Name = "reportProblemToolStripMenuItem";
            this.reportProblemToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.reportProblemToolStripMenuItem.Text = "Report problem";
            this.reportProblemToolStripMenuItem.Click += new System.EventHandler(this.reportProblemToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 507);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbVersion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gbTipsAndTricks);
            this.Controls.Add(this.gbCustomColors);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbStyles);
            this.Controls.Add(this.btnResetToDefault);
            this.Controls.Add(this.btnApplyStyle);
            this.Controls.Add(this.btnPatchVivaldi);
            this.Controls.Add(this.btnCreateCopyOfOriginalHtml);
            this.Controls.Add(this.pbDefault);
            this.Controls.Add(this.pbInternetExplorer);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vivaldi Theme Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).EndInit();
            this.gbCustomColors.ResumeLayout(false);
            this.gbCustomColors.PerformLayout();
            this.gbTipsAndTricks.ResumeLayout(false);
            this.gbTipsAndTricks.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateCopyOfOriginalHtml;
        private System.Windows.Forms.Button btnPatchVivaldi;
        private System.Windows.Forms.Button btnApplyStyle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnResetToDefault;
        private System.Windows.Forms.ComboBox cbStyles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAcriveTab;
        private System.Windows.Forms.Button btnInactiveTab;
        private System.Windows.Forms.Button btnFrame;
        private System.Windows.Forms.Button btnPanelColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbCustomColors;
        private System.Windows.Forms.PictureBox pbInternetExplorer;
        private System.Windows.Forms.PictureBox pbDefault;
        private System.Windows.Forms.CheckBox cbWideAdressbarColor;
        private System.Windows.Forms.GroupBox gbCustomColors;
        private System.Windows.Forms.GroupBox gbTipsAndTricks;
        private System.Windows.Forms.TextBox tbTipsAndTricks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVersion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportProblemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
    }
}

