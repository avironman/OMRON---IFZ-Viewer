namespace OMRON_IFZ_Viewer
{
    partial class CustomMenu
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGetPixel = new System.Windows.Forms.Button();
            this.btnBatchConvert = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.btnOpenInBrowser = new System.Windows.Forms.Button();
            this.btnOpenwith = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSaveas = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFolder = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnFlipUD = new System.Windows.Forms.Button();
            this.btnFlipLR = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 477);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 2);
            this.label1.TabIndex = 6;
            // 
            // btnGetPixel
            // 
            this.btnGetPixel.FlatAppearance.BorderSize = 0;
            this.btnGetPixel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetPixel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetPixel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnGetPixel.Image = global::OMRON_IFZ_Viewer.Properties.Resources.icons8_pipette_20;
            this.btnGetPixel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnGetPixel.Location = new System.Drawing.Point(10, 444);
            this.btnGetPixel.Name = "btnGetPixel";
            this.btnGetPixel.Size = new System.Drawing.Size(290, 30);
            this.btnGetPixel.TabIndex = 9;
            this.btnGetPixel.Text = "      Copy pixel info";
            this.btnGetPixel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPixel.UseVisualStyleBackColor = true;
            this.btnGetPixel.Click += new System.EventHandler(this.btnGetPixel_Click);
            // 
            // btnBatchConvert
            // 
            this.btnBatchConvert.FlatAppearance.BorderSize = 0;
            this.btnBatchConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBatchConvert.Image = global::OMRON_IFZ_Viewer.Properties.Resources.icons8_batch_20;
            this.btnBatchConvert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBatchConvert.Location = new System.Drawing.Point(10, 411);
            this.btnBatchConvert.Name = "btnBatchConvert";
            this.btnBatchConvert.Size = new System.Drawing.Size(290, 30);
            this.btnBatchConvert.TabIndex = 8;
            this.btnBatchConvert.Text = "      Batch convert";
            this.btnBatchConvert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBatchConvert.UseVisualStyleBackColor = true;
            this.btnBatchConvert.Click += new System.EventHandler(this.btnBatchConvert_Click);
            // 
            // btnErase
            // 
            this.btnErase.FlatAppearance.BorderSize = 0;
            this.btnErase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnErase.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnErase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(164)))));
            this.btnErase.Image = global::OMRON_IFZ_Viewer.Properties.Resources.RedTrash;
            this.btnErase.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnErase.Location = new System.Drawing.Point(10, 482);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(290, 30);
            this.btnErase.TabIndex = 7;
            this.btnErase.Text = "       Delete file";
            this.btnErase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnCopyPath
            // 
            this.btnCopyPath.FlatAppearance.BorderSize = 0;
            this.btnCopyPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopyPath.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCopyPath.Image = global::OMRON_IFZ_Viewer.Properties.Resources.CopyPath;
            this.btnCopyPath.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCopyPath.Location = new System.Drawing.Point(10, 312);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(290, 30);
            this.btnCopyPath.TabIndex = 5;
            this.btnCopyPath.Text = "      Copy Path";
            this.btnCopyPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyPath.UseVisualStyleBackColor = true;
            this.btnCopyPath.Click += new System.EventHandler(this.btnCopyPath_Click);
            // 
            // btnOpenInBrowser
            // 
            this.btnOpenInBrowser.FlatAppearance.BorderSize = 0;
            this.btnOpenInBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenInBrowser.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenInBrowser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenInBrowser.Image = global::OMRON_IFZ_Viewer.Properties.Resources.OpenFolder;
            this.btnOpenInBrowser.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenInBrowser.Location = new System.Drawing.Point(10, 378);
            this.btnOpenInBrowser.Name = "btnOpenInBrowser";
            this.btnOpenInBrowser.Size = new System.Drawing.Size(290, 30);
            this.btnOpenInBrowser.TabIndex = 4;
            this.btnOpenInBrowser.Text = "      Open in explorer";
            this.btnOpenInBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenInBrowser.UseVisualStyleBackColor = true;
            this.btnOpenInBrowser.Click += new System.EventHandler(this.btnOpenInExplorer_Click);
            // 
            // btnOpenwith
            // 
            this.btnOpenwith.FlatAppearance.BorderSize = 0;
            this.btnOpenwith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenwith.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenwith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenwith.Image = global::OMRON_IFZ_Viewer.Properties.Resources.OpenWith;
            this.btnOpenwith.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenwith.Location = new System.Drawing.Point(10, 345);
            this.btnOpenwith.Name = "btnOpenwith";
            this.btnOpenwith.Size = new System.Drawing.Size(290, 30);
            this.btnOpenwith.TabIndex = 3;
            this.btnOpenwith.Text = "      Open with";
            this.btnOpenwith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenwith.UseVisualStyleBackColor = true;
            this.btnOpenwith.Click += new System.EventHandler(this.btnOpenWith_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCopy.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Copy1;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCopy.Location = new System.Drawing.Point(10, 279);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(290, 30);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "      Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnSaveas
            // 
            this.btnSaveas.FlatAppearance.BorderSize = 0;
            this.btnSaveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSaveas.Image = global::OMRON_IFZ_Viewer.Properties.Resources.SaveAs;
            this.btnSaveas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveas.Location = new System.Drawing.Point(10, 246);
            this.btnSaveas.Name = "btnSaveas";
            this.btnSaveas.Size = new System.Drawing.Size(290, 30);
            this.btnSaveas.TabIndex = 1;
            this.btnSaveas.Text = "      Save as";
            this.btnSaveas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveas.UseVisualStyleBackColor = true;
            this.btnSaveas.Click += new System.EventHandler(this.btnSaveAs_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPrint.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrint.Location = new System.Drawing.Point(10, 76);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(290, 30);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "      Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(10, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 2);
            this.label2.TabIndex = 10;
            // 
            // btnFolder
            // 
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnFolder.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Folder;
            this.btnFolder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFolder.Location = new System.Drawing.Point(10, 10);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(290, 30);
            this.btnFolder.TabIndex = 11;
            this.btnFolder.Text = "      Open folder";
            this.btnFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRotate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnRotate.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Rotate;
            this.btnRotate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRotate.Location = new System.Drawing.Point(10, 43);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(290, 30);
            this.btnRotate.TabIndex = 12;
            this.btnRotate.Text = "      Rotate image";
            this.btnRotate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSettings.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Settings;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSettings.Location = new System.Drawing.Point(10, 109);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(290, 30);
            this.btnSettings.TabIndex = 14;
            this.btnSettings.Text = "      Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnFlipUD
            // 
            this.btnFlipUD.FlatAppearance.BorderSize = 0;
            this.btnFlipUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipUD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlipUD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnFlipUD.Image = global::OMRON_IFZ_Viewer.Properties.Resources.FlipUD;
            this.btnFlipUD.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFlipUD.Location = new System.Drawing.Point(10, 175);
            this.btnFlipUD.Name = "btnFlipUD";
            this.btnFlipUD.Size = new System.Drawing.Size(290, 30);
            this.btnFlipUD.TabIndex = 15;
            this.btnFlipUD.Text = "      Flip Up Down";
            this.btnFlipUD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlipUD.UseVisualStyleBackColor = true;
            this.btnFlipUD.Click += new System.EventHandler(this.btnFlipUD_Click);
            // 
            // btnFlipLR
            // 
            this.btnFlipLR.FlatAppearance.BorderSize = 0;
            this.btnFlipLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipLR.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlipLR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnFlipLR.Image = global::OMRON_IFZ_Viewer.Properties.Resources.FlipLR;
            this.btnFlipLR.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFlipLR.Location = new System.Drawing.Point(10, 142);
            this.btnFlipLR.Name = "btnFlipLR";
            this.btnFlipLR.Size = new System.Drawing.Size(290, 30);
            this.btnFlipLR.TabIndex = 16;
            this.btnFlipLR.Text = "      Flip Left Right";
            this.btnFlipLR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlipLR.UseVisualStyleBackColor = true;
            this.btnFlipLR.Click += new System.EventHandler(this.btnFlipLR_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnInfo.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Info;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnInfo.Location = new System.Drawing.Point(10, 208);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(290, 30);
            this.btnInfo.TabIndex = 17;
            this.btnInfo.Text = "      Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // CustomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(317, 516);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnFlipLR);
            this.Controls.Add(this.btnFlipUD);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBatchConvert);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyPath);
            this.Controls.Add(this.btnOpenInBrowser);
            this.Controls.Add(this.btnOpenwith);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSaveas);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGetPixel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomMenu";
            this.Text = "CustomMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveas;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnOpenwith;
        private System.Windows.Forms.Button btnOpenInBrowser;
        private System.Windows.Forms.Button btnCopyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnBatchConvert;
        private System.Windows.Forms.Button btnGetPixel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnFlipUD;
        private System.Windows.Forms.Button btnFlipLR;
        private System.Windows.Forms.Button btnInfo;
    }
}