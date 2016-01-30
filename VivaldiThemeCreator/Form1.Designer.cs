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
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetExplorer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).BeginInit();
            this.gbCustomColors.SuspendLayout();
            this.gbTipsAndTricks.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateCopyOfOriginalHtml
            // 
            this.btnCreateCopyOfOriginalHtml.Location = new System.Drawing.Point(12, 221);
            this.btnCreateCopyOfOriginalHtml.Name = "btnCreateCopyOfOriginalHtml";
            this.btnCreateCopyOfOriginalHtml.Size = new System.Drawing.Size(182, 23);
            this.btnCreateCopyOfOriginalHtml.TabIndex = 0;
            this.btnCreateCopyOfOriginalHtml.Text = "Create copy of original html";
            this.btnCreateCopyOfOriginalHtml.UseVisualStyleBackColor = true;
            this.btnCreateCopyOfOriginalHtml.Click += new System.EventHandler(this.btnCreateCopyOfOriginalHtml_Click);
            // 
            // btnPatchVivaldi
            // 
            this.btnPatchVivaldi.Location = new System.Drawing.Point(12, 250);
            this.btnPatchVivaldi.Name = "btnPatchVivaldi";
            this.btnPatchVivaldi.Size = new System.Drawing.Size(182, 23);
            this.btnPatchVivaldi.TabIndex = 1;
            this.btnPatchVivaldi.Text = "PatchVivaldi";
            this.btnPatchVivaldi.UseVisualStyleBackColor = true;
            this.btnPatchVivaldi.Click += new System.EventHandler(this.btnPatchVivaldi_Click);
            // 
            // btnApplyStyle
            // 
            this.btnApplyStyle.Location = new System.Drawing.Point(12, 325);
            this.btnApplyStyle.Name = "btnApplyStyle";
            this.btnApplyStyle.Size = new System.Drawing.Size(182, 23);
            this.btnApplyStyle.TabIndex = 2;
            this.btnApplyStyle.Text = "ApplyStyle";
            this.btnApplyStyle.UseVisualStyleBackColor = true;
            this.btnApplyStyle.Click += new System.EventHandler(this.btnApplyStyle_Click);
            // 
            // btnResetToDefault
            // 
            this.btnResetToDefault.Location = new System.Drawing.Point(12, 279);
            this.btnResetToDefault.Name = "btnResetToDefault";
            this.btnResetToDefault.Size = new System.Drawing.Size(183, 23);
            this.btnResetToDefault.TabIndex = 5;
            this.btnResetToDefault.Text = "Reset to defaults";
            this.btnResetToDefault.UseVisualStyleBackColor = true;
            this.btnResetToDefault.Click += new System.EventHandler(this.btnResetToDefault_Click);
            // 
            // cbStyles
            // 
            this.cbStyles.FormattingEnabled = true;
            this.cbStyles.Location = new System.Drawing.Point(12, 183);
            this.cbStyles.Name = "cbStyles";
            this.cbStyles.Size = new System.Drawing.Size(182, 21);
            this.cbStyles.TabIndex = 6;
            this.cbStyles.SelectedIndexChanged += new System.EventHandler(this.cbStyles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 167);
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
            this.cbWideAdressbarColor.Location = new System.Drawing.Point(80, 167);
            this.cbWideAdressbarColor.Name = "cbWideAdressbarColor";
            this.cbWideAdressbarColor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbWideAdressbarColor.Size = new System.Drawing.Size(139, 17);
            this.cbWideAdressbarColor.TabIndex = 9;
            this.cbWideAdressbarColor.Text = "Fix wide adressbar color";
            this.cbWideAdressbarColor.UseVisualStyleBackColor = true;
            // 
            // cbCustomColors
            // 
            this.cbCustomColors.AutoSize = true;
            this.cbCustomColors.Location = new System.Drawing.Point(106, 19);
            this.cbCustomColors.Name = "cbCustomColors";
            this.cbCustomColors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbCustomColors.Size = new System.Drawing.Size(113, 17);
            this.cbCustomColors.TabIndex = 8;
            this.cbCustomColors.Text = "Use custom colors";
            this.cbCustomColors.UseVisualStyleBackColor = true;
            // 
            // btnPanelColor
            // 
            this.btnPanelColor.Location = new System.Drawing.Point(144, 72);
            this.btnPanelColor.Name = "btnPanelColor";
            this.btnPanelColor.Size = new System.Drawing.Size(75, 23);
            this.btnPanelColor.TabIndex = 7;
            this.btnPanelColor.UseVisualStyleBackColor = true;
            this.btnPanelColor.Click += new System.EventHandler(this.btnPanelColor_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(104, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Panel";
            // 
            // btnAcriveTab
            // 
            this.btnAcriveTab.Location = new System.Drawing.Point(144, 101);
            this.btnAcriveTab.Name = "btnAcriveTab";
            this.btnAcriveTab.Size = new System.Drawing.Size(75, 23);
            this.btnAcriveTab.TabIndex = 5;
            this.btnAcriveTab.UseVisualStyleBackColor = true;
            this.btnAcriveTab.Click += new System.EventHandler(this.btnAcriveTab_Click);
            // 
            // btnInactiveTab
            // 
            this.btnInactiveTab.Location = new System.Drawing.Point(144, 130);
            this.btnInactiveTab.Name = "btnInactiveTab";
            this.btnInactiveTab.Size = new System.Drawing.Size(75, 23);
            this.btnInactiveTab.TabIndex = 4;
            this.btnInactiveTab.UseVisualStyleBackColor = true;
            this.btnInactiveTab.Click += new System.EventHandler(this.btnInactiveTab_Click);
            // 
            // btnFrame
            // 
            this.btnFrame.Location = new System.Drawing.Point(144, 43);
            this.btnFrame.Name = "btnFrame";
            this.btnFrame.Size = new System.Drawing.Size(75, 23);
            this.btnFrame.TabIndex = 3;
            this.btnFrame.UseVisualStyleBackColor = true;
            this.btnFrame.Click += new System.EventHandler(this.btnFrame_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Window frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Inactive tabs";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Acrive tab";
            // 
            // pbInternetExplorer
            // 
            this.pbInternetExplorer.Image = ((System.Drawing.Image)(resources.GetObject("pbInternetExplorer.Image")));
            this.pbInternetExplorer.Location = new System.Drawing.Point(0, 0);
            this.pbInternetExplorer.Name = "pbInternetExplorer";
            this.pbInternetExplorer.Size = new System.Drawing.Size(841, 154);
            this.pbInternetExplorer.TabIndex = 10;
            this.pbInternetExplorer.TabStop = false;
            // 
            // pbDefault
            // 
            this.pbDefault.Image = ((System.Drawing.Image)(resources.GetObject("pbDefault.Image")));
            this.pbDefault.Location = new System.Drawing.Point(0, 0);
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
            this.gbCustomColors.Location = new System.Drawing.Point(600, 160);
            this.gbCustomColors.Name = "gbCustomColors";
            this.gbCustomColors.Size = new System.Drawing.Size(226, 190);
            this.gbCustomColors.TabIndex = 12;
            this.gbCustomColors.TabStop = false;
            this.gbCustomColors.Text = "Custom colors";
            // 
            // gbTipsAndTricks
            // 
            this.gbTipsAndTricks.Controls.Add(this.tbTipsAndTricks);
            this.gbTipsAndTricks.Location = new System.Drawing.Point(297, 160);
            this.gbTipsAndTricks.Name = "gbTipsAndTricks";
            this.gbTipsAndTricks.Size = new System.Drawing.Size(200, 190);
            this.gbTipsAndTricks.TabIndex = 13;
            this.gbTipsAndTricks.TabStop = false;
            this.gbTipsAndTricks.Text = "Tips";
            // 
            // tbTipsAndTricks
            // 
            this.tbTipsAndTricks.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tbTipsAndTricks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTipsAndTricks.Location = new System.Drawing.Point(10, 23);
            this.tbTipsAndTricks.Multiline = true;
            this.tbTipsAndTricks.Name = "tbTipsAndTricks";
            this.tbTipsAndTricks.Size = new System.Drawing.Size(184, 161);
            this.tbTipsAndTricks.TabIndex = 1;
            this.tbTipsAndTricks.Text = "Tips and tricks";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 360);
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
            this.Name = "Form1";
            this.Text = "Vivaldi Theme Creator";
            ((System.ComponentModel.ISupportInitialize)(this.pbInternetExplorer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDefault)).EndInit();
            this.gbCustomColors.ResumeLayout(false);
            this.gbCustomColors.PerformLayout();
            this.gbTipsAndTricks.ResumeLayout(false);
            this.gbTipsAndTricks.PerformLayout();
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
    }
}

