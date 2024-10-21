using System.Drawing;
using System.Windows.Forms;

namespace OMRON_IFZ_Viewer
{
    partial class Form_DisplayImage
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_DisplayImage));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlImageMgmt = new System.Windows.Forms.Panel();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnFlipUD = new System.Windows.Forms.Button();
            this.btnFlipLR = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnTrash = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnFolder = new System.Windows.Forms.Button();
            this.lblFileNb = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.pnlControlBox = new System.Windows.Forms.Panel();
            this.btnReduce = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.cb8 = new System.Windows.Forms.CheckBox();
            this.cb7 = new System.Windows.Forms.CheckBox();
            this.cb6 = new System.Windows.Forms.CheckBox();
            this.cb5 = new System.Windows.Forms.CheckBox();
            this.cb4 = new System.Windows.Forms.CheckBox();
            this.cb3 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.lblPixelPos = new System.Windows.Forms.Label();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblPixelValue = new System.Windows.Forms.Label();
            this.lblZoom = new System.Windows.Forms.Label();
            this.btnRibbon = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.btnZoomToFit = new System.Windows.Forms.Button();
            this.btnZoomToScale = new System.Windows.Forms.Button();
            this.btnFullScreen = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listByrImgView = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlImageInfo = new System.Windows.Forms.Panel();
            this.lblCamera2 = new System.Windows.Forms.Label();
            this.lblCamera = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.lblSize2 = new System.Windows.Forms.Label();
            this.lblFolder = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSizeInfo = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbIFZName = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlImageInfo_ClosePanel = new System.Windows.Forms.Button();
            this.pnlImageInfo_Title = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlHeader.SuspendLayout();
            this.pnlImageMgmt.SuspendLayout();
            this.pnlControlBox.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlImageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlHeader.Controls.Add(this.pnlImageMgmt);
            this.pnlHeader.Controls.Add(this.lblFileNb);
            this.pnlHeader.Controls.Add(this.lblName);
            this.pnlHeader.Controls.Add(this.btnMain);
            this.pnlHeader.Controls.Add(this.pnlControlBox);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1396, 46);
            this.pnlHeader.TabIndex = 5;
            this.pnlHeader.DoubleClick += new System.EventHandler(this.panel1_DoubleClick);
            this.pnlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.pnlHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.pnlHeader.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // pnlImageMgmt
            // 
            this.pnlImageMgmt.Controls.Add(this.btnInfo);
            this.pnlImageMgmt.Controls.Add(this.btnFlipUD);
            this.pnlImageMgmt.Controls.Add(this.btnFlipLR);
            this.pnlImageMgmt.Controls.Add(this.btnSettings);
            this.pnlImageMgmt.Controls.Add(this.btnPrint);
            this.pnlImageMgmt.Controls.Add(this.btnTrash);
            this.pnlImageMgmt.Controls.Add(this.btnRotate);
            this.pnlImageMgmt.Controls.Add(this.btnFolder);
            this.pnlImageMgmt.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlImageMgmt.Location = new System.Drawing.Point(544, 0);
            this.pnlImageMgmt.Name = "pnlImageMgmt";
            this.pnlImageMgmt.Size = new System.Drawing.Size(372, 46);
            this.pnlImageMgmt.TabIndex = 10;
            // 
            // btnInfo
            // 
            this.btnInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.Image = ((System.Drawing.Image)(resources.GetObject("btnInfo.Image")));
            this.btnInfo.Location = new System.Drawing.Point(322, 0);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(46, 46);
            this.btnInfo.TabIndex = 32;
            this.btnInfo.UseVisualStyleBackColor = false;
            this.btnInfo.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFlipUD
            // 
            this.btnFlipUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFlipUD.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFlipUD.FlatAppearance.BorderSize = 0;
            this.btnFlipUD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnFlipUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipUD.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipUD.Image")));
            this.btnFlipUD.Location = new System.Drawing.Point(276, 0);
            this.btnFlipUD.Name = "btnFlipUD";
            this.btnFlipUD.Size = new System.Drawing.Size(46, 46);
            this.btnFlipUD.TabIndex = 31;
            this.btnFlipUD.UseVisualStyleBackColor = false;
            this.btnFlipUD.Click += new System.EventHandler(this.btnFlipUD_Click);
            // 
            // btnFlipLR
            // 
            this.btnFlipLR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFlipLR.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFlipLR.FlatAppearance.BorderSize = 0;
            this.btnFlipLR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnFlipLR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlipLR.Image = ((System.Drawing.Image)(resources.GetObject("btnFlipLR.Image")));
            this.btnFlipLR.Location = new System.Drawing.Point(230, 0);
            this.btnFlipLR.Name = "btnFlipLR";
            this.btnFlipLR.Size = new System.Drawing.Size(46, 46);
            this.btnFlipLR.TabIndex = 30;
            this.btnFlipLR.UseVisualStyleBackColor = false;
            this.btnFlipLR.Click += new System.EventHandler(this.btnFlipLR_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(184, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(46, 46);
            this.btnSettings.TabIndex = 28;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(138, 0);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(46, 46);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnTrash
            // 
            this.btnTrash.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnTrash.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTrash.FlatAppearance.BorderSize = 0;
            this.btnTrash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrash.Image = ((System.Drawing.Image)(resources.GetObject("btnTrash.Image")));
            this.btnTrash.Location = new System.Drawing.Point(92, 0);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(46, 46);
            this.btnTrash.TabIndex = 9;
            this.btnTrash.UseVisualStyleBackColor = false;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // btnRotate
            // 
            this.btnRotate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnRotate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRotate.FlatAppearance.BorderSize = 0;
            this.btnRotate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotate.Image = ((System.Drawing.Image)(resources.GetObject("btnRotate.Image")));
            this.btnRotate.Location = new System.Drawing.Point(46, 0);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(46, 46);
            this.btnRotate.TabIndex = 29;
            this.btnRotate.UseVisualStyleBackColor = false;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnFolder
            // 
            this.btnFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnFolder.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFolder.FlatAppearance.BorderSize = 0;
            this.btnFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnFolder.Image")));
            this.btnFolder.Location = new System.Drawing.Point(0, 0);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(46, 46);
            this.btnFolder.TabIndex = 11;
            this.btnFolder.UseVisualStyleBackColor = false;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // lblFileNb
            // 
            this.lblFileNb.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblFileNb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileNb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFileNb.Location = new System.Drawing.Point(485, 0);
            this.lblFileNb.Name = "lblFileNb";
            this.lblFileNb.Size = new System.Drawing.Size(59, 46);
            this.lblFileNb.TabIndex = 11;
            this.lblFileNb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblName.Location = new System.Drawing.Point(46, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(439, 46);
            this.lblName.TabIndex = 9;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.lblName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.lblName.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMain.FlatAppearance.BorderSize = 0;
            this.btnMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Image = ((System.Drawing.Image)(resources.GetObject("btnMain.Image")));
            this.btnMain.Location = new System.Drawing.Point(0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(46, 46);
            this.btnMain.TabIndex = 8;
            this.btnMain.UseVisualStyleBackColor = false;
            // 
            // pnlControlBox
            // 
            this.pnlControlBox.Controls.Add(this.btnReduce);
            this.pnlControlBox.Controls.Add(this.btnMinimize);
            this.pnlControlBox.Controls.Add(this.btnClose);
            this.pnlControlBox.Controls.Add(this.btnMaximize);
            this.pnlControlBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlControlBox.Location = new System.Drawing.Point(1216, 0);
            this.pnlControlBox.Name = "pnlControlBox";
            this.pnlControlBox.Size = new System.Drawing.Size(180, 46);
            this.pnlControlBox.TabIndex = 7;
            this.pnlControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            // 
            // btnReduce
            // 
            this.btnReduce.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnReduce.FlatAppearance.BorderSize = 0;
            this.btnReduce.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnReduce.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReduce.Image = ((System.Drawing.Image)(resources.GetObject("btnReduce.Image")));
            this.btnReduce.Location = new System.Drawing.Point(85, 0);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(46, 32);
            this.btnReduce.TabIndex = 4;
            this.btnReduce.UseVisualStyleBackColor = false;
            this.btnReduce.Visible = false;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            this.btnReduce.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(36, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(46, 32);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(134, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximize.Image")));
            this.btnMaximize.Location = new System.Drawing.Point(83, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(46, 32);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.pnlFooter.Controls.Add(this.cb8);
            this.pnlFooter.Controls.Add(this.cb7);
            this.pnlFooter.Controls.Add(this.cb6);
            this.pnlFooter.Controls.Add(this.cb5);
            this.pnlFooter.Controls.Add(this.cb4);
            this.pnlFooter.Controls.Add(this.cb3);
            this.pnlFooter.Controls.Add(this.cb2);
            this.pnlFooter.Controls.Add(this.cb1);
            this.pnlFooter.Controls.Add(this.lblPixelPos);
            this.pnlFooter.Controls.Add(this.lblColor);
            this.pnlFooter.Controls.Add(this.lblPixelValue);
            this.pnlFooter.Controls.Add(this.lblZoom);
            this.pnlFooter.Controls.Add(this.btnRibbon);
            this.pnlFooter.Controls.Add(this.btnZoomOut);
            this.pnlFooter.Controls.Add(this.btnZoomIn);
            this.pnlFooter.Controls.Add(this.btnZoomToFit);
            this.pnlFooter.Controls.Add(this.btnZoomToScale);
            this.pnlFooter.Controls.Add(this.btnFullScreen);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 777);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1396, 38);
            this.pnlFooter.TabIndex = 6;
            this.pnlFooter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.pnlFooter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.pnlFooter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // cb8
            // 
            this.cb8.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb8.FlatAppearance.BorderSize = 0;
            this.cb8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb8.Location = new System.Drawing.Point(304, 0);
            this.cb8.Name = "cb8";
            this.cb8.Size = new System.Drawing.Size(38, 38);
            this.cb8.TabIndex = 35;
            this.cb8.Text = "8";
            this.cb8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb8.UseVisualStyleBackColor = true;
            this.cb8.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb7
            // 
            this.cb7.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb7.FlatAppearance.BorderSize = 0;
            this.cb7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb7.Location = new System.Drawing.Point(266, 0);
            this.cb7.Name = "cb7";
            this.cb7.Size = new System.Drawing.Size(38, 38);
            this.cb7.TabIndex = 34;
            this.cb7.Text = "7";
            this.cb7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb7.UseVisualStyleBackColor = true;
            this.cb7.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb6
            // 
            this.cb6.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb6.FlatAppearance.BorderSize = 0;
            this.cb6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb6.Location = new System.Drawing.Point(228, 0);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(38, 38);
            this.cb6.TabIndex = 33;
            this.cb6.Text = "6";
            this.cb6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb6.UseVisualStyleBackColor = true;
            this.cb6.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb5
            // 
            this.cb5.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb5.FlatAppearance.BorderSize = 0;
            this.cb5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb5.Location = new System.Drawing.Point(190, 0);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(38, 38);
            this.cb5.TabIndex = 32;
            this.cb5.Text = "5";
            this.cb5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb5.UseVisualStyleBackColor = true;
            this.cb5.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb4
            // 
            this.cb4.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb4.FlatAppearance.BorderSize = 0;
            this.cb4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb4.Location = new System.Drawing.Point(152, 0);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(38, 38);
            this.cb4.TabIndex = 31;
            this.cb4.Text = "4";
            this.cb4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb4.UseVisualStyleBackColor = true;
            this.cb4.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb3
            // 
            this.cb3.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb3.FlatAppearance.BorderSize = 0;
            this.cb3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb3.Location = new System.Drawing.Point(114, 0);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(38, 38);
            this.cb3.TabIndex = 30;
            this.cb3.Text = "3";
            this.cb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb3.UseVisualStyleBackColor = true;
            this.cb3.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb2.FlatAppearance.BorderSize = 0;
            this.cb2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb2.Location = new System.Drawing.Point(76, 0);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(38, 38);
            this.cb2.TabIndex = 29;
            this.cb2.Text = "2";
            this.cb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.Appearance = System.Windows.Forms.Appearance.Button;
            this.cb1.FlatAppearance.BorderSize = 0;
            this.cb1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.cb1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.cb1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.cb1.Location = new System.Drawing.Point(38, 0);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(38, 38);
            this.cb1.TabIndex = 28;
            this.cb1.Text = "1";
            this.cb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            // 
            // lblPixelPos
            // 
            this.lblPixelPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lblPixelPos.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPixelPos.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPixelPos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPixelPos.Location = new System.Drawing.Point(705, 0);
            this.lblPixelPos.Name = "lblPixelPos";
            this.lblPixelPos.Size = new System.Drawing.Size(197, 38);
            this.lblPixelPos.TabIndex = 9;
            this.lblPixelPos.Tag = "Use numpad or numbers or +/- to navigate through images.";
            this.lblPixelPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPixelPos.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.lblPixelPos.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.lblPixelPos.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // lblColor
            // 
            this.lblColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lblColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblColor.Location = new System.Drawing.Point(902, 0);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(38, 38);
            this.lblColor.TabIndex = 7;
            this.lblColor.Tag = "Use numpad or numbers or +/- to navigate through images.";
            this.lblColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.lblColor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.lblColor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // lblPixelValue
            // 
            this.lblPixelValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lblPixelValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblPixelValue.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblPixelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblPixelValue.Location = new System.Drawing.Point(940, 0);
            this.lblPixelValue.Name = "lblPixelValue";
            this.lblPixelValue.Size = new System.Drawing.Size(197, 38);
            this.lblPixelValue.TabIndex = 8;
            this.lblPixelValue.Tag = "Use numpad or numbers or +/- to navigate through images.";
            this.lblPixelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPixelValue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseDown);
            this.lblPixelValue.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.lblPixelValue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // lblZoom
            // 
            this.lblZoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lblZoom.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblZoom.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblZoom.Location = new System.Drawing.Point(1137, 0);
            this.lblZoom.Name = "lblZoom";
            this.lblZoom.Size = new System.Drawing.Size(69, 38);
            this.lblZoom.TabIndex = 6;
            this.lblZoom.Text = "100%";
            this.lblZoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblZoom.Click += new System.EventHandler(this.lblZoom_Click);
            this.lblZoom.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseMove);
            this.lblZoom.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Borderless_MouseUp);
            // 
            // btnRibbon
            // 
            this.btnRibbon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnRibbon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRibbon.FlatAppearance.BorderSize = 0;
            this.btnRibbon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnRibbon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRibbon.Image = ((System.Drawing.Image)(resources.GetObject("btnRibbon.Image")));
            this.btnRibbon.Location = new System.Drawing.Point(0, 0);
            this.btnRibbon.Name = "btnRibbon";
            this.btnRibbon.Size = new System.Drawing.Size(38, 38);
            this.btnRibbon.TabIndex = 5;
            this.btnRibbon.UseVisualStyleBackColor = false;
            this.btnRibbon.Click += new System.EventHandler(this.btnRibbon_Click);
            this.btnRibbon.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_Paint);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnZoomOut.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoomOut.FlatAppearance.BorderSize = 0;
            this.btnZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.Image")));
            this.btnZoomOut.Location = new System.Drawing.Point(1206, 0);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(38, 38);
            this.btnZoomOut.TabIndex = 4;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            this.btnZoomOut.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_Paint);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnZoomIn.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoomIn.FlatAppearance.BorderSize = 0;
            this.btnZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.Image")));
            this.btnZoomIn.Location = new System.Drawing.Point(1244, 0);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(38, 38);
            this.btnZoomIn.TabIndex = 3;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            this.btnZoomIn.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_Paint);
            // 
            // btnZoomToFit
            // 
            this.btnZoomToFit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnZoomToFit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoomToFit.FlatAppearance.BorderSize = 0;
            this.btnZoomToFit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnZoomToFit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomToFit.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomToFit.Image")));
            this.btnZoomToFit.Location = new System.Drawing.Point(1282, 0);
            this.btnZoomToFit.Name = "btnZoomToFit";
            this.btnZoomToFit.Size = new System.Drawing.Size(38, 38);
            this.btnZoomToFit.TabIndex = 2;
            this.btnZoomToFit.UseVisualStyleBackColor = false;
            this.btnZoomToFit.Click += new System.EventHandler(this.btnZoomToFit_Click);
            this.btnZoomToFit.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_Paint);
            // 
            // btnZoomToScale
            // 
            this.btnZoomToScale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnZoomToScale.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnZoomToScale.FlatAppearance.BorderSize = 0;
            this.btnZoomToScale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnZoomToScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomToScale.Image = ((System.Drawing.Image)(resources.GetObject("btnZoomToScale.Image")));
            this.btnZoomToScale.Location = new System.Drawing.Point(1320, 0);
            this.btnZoomToScale.Name = "btnZoomToScale";
            this.btnZoomToScale.Size = new System.Drawing.Size(38, 38);
            this.btnZoomToScale.TabIndex = 1;
            this.btnZoomToScale.UseVisualStyleBackColor = false;
            this.btnZoomToScale.Click += new System.EventHandler(this.btnZoomToScale_Click);
            this.btnZoomToScale.Paint += new System.Windows.Forms.PaintEventHandler(this.Ctrl_Paint);
            // 
            // btnFullScreen
            // 
            this.btnFullScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.btnFullScreen.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFullScreen.FlatAppearance.BorderSize = 0;
            this.btnFullScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.btnFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFullScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnFullScreen.Image")));
            this.btnFullScreen.Location = new System.Drawing.Point(1358, 0);
            this.btnFullScreen.Name = "btnFullScreen";
            this.btnFullScreen.Size = new System.Drawing.Size(38, 38);
            this.btnFullScreen.TabIndex = 0;
            this.btnFullScreen.UseVisualStyleBackColor = false;
            this.btnFullScreen.Click += new System.EventHandler(this.btnFullScreen_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(100, 75);
            this.imageList1.TransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            // 
            // listByrImgView
            // 
            this.listByrImgView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listByrImgView.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listByrImgView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.listByrImgView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listByrImgView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listByrImgView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listByrImgView.Font = new System.Drawing.Font("Trebuchet MS", 9F);
            this.listByrImgView.ForeColor = System.Drawing.Color.White;
            this.listByrImgView.FullRowSelect = true;
            this.listByrImgView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listByrImgView.HideSelection = false;
            this.listByrImgView.LargeImageList = this.imageList1;
            this.listByrImgView.Location = new System.Drawing.Point(0, 639);
            this.listByrImgView.Margin = new System.Windows.Forms.Padding(0);
            this.listByrImgView.Name = "listByrImgView";
            this.listByrImgView.RightToLeftLayout = true;
            this.listByrImgView.Size = new System.Drawing.Size(1052, 137);
            this.listByrImgView.TabIndex = 8;
            this.listByrImgView.TabStop = false;
            this.listByrImgView.UseCompatibleStateImageBehavior = false;
            this.listByrImgView.Visible = false;
            this.listByrImgView.SelectedIndexChanged += new System.EventHandler(this.listByrImgView_SelectedIndexChanged);
            this.listByrImgView.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 776);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1052, 1);
            this.progressBar1.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.ifz";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Images IFZ|*.ifz";
            this.openFileDialog1.Title = "Open IFZ";
            // 
            // pnlImageInfo
            // 
            this.pnlImageInfo.Controls.Add(this.lblCamera2);
            this.pnlImageInfo.Controls.Add(this.lblCamera);
            this.pnlImageInfo.Controls.Add(this.pictureBox5);
            this.pnlImageInfo.Controls.Add(this.linkLabel);
            this.pnlImageInfo.Controls.Add(this.lblSize2);
            this.pnlImageInfo.Controls.Add(this.lblFolder);
            this.pnlImageInfo.Controls.Add(this.pictureBox4);
            this.pnlImageInfo.Controls.Add(this.lblSizeInfo);
            this.pnlImageInfo.Controls.Add(this.pictureBox3);
            this.pnlImageInfo.Controls.Add(this.tbIFZName);
            this.pnlImageInfo.Controls.Add(this.pictureBox2);
            this.pnlImageInfo.Controls.Add(this.pnlImageInfo_ClosePanel);
            this.pnlImageInfo.Controls.Add(this.pnlImageInfo_Title);
            this.pnlImageInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlImageInfo.Location = new System.Drawing.Point(1052, 46);
            this.pnlImageInfo.Name = "pnlImageInfo";
            this.pnlImageInfo.Size = new System.Drawing.Size(344, 731);
            this.pnlImageInfo.TabIndex = 10;
            this.pnlImageInfo.Visible = false;
            // 
            // lblCamera2
            // 
            this.lblCamera2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblCamera2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCamera2.Location = new System.Drawing.Point(42, 258);
            this.lblCamera2.Name = "lblCamera2";
            this.lblCamera2.Size = new System.Drawing.Size(276, 45);
            this.lblCamera2.TabIndex = 45;
            // 
            // lblCamera
            // 
            this.lblCamera.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblCamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblCamera.Location = new System.Drawing.Point(42, 235);
            this.lblCamera.Name = "lblCamera";
            this.lblCamera.Size = new System.Drawing.Size(276, 23);
            this.lblCamera.TabIndex = 44;
            this.lblCamera.Text = "Camera";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(13, 235);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(23, 23);
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // linkLabel
            // 
            this.linkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.linkLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.linkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.linkLabel.Location = new System.Drawing.Point(42, 338);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(276, 142);
            this.linkLabel.TabIndex = 42;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "linkLabel1";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.linkLabel.MouseEnter += new System.EventHandler(this.linkLabel_MouseEnter);
            this.linkLabel.MouseLeave += new System.EventHandler(this.linkLabel_MouseLeave);
            // 
            // lblSize2
            // 
            this.lblSize2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.lblSize2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSize2.Location = new System.Drawing.Point(42, 189);
            this.lblSize2.Name = "lblSize2";
            this.lblSize2.Size = new System.Drawing.Size(276, 23);
            this.lblSize2.TabIndex = 40;
            // 
            // lblFolder
            // 
            this.lblFolder.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblFolder.Location = new System.Drawing.Point(42, 315);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(276, 23);
            this.lblFolder.TabIndex = 39;
            this.lblFolder.Text = "Chemin";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OMRON_IFZ_Viewer.Properties.Resources.Folder;
            this.pictureBox4.Location = new System.Drawing.Point(13, 315);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(23, 23);
            this.pictureBox4.TabIndex = 38;
            this.pictureBox4.TabStop = false;
            // 
            // lblSizeInfo
            // 
            this.lblSizeInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lblSizeInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSizeInfo.Location = new System.Drawing.Point(42, 166);
            this.lblSizeInfo.Name = "lblSizeInfo";
            this.lblSizeInfo.Size = new System.Drawing.Size(276, 23);
            this.lblSizeInfo.TabIndex = 37;
            this.lblSizeInfo.Text = "Taille";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 166);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 23);
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            // 
            // tbIFZName
            // 
            this.tbIFZName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.tbIFZName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbIFZName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbIFZName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tbIFZName.Location = new System.Drawing.Point(42, 105);
            this.tbIFZName.Name = "tbIFZName";
            this.tbIFZName.Size = new System.Drawing.Size(276, 18);
            this.tbIFZName.TabIndex = 35;
            this.tbIFZName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.tbIFZName.Leave += new System.EventHandler(this.tbIFZName_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 103);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 23);
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // pnlImageInfo_ClosePanel
            // 
            this.pnlImageInfo_ClosePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImageInfo_ClosePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnlImageInfo_ClosePanel.FlatAppearance.BorderSize = 0;
            this.pnlImageInfo_ClosePanel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(12)))), ((int)(((byte)(140)))));
            this.pnlImageInfo_ClosePanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pnlImageInfo_ClosePanel.Image = ((System.Drawing.Image)(resources.GetObject("pnlImageInfo_ClosePanel.Image")));
            this.pnlImageInfo_ClosePanel.Location = new System.Drawing.Point(286, 6);
            this.pnlImageInfo_ClosePanel.Name = "pnlImageInfo_ClosePanel";
            this.pnlImageInfo_ClosePanel.Size = new System.Drawing.Size(46, 46);
            this.pnlImageInfo_ClosePanel.TabIndex = 33;
            this.pnlImageInfo_ClosePanel.UseVisualStyleBackColor = false;
            this.pnlImageInfo_ClosePanel.Click += new System.EventHandler(this.btnClosePanel_Click);
            // 
            // pnlImageInfo_Title
            // 
            this.pnlImageInfo_Title.AutoSize = true;
            this.pnlImageInfo_Title.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.pnlImageInfo_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.pnlImageInfo_Title.Location = new System.Drawing.Point(8, 18);
            this.pnlImageInfo_Title.Name = "pnlImageInfo_Title";
            this.pnlImageInfo_Title.Size = new System.Drawing.Size(129, 28);
            this.pnlImageInfo_Title.TabIndex = 0;
            this.pnlImageInfo_Title.Text = "Informations";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 730);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            this.pictureBox1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseWheel);
            this.pictureBox1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.pictureBox1_PreviewKeyDown);
            // 
            // Form_DisplayImage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(1396, 815);
            this.Controls.Add(this.listByrImgView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pnlImageInfo);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "Form_DisplayImage";
            this.Text = "OMRON - IFZ Viewer";
            this.Load += new System.EventHandler(this.Form_DisplayImage_Load);
            this.SizeChanged += new System.EventHandler(this.Form_DisplayImage_SizeChanged);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form_DisplayImage_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form_DisplayImage_DragEnter);
            this.Resize += new System.EventHandler(this.Form_DisplayImage_Resize);
            this.pnlHeader.ResumeLayout(false);
            this.pnlImageMgmt.ResumeLayout(false);
            this.pnlControlBox.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.pnlImageInfo.ResumeLayout(false);
            this.pnlImageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button btnFullScreen;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnZoomToScale;
        private System.Windows.Forms.Button btnZoomToFit;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRibbon;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlControlBox;
        private System.Windows.Forms.Label lblZoom;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.Panel pnlImageMgmt;
        private Button btnPrint;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ImageList imageList1;
        private Label lblPixelPos;
        private Label lblPixelValue;
        private Label lblColor;
        private ProgressBar progressBar1;
        private ListView listByrImgView;
        private Button btnFolder;
        private OpenFileDialog openFileDialog1;
        private Button btnSettings;
        private Button btnRotate;
        private Button btnFlipLR;
        private Button btnFlipUD;
        private ToolTip toolTip1;
        public Label lblName;

        private CheckBox cb1;
        private CheckBox cb2;
        private CheckBox cb3;
        private CheckBox cb4;
        private CheckBox cb5;
        private CheckBox cb6;
        private CheckBox cb7;
        private CheckBox cb8;
        public Label lblFileNb;
        public Button btnTrash;
        private Panel pnlImageInfo;
        private Label pnlImageInfo_Title;
        private Button btnInfo;
        private Button pnlImageInfo_ClosePanel;
        private PictureBox pictureBox2;
        private TextBox tbIFZName;
        private PictureBox pictureBox3;
        private Label lblSizeInfo;
        private Label lblFolder;
        private PictureBox pictureBox4;
        private Label lblSize2;
        private LinkLabel linkLabel;
        private Label lblCamera2;
        private Label lblCamera;
        private PictureBox pictureBox5;
    }
}