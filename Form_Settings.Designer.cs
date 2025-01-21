namespace OMRON_IFZ_Viewer
{
    partial class Form_Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Settings));
            this.lbl1 = new System.Windows.Forms.Label();
            this.pnlLanguage = new System.Windows.Forms.Panel();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.pnlVersion = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblEmailJerome = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.pnlZoom = new System.Windows.Forms.Panel();
            this.lbl5 = new System.Windows.Forms.Label();
            this.cmbZoom = new System.Windows.Forms.ComboBox();
            this.pnlBtnColor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.cmbColor = new System.Windows.Forms.ComboBox();
            this.cmbThemeColor = new System.Windows.Forms.ComboBox();
            this.pnlThemeColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmailYury = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnClose = new RoundButton();
            this.pnlLanguage.SuspendLayout();
            this.pnlVersion.SuspendLayout();
            this.pnlZoom.SuspendLayout();
            this.pnlBtnColor.SuspendLayout();
            this.pnlThemeColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl1.Location = new System.Drawing.Point(15, 104);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(293, 20);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Personalisation";
            // 
            // pnlLanguage
            // 
            this.pnlLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLanguage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlLanguage.Controls.Add(this.lbl2);
            this.pnlLanguage.Controls.Add(this.cmbLanguage);
            this.pnlLanguage.Location = new System.Drawing.Point(15, 127);
            this.pnlLanguage.Name = "pnlLanguage";
            this.pnlLanguage.Size = new System.Drawing.Size(849, 71);
            this.pnlLanguage.TabIndex = 4;
            // 
            // lbl2
            // 
            this.lbl2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl2.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Localization;
            this.lbl2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl2.Location = new System.Drawing.Point(9, 19);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(582, 34);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Langue";
            this.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLanguage.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbLanguage.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.cmbLanguage.Location = new System.Drawing.Point(597, 25);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(243, 25);
            this.cmbLanguage.TabIndex = 0;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.cmbLanguage_SelectedIndexChanged);
            // 
            // pnlVersion
            // 
            this.pnlVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVersion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlVersion.Controls.Add(this.lblVersion);
            this.pnlVersion.Controls.Add(this.lbl4);
            this.pnlVersion.Location = new System.Drawing.Point(15, 485);
            this.pnlVersion.Name = "pnlVersion";
            this.pnlVersion.Size = new System.Drawing.Size(849, 71);
            this.pnlVersion.TabIndex = 5;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblVersion.Location = new System.Drawing.Point(597, 19);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(243, 34);
            this.lblVersion.TabIndex = 9;
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl4
            // 
            this.lbl4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl4.Image = global::OMRON_IFZ_Viewer.Properties.Resources.favicon;
            this.lbl4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl4.Location = new System.Drawing.Point(9, 19);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(582, 34);
            this.lbl4.TabIndex = 4;
            this.lbl4.Text = "Version";
            this.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmailJerome
            // 
            this.lblEmailJerome.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailJerome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEmailJerome.Location = new System.Drawing.Point(687, 595);
            this.lblEmailJerome.Name = "lblEmailJerome";
            this.lblEmailJerome.Size = new System.Drawing.Size(177, 26);
            this.lblEmailJerome.TabIndex = 8;
            this.lblEmailJerome.Text = "pinard.jerome@gmail.com";
            this.lblEmailJerome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmailJerome.Click += new System.EventHandler(this.emailJerome_Click);
            // 
            // lbl3
            // 
            this.lbl3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl3.Location = new System.Drawing.Point(15, 462);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(293, 20);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = "Personalisation";
            // 
            // pnlZoom
            // 
            this.pnlZoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlZoom.Controls.Add(this.lbl5);
            this.pnlZoom.Controls.Add(this.cmbZoom);
            this.pnlZoom.Location = new System.Drawing.Point(15, 201);
            this.pnlZoom.Name = "pnlZoom";
            this.pnlZoom.Size = new System.Drawing.Size(849, 71);
            this.pnlZoom.TabIndex = 5;
            // 
            // lbl5
            // 
            this.lbl5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl5.Image = global::OMRON_IFZ_Viewer.Properties.Resources.ZoomPref;
            this.lbl5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl5.Location = new System.Drawing.Point(9, 19);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(582, 34);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Préférence de zoom";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbZoom
            // 
            this.cmbZoom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbZoom.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbZoom.FormattingEnabled = true;
            this.cmbZoom.Items.AddRange(new object[] {
            "Français",
            "English"});
            this.cmbZoom.Location = new System.Drawing.Point(597, 25);
            this.cmbZoom.Name = "cmbZoom";
            this.cmbZoom.Size = new System.Drawing.Size(243, 25);
            this.cmbZoom.TabIndex = 0;
            this.cmbZoom.SelectedIndexChanged += new System.EventHandler(this.cmbZoom_SelectedIndexChanged);
            // 
            // pnlBtnColor
            // 
            this.pnlBtnColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBtnColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlBtnColor.Controls.Add(this.label2);
            this.pnlBtnColor.Controls.Add(this.btnSettings);
            this.pnlBtnColor.Controls.Add(this.lbl6);
            this.pnlBtnColor.Controls.Add(this.cmbColor);
            this.pnlBtnColor.Location = new System.Drawing.Point(15, 275);
            this.pnlBtnColor.Name = "pnlBtnColor";
            this.pnlBtnColor.Size = new System.Drawing.Size(849, 71);
            this.pnlBtnColor.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Preview:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl6
            // 
            this.lbl6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lbl6.Image = global::OMRON_IFZ_Viewer.Properties.Resources.icons8_theme_26;
            this.lbl6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl6.Location = new System.Drawing.Point(9, 19);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(582, 34);
            this.lbl6.TabIndex = 4;
            this.lbl6.Text = "Button color";
            this.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmbColor
            // 
            this.cmbColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(597, 25);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.Size = new System.Drawing.Size(243, 25);
            this.cmbColor.TabIndex = 0;
            this.cmbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbColor_DrawItem);
            this.cmbColor.SelectedIndexChanged += new System.EventHandler(this.cmbColor_SelectedIndexChanged);
            // 
            // cmbThemeColor
            // 
            this.cmbThemeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbThemeColor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmbThemeColor.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbThemeColor.FormattingEnabled = true;
            this.cmbThemeColor.Location = new System.Drawing.Point(597, 25);
            this.cmbThemeColor.Name = "cmbThemeColor";
            this.cmbThemeColor.Size = new System.Drawing.Size(243, 25);
            this.cmbThemeColor.TabIndex = 0;
            this.cmbThemeColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbThemeColor_DrawItem);
            this.cmbThemeColor.SelectedIndexChanged += new System.EventHandler(this.cmbThemeColor_SelectedIndexChanged);
            // 
            // pnlThemeColor
            // 
            this.pnlThemeColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlThemeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.pnlThemeColor.Controls.Add(this.label1);
            this.pnlThemeColor.Controls.Add(this.cmbThemeColor);
            this.pnlThemeColor.Location = new System.Drawing.Point(15, 350);
            this.pnlThemeColor.Name = "pnlThemeColor";
            this.pnlThemeColor.Size = new System.Drawing.Size(849, 71);
            this.pnlThemeColor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.label1.Image = global::OMRON_IFZ_Viewer.Properties.Resources.icons8_paint_roller_26;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Theme color";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::OMRON_IFZ_Viewer.Properties.Resources.LOGO;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(714, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 63);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitle.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Settings_2;
            this.lblTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitle.Location = new System.Drawing.Point(21, 33);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(193, 34);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Paramètres";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmailYury
            // 
            this.lblEmailYury.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailYury.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblEmailYury.Location = new System.Drawing.Point(687, 621);
            this.lblEmailYury.Name = "lblEmailYury";
            this.lblEmailYury.Size = new System.Drawing.Size(177, 26);
            this.lblEmailYury.TabIndex = 30;
            this.lblEmailYury.Text = "yury.puzino@omron.com";
            this.lblEmailYury.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblEmailYury.Click += new System.EventHandler(this.emailYury_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSettings.BackColor = global::OMRON_IFZ_Viewer.Properties.Settings.Default.ThemeColor;
            this.btnSettings.Enabled = false;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(299, 14);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 46);
            this.btnSettings.TabIndex = 29;
            this.btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnClose.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(185)))), ((int)(((byte)(237)))));
            this.btnClose.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(372, 612);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(169)))), ((int)(((byte)(216)))));
            this.btnClose.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnClose.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnClose.Size = new System.Drawing.Size(134, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Fermer";
            this.btnClose.TextColor = System.Drawing.Color.Black;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(876, 656);
            this.Controls.Add(this.lblEmailYury);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lblEmailJerome);
            this.Controls.Add(this.pnlLanguage);
            this.Controls.Add(this.pnlZoom);
            this.Controls.Add(this.pnlBtnColor);
            this.Controls.Add(this.pnlThemeColor);
            this.Controls.Add(this.pnlVersion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Settings";
            this.Load += new System.EventHandler(this.Form_Settings_Load);
            this.pnlLanguage.ResumeLayout(false);
            this.pnlVersion.ResumeLayout(false);
            this.pnlZoom.ResumeLayout(false);
            this.pnlBtnColor.ResumeLayout(false);
            this.pnlThemeColor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private RoundButton btnClose;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlLanguage;
        private System.Windows.Forms.ComboBox cmbLanguage;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Panel pnlVersion;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblEmailJerome;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlZoom;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.ComboBox cmbZoom;
        private System.Windows.Forms.Panel pnlBtnColor;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.ComboBox cmbColor;
        private System.Windows.Forms.ComboBox cmbThemeColor;
        private System.Windows.Forms.Panel pnlThemeColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblEmailYury;
        private System.Windows.Forms.Label label2;
    }
}