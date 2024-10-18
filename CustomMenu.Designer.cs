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
            this.btnBatchConvert = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnCopyPath = new System.Windows.Forms.Button();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.btnOpenwith = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSaveas = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(12, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 1);
            this.label1.TabIndex = 6;
            // 
            // btnBatchConvert
            // 
            this.btnBatchConvert.FlatAppearance.BorderSize = 0;
            this.btnBatchConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatchConvert.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatchConvert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnBatchConvert.Image = global::OMRON_IFZ_Viewer.Properties.Resources.icons8_batch_20;
            this.btnBatchConvert.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBatchConvert.Location = new System.Drawing.Point(12, 216);
            this.btnBatchConvert.Name = "btnBatchConvert";
            this.btnBatchConvert.Size = new System.Drawing.Size(293, 31);
            this.btnBatchConvert.TabIndex = 8;
            this.btnBatchConvert.Text = "       Batch convert";
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
            this.btnErase.Location = new System.Drawing.Point(12, 255);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(293, 31);
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
            this.btnCopyPath.Location = new System.Drawing.Point(12, 180);
            this.btnCopyPath.Name = "btnCopyPath";
            this.btnCopyPath.Size = new System.Drawing.Size(293, 31);
            this.btnCopyPath.TabIndex = 5;
            this.btnCopyPath.Text = "       Copy Path";
            this.btnCopyPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopyPath.UseVisualStyleBackColor = true;
            this.btnCopyPath.Click += new System.EventHandler(this.btnCopyPath_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.FlatAppearance.BorderSize = 0;
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenFolder.Image = global::OMRON_IFZ_Viewer.Properties.Resources.OpenFolder;
            this.btnOpenFolder.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenFolder.Location = new System.Drawing.Point(12, 148);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(293, 31);
            this.btnOpenFolder.TabIndex = 4;
            this.btnOpenFolder.Text = "      Open in explorer";
            this.btnOpenFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnOpenwith
            // 
            this.btnOpenwith.FlatAppearance.BorderSize = 0;
            this.btnOpenwith.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenwith.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenwith.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnOpenwith.Image = global::OMRON_IFZ_Viewer.Properties.Resources.OpenWith;
            this.btnOpenwith.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnOpenwith.Location = new System.Drawing.Point(12, 114);
            this.btnOpenwith.Name = "btnOpenwith";
            this.btnOpenwith.Size = new System.Drawing.Size(293, 31);
            this.btnOpenwith.TabIndex = 3;
            this.btnOpenwith.Text = "     Open with";
            this.btnOpenwith.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenwith.UseVisualStyleBackColor = true;
            this.btnOpenwith.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.FlatAppearance.BorderSize = 0;
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnCopy.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Copy1;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCopy.Location = new System.Drawing.Point(12, 80);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(293, 31);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "     Copy";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSaveas
            // 
            this.btnSaveas.FlatAppearance.BorderSize = 0;
            this.btnSaveas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveas.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnSaveas.Image = global::OMRON_IFZ_Viewer.Properties.Resources.SaveAs;
            this.btnSaveas.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSaveas.Location = new System.Drawing.Point(12, 12);
            this.btnSaveas.Name = "btnSaveas";
            this.btnSaveas.Size = new System.Drawing.Size(293, 31);
            this.btnSaveas.TabIndex = 1;
            this.btnSaveas.Text = "     Save as";
            this.btnSaveas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveas.UseVisualStyleBackColor = true;
            this.btnSaveas.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnPrint.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Print;
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnPrint.Location = new System.Drawing.Point(12, 46);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(293, 31);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "    Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.button1_Click);
            // 
            // CustomMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(317, 305);
            this.Controls.Add(this.btnBatchConvert);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyPath);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.btnOpenwith);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnSaveas);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Button btnCopyPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnBatchConvert;
    }
}