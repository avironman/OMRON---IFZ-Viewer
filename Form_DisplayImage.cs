using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Globalization;
using System.Threading;
using System.Drawing.Printing;
using System.Web;
using System.Windows.Controls;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
// YURY


namespace OMRON_IFZ_Viewer
{

    public partial class Form_DisplayImage : Form
    {
        public string dispImageDir;
        private string FileName;
        private int nbIFZ;
        int currentFile;
        private int[] MonoCol;

        private bool isMouseOverRight;
        private bool isMouseLeavingRight;
        private bool isNextVisible;

        private bool isMouseOverLeft;
        private bool isMouseLeavingLeft;
        private bool isPreviousVisible;

        private bool thumbnailsCreated;

        //on charge les cursors
        private Cursor CursorHand = new Cursor(new MemoryStream(Properties.Resources.Hand));
        private Cursor CursorGrab = new Cursor(new MemoryStream(Properties.Resources.Grab));

        private string saveFormat;

        FiltLibIF.BayerMaster bayerMaster = new FiltLibIF.BayerMaster();

        //Cursor position when using mousewheel zoom
        //private int x;
        //private int y;

        // Factor for zoom the image
        private float zoomFac = 1;
        private float zoomFit;

        //set Zoom allowed
        private bool zoomSet = false;
        //to center image at load
        private bool centering = true;

        //value for moving the image in X direction
        private float translateX = 0;
        //value for moving the image in Y direction
        private float translateY = 0;

        //Flag to set the moving operation set
        private bool translateSet = false;
        //Flag to set mouse down on the image
        private bool translate = false;

        //set on the mouse down to know from where moving starts
        private float transStartX;
        private float transStartY;

        //Current Image position after moving 
        private float curImageX = 0;
        private float curImageY = 0;

        //Current image is grey scale
        private bool IsGreyScale;

        string name;

        public ZoomMode zoomMode = ZoomMode.Fit;
        public new string Name
        { get { return name; } set { name = value; } }

        Bitmap[] bitmap;

        public Bitmap[] Bitmap
        { get { return bitmap; } set { bitmap = value; } }

        public System.Windows.Forms.CheckBox[] Chkbxes = new System.Windows.Forms.CheckBox[8];

        int camnb;

        int currentImage;

        public int CurrentImage
        { get { return currentImage; } set { currentImage = value; } }

        //temporary storage in bitmap
        System.Drawing.Image bmp;// field

        public System.Drawing.Image BMP //property
        {
            get { return bmp; }   // get method
            set { bmp = value; }  // set method
        }

        private const float EPS = 0.00001f;
        public Form_DisplayImage()
        {
            InitializeComponent();
            this.CenterToScreen();

            Properties.Settings.Default.ThemeColor = System.Drawing.Color.FromArgb(31, 31, 31);

            thumbnailsCreated = false;

            zoomMode = (ZoomMode)Properties.Settings.Default.ZoomMode;

            Chkbxes = new[] { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8 };

            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts
                                                             // Properties.Settings.Default.LastDir = @"D:\TFS\a detruire\DDJ";   
            string dispImageDir = Properties.Settings.Default.LastDir;

            FileName = "";
            if (!Directory.Exists(dispImageDir) || Directory.GetFiles(dispImageDir, "*.ifz").Length == 0)
            {
                Form_EmpryFolder form_EmpryFolder = new Form_EmpryFolder();
                form_EmpryFolder.StartPosition = FormStartPosition.CenterScreen;
                DialogResult res = form_EmpryFolder.ShowDialog();
                if (res == DialogResult.OK)
                {
                    FileName = form_EmpryFolder.ReturnValue;
                    dispImageDir = System.IO.Path.GetDirectoryName(FileName);
                }
                else
                {
                    //Si l'utilisateur ferme la boite de dialogue, on quitte proprement
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        // WinForms app
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        // Console app
                        System.Environment.Exit(1);
                    }
                }
                currentFile = Array.IndexOf(Directory.GetFiles(dispImageDir, "*.ifz"), FileName);
            }
            else
            {
                FileName = Directory.GetFiles(dispImageDir, "*.ifz")[0];
                currentFile = 0;
            }


            nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;

            LoadImage(FileName);
            ManageButtons();
            // LoadIfzThumbnail();
        }
        public Form_DisplayImage(string IFZFileName) : base()
        {
            FileName = IFZFileName;
            InitializeComponent();

            zoomMode = (ZoomMode)Properties.Settings.Default.ZoomMode;

            Chkbxes = new[] { cb1, cb2, cb3, cb4, cb5, cb6, cb7, cb8 };

            this.SetStyle(ControlStyles.ResizeRedraw, true); // this is to avoid visual artifacts

            dispImageDir = System.IO.Path.GetDirectoryName(FileName);
            currentFile = Array.IndexOf(Directory.GetFiles(dispImageDir, "*.ifz"), FileName);
            nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;


            LoadImage(FileName);
            ManageButtons();
            // LoadIfzThumbnail();

        }

        private void LoadIfzThumbnail()
        {
            if (!backgroundWorker1.IsBusy)
            {
                listByrImgView.Items.Clear();
                imageList1.Images.Clear();
                progressBar1.Value = 0;
                listByrImgView.BeginUpdate();

                backgroundWorker1.RunWorkerAsync();
            }
        }
        public void ShowIt()
        {
            if (this.InvokeRequired)
                //this.Invoke(ShowIt); //
                this.Invoke(new MethodInvoker(ShowIt));
            else
                this.BringToFront();
        }
        public void LoadImage(string File_Name) //fonction apellée depuis Program.cs lors d'un double clic sur l'icone de l'IFZ
        {
            FileName = File_Name;
            isMouseOverRight = false;
            dispImageDir = System.IO.Path.GetDirectoryName(FileName);
            if (Properties.Settings.Default.LastDir != dispImageDir)
            {
                KillBGW();



                //System.Threading.Thread.Sleep(1000);
                Properties.Settings.Default.LastDir = dispImageDir;
                nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;
                ManageButtons();
                // LoadIfzThumbnail();
            }

            GC.Collect();


            lblName.Text = System.IO.Path.GetFileName(FileName);
            lblFileNb.Text = (currentFile + 1) + "/" + nbIFZ;
            lblName.Refresh();
            lblFileNb.Refresh();

            int i;
            try
            {
                FiltLibIF.MakeByrData(FileName, ref bayerMaster);
                camnb = bayerMaster.camno;
                //bayerMaster.

                if (currentImage >= camnb)
                    currentImage = 0;

                bitmap = new Bitmap[bayerMaster.camno];
                MonoCol = new int[bayerMaster.camno];
                for (i = 0; i < bayerMaster.camno; i++)
                {
                    FiltLibIF.ByrtoBmp(bayerMaster, out bitmap[i], i);
                    MonoCol[i] = bayerMaster.ByrArray[i].format;
                }
                bmp = bitmap[currentImage];
                IsGreyScale = (MonoCol[currentImage] == 10);


                //if (bmp.Width < pictureBox1.Width && bmp.Height < pictureBox1.Height)
                //    zoomFit = 1f;
                //else
                //{
                if ((float)bmp.Width / (float)bmp.Height < (float)pictureBox1.Width / (float)pictureBox1.Height)
                    zoomFit = (float)pictureBox1.Height / (float)bmp.Height;
                else
                    zoomFit = (float)pictureBox1.Width / (float)bmp.Width;
                //}






                ZoomManagment();
                PositionImage();

                pictureBox1.Refresh();
                pictureBox1.Focus();

                //set present position of the image after move.
                curImageX = translateX;
                curImageY = translateY;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid IFZ file; " + ex.Message);
            }
            GC.Collect();
            ManageButtons();
            PopulatePnlImageInfo();
        }

        public void DispImage(int num)
        {
            if (num >= camnb) { return; }
            currentImage = num;

            bmp = bitmap[currentImage];
            IsGreyScale = (MonoCol[currentImage] == 10);

            PositionImage();

            pictureBox1.Refresh();
            pictureBox1.Focus();

            ManageButtons();

            if ((float)bmp.Width / (float)bmp.Height > (float)pictureBox1.Width / (float)pictureBox1.Height)
                zoomFit = (float)pictureBox1.Height / (float)bmp.Height;
            else
                zoomFit = (float)pictureBox1.Width / (float)bmp.Width;

            PopulatePnlImageInfo();
        }

        public void ManageButtons()
        {

            for (int i = 0; i < 8; i++)
            {
                Chkbxes[i].CheckedChanged -= new System.EventHandler(this.cb_CheckedChanged);
                Chkbxes[i].Visible = (i < camnb);
                Chkbxes[i].Checked = (i == currentImage);
                Chkbxes[i].CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);
            }
            cb1.Visible = (camnb > 1);
        }

        #region // Déplacement de la fenêtre

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        #region // Form events
        private void Form_DisplayImage_Load(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;

            //btnRibbon.Enabled = false;

            this.Shown += new EventHandler(Form_DisplayImage_Shown);
            this.Disposed += new EventHandler(Form_DisplayImage__Disposed);

            // Create the ToolTip and set initial values.
            this.toolTip1 = new System.Windows.Forms.ToolTip();
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.OwnerDraw = true;
            this.toolTip1.ReshowDelay = 10;
            this.toolTip1.Draw += new DrawToolTipEventHandler(this.toolTip1_Draw);
            this.toolTip1.Popup += new PopupEventHandler(toolTip1_Popup);


            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.LangueSoft);

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(btnFullScreen, Properties.strings.tooltip_001);
            toolTip1.SetToolTip(btnZoomToScale, Properties.strings.tooltip_002);
            toolTip1.SetToolTip(btnZoomToFit, Properties.strings.tooltip_003);
            toolTip1.SetToolTip(btnRotate, Properties.strings.tooltip_004);
            toolTip1.SetToolTip(btnTrash, Properties.strings.tooltip_005);
            toolTip1.SetToolTip(btnPrint, Properties.strings.tooltip_006);
            toolTip1.SetToolTip(btnSettings, Properties.strings.tooltip_007);
            toolTip1.SetToolTip(btnFlipLR, Properties.strings.tooltip_008);
            toolTip1.SetToolTip(btnFlipUD, Properties.strings.tooltip_009);
            toolTip1.SetToolTip(btnZoomIn, Properties.strings.tooltip_010);
            toolTip1.SetToolTip(btnZoomOut, Properties.strings.tooltip_011);
            toolTip1.SetToolTip(btnRibbon, Properties.strings.tooltip_012);



            if (!Directory.Exists(dispImageDir) || Directory.GetFiles(dispImageDir, "*.ifz").Length == 0)
            {
                Form_EmpryFolder form_EmpryFolder = new Form_EmpryFolder();
                form_EmpryFolder.InitValue = dispImageDir;
                form_EmpryFolder.StartPosition = FormStartPosition.CenterScreen;

                if (form_EmpryFolder.ShowDialog() == DialogResult.OK)
                {
                    //Kill BackgroundWorker to avoid problems
                    KillBGW();

                    string fName = form_EmpryFolder.ReturnValue; //on récupère la première image du répertoire
                    dispImageDir = System.IO.Path.GetDirectoryName(fName);
                    nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;
                    currentFile = Array.IndexOf(Directory.GetFiles(dispImageDir, "*.ifz"), fName);

                    LoadImage(fName);
                    ManageButtons();
                    //LoadIfzThumbnail();
                    Properties.Settings.Default.LastDir = dispImageDir;
                    zoomMode = ZoomMode.Scale;
                }
                else
                {
                    //Si l'utilisateur ferme la boite de dialogue, on quitte proprement
                    if (System.Windows.Forms.Application.MessageLoop)
                    {
                        // WinForms app
                        System.Windows.Forms.Application.Exit();
                    }
                    else
                    {
                        // Console app
                        System.Environment.Exit(1);
                    }
                }

            }

        }
        protected void Form_DisplayImage_Shown(object sender, EventArgs e)
        {
            //Draw the image initially
            translateSet = true;
            pictureBox1.Refresh();
        }
        protected void Form_DisplayImage__Disposed(object sender, EventArgs e)
        {
            //Dispose the bmp when form is disposed.
            if (bmp != null)
            {
                bmp.Dispose();
            }
        }
        private void Form_DisplayImage_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                btnMaximize.Visible = false;
                btnReduce.Visible = true;
            }
            else
            {
                btnMaximize.Visible = true;
                btnReduce.Visible = false;
            }
            ZoomManagment();
            pictureBox1.Refresh();
        }
        private void Form_DisplayImage_SizeChanged(object sender, EventArgs e)
        {
            if (bmp == null) { return; }
            //on recalcule le Zoom mini lors du redimensionnement fenetre.
            if ((float)bmp.Width / (float)bmp.Height > (float)pictureBox1.Width / (float)pictureBox1.Height)
                zoomFit = (float)pictureBox1.Width / (float)bmp.Width;
            else
                zoomFit = (float)pictureBox1.Height / (float)bmp.Height;

            ZoomManagment();
            PositionImage();
            pictureBox1.Refresh();
        }
        #endregion

        #region // PictureBox events
        protected void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Conditions to avoid to proceed further.
            if (bmp == null) { 
                return; 
            }
            if (translateSet == false && zoomSet == false) { return; }

            Graphics g = e.Graphics;
            //g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            //Scale transform operation on the picture box device context
            //zoomFac is global variable which can be used to get desired zoom
            if (Math.Abs(zoomFac) > EPS)
                g.ScaleTransform(zoomFac, zoomFac);

            //move image to new position
            if (translateSet == true)
            {
                g.TranslateTransform(translateX, translateY);
            }

            //Drawback the bitmap to the transformed decive context

            //Apply double buffering (Draw to a bitmap first and then draw to picturebox) if
            // using large image and experience flickering

            try
            {
                g.DrawImage(bmp, 0, 0);

                //gestion de l'affichage des boutons Next et Previous
                if (isMouseOverRight && !isNextVisible)
                {
                    isNextVisible = true;

                    Bitmap imagette = new Bitmap(
                        Properties.Resources.Next, 
                        new Size(
                            (int)Math.Round(Properties.Resources.Next.Width / zoomFac), 
                            (int)Math.Round(Properties.Resources.Next.Height / zoomFac)
                            )
                        );

                    g.DrawImage(
                        imagette,
                        new PointF(
                            (pictureBox1.Width - 50) / zoomFac - curImageX,
                            (pictureBox1.Height - Properties.Resources.Next.Height) / 2.0f / zoomFac - curImageY)
                        );

                }
                else if (!isMouseOverRight && isNextVisible)
                {
                    isNextVisible = false;

                }
                if (isMouseOverLeft && !isPreviousVisible)
                {
                    isPreviousVisible = true;

                    Bitmap imagette = new Bitmap(
                        Properties.Resources.Previous,
                        new Size(
                            (int)Math.Round(Properties.Resources.Previous.Width / zoomFac),
                            (int)Math.Round(Properties.Resources.Previous.Height / zoomFac)
                            )
                        );

                    g.DrawImage(
                        imagette,
                        new PointF((80 - Properties.Resources.Previous.Width) / zoomFac - curImageX,
                        (pictureBox1.Height - Properties.Resources.Next.Height) / 2.0f / zoomFac - curImageY)
                        );

                }
                else if (!isMouseOverLeft && isPreviousVisible)
                {
                    isPreviousVisible = false;

                }


            }
            catch (Exception f)
            {
                Console.WriteLine(f.ToString());
                zoomFac = 1f;
                translateX = 0;
                translateY = 0;

                pictureBox1.Refresh();
            }

            lblZoom.Text = string.Format("{0:P0}", zoomFac);
            btnZoomToScale.Enabled = (Math.Round(zoomFac, 3) != 1f);
        }
        private void pictureBox1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //Si CTRL est enfoncée, on déplace le curseur
            if (e.KeyCode == Keys.Escape)
            {
                this.WindowState = FormWindowState.Normal;
                pnlHeader.Visible = true;
                pnlFooter.Visible = true;
                ZoomManagment();
            }
            if (e.Control)
            {
                //zoomFit = false;
                switch (e.KeyCode)
                {
                    case Keys.R:
                        btnRotate.PerformClick();
                        break;
                    case Keys.D1:
                    case Keys.NumPad1:
                        zoomMode = ZoomMode.Scale;
                        ZoomManagment();
                        break;
                    case Keys.D0:
                    case Keys.NumPad0:
                        zoomMode = ZoomMode.Fit;
                        ZoomManagment();
                        break;
                    case Keys.Add:
                        zoomMode = ZoomMode.In;
                        ZoomManagment();
                        break;
                    case Keys.Subtract:
                        zoomMode = ZoomMode.Out;
                        ZoomManagment();
                        PositionImage();
                        break;
                    case Keys.Down:
                        Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y + 1);
                        e.IsInputKey = true;
                        break;
                    case Keys.Right:
                        Cursor.Position = new System.Drawing.Point(Cursor.Position.X + 1, Cursor.Position.Y);
                        e.IsInputKey = true;
                        break;
                    case Keys.Up:
                        Cursor.Position = new System.Drawing.Point(Cursor.Position.X, Cursor.Position.Y - 1);
                        e.IsInputKey = true;
                        break;
                    case Keys.Left:
                        Cursor.Position = new System.Drawing.Point(Cursor.Position.X - 1, Cursor.Position.Y);
                        e.IsInputKey = true;
                        break;
                    default:
                        break;
                }
                pictureBox1.Refresh();
                curImageX = translateX; curImageY = translateY;

            }
            //Sinon, on déplace le curseur
            else
            {
                // dispImageDir = System.IO.Path.GetDirectoryName(FileName)[currentFile];
                nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;


                switch (e.KeyCode)
                {
                    case Keys.F:
                        btnRibbon.PerformClick();
                        break;
                    case Keys.F11:
                        if (WindowState == FormWindowState.Maximized)
                        {
                            this.WindowState = FormWindowState.Normal;
                            pnlHeader.Visible = true;
                            pnlFooter.Visible = true;
                        }
                        else
                            btnFullScreen.PerformClick();
                        break;
                    case Keys.Down:
                        listByrImgView.Visible = false;
                        Activate();
                        pictureBox1.Focus();
                        break;
                    case Keys.Delete:
                        btnTrash.PerformClick();
                        break;
                    case Keys.Right:
                    case Keys.PageDown:
                        if (currentFile < nbIFZ - 1)
                            currentFile += 1;
                        else
                            currentFile = 0;
                        LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);

                        break;
                    case Keys.Left:
                    case Keys.PageUp:
                        if (currentFile == 0)
                            currentFile = nbIFZ - 1;
                        else
                            currentFile -= 1;
                        LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);
                        break;
                    case Keys.Add:
                        if (currentImage < camnb - 1)
                        {
                            currentImage += 1;
                            DispImage(currentImage);
                        }
                        break;
                    case Keys.Subtract:
                        if (currentImage > 0)
                        {
                            currentImage -= 1;
                            DispImage(currentImage);
                        }
                        break;

                    case Keys.D1:
                    case Keys.NumPad1:
                        if (currentImage == 0) { break; }
                        currentImage = 0;
                        DispImage(currentImage);
                        break;
                    case Keys.D2:
                    case Keys.NumPad2:
                        if (currentImage == 1 | camnb < 2) { break; }
                        currentImage = 1;
                        DispImage(currentImage);
                        break;
                    case Keys.D3:
                    case Keys.NumPad3:
                        if (currentImage == 2 | camnb < 3) { break; }
                        currentImage = 2;
                        DispImage(currentImage);
                        break;
                    case Keys.D4:
                    case Keys.NumPad4:
                        if (currentImage == 3 | camnb < 4) { break; }
                        currentImage = 3;
                        DispImage(currentImage);
                        break;
                    case Keys.D5:
                    case Keys.NumPad5:
                        if (currentImage == 4 | camnb < 5) { break; }
                        currentImage = 4;
                        DispImage(currentImage);
                        break;
                    case Keys.D6:
                    case Keys.NumPad6:
                        if (currentImage == 5 | camnb < 6) { break; }
                        currentImage = 5;
                        DispImage(currentImage);
                        break;
                    case Keys.D7:
                    case Keys.NumPad7:
                        if (currentImage == 6 | camnb < 7) { break; }
                        currentImage = 6;
                        DispImage(currentImage);
                        break;
                    case Keys.D8:
                    case Keys.NumPad8:
                        if (currentImage == 7 | camnb < 8) { break; }
                        currentImage = 7;
                        DispImage(currentImage);
                        break;
                    default:
                        break;
                }

            }

        }
        protected void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left && zoomMode != ZoomMode.Fit && zoomFac > zoomFit)
            {
                //translateSet = true;
                //mouse down is true
                translate = true;
                //starting coordinates for move
                transStartX = e.X;
                transStartY = e.Y;

                if (!isNextVisible && !isPreviousVisible)
                    Cursor = CursorGrab;

            }
            pictureBox1.Focus();
        }
        protected void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //If mouse down is true
            if (translate == true)
            {
                Cursor = CursorHand;
                TranslateManagment(e);
                ////calculate the total distance to move from 0,0
                ////previous image position+ current moving distance
                //translateX = curImageX + ((e.X - transStartX) / zoomFac);
                //translateY = curImageY + ((e.Y - transStartY) / zoomFac);
                ////call picturebox to update the image in the new position
            }

            pictureBox1.Refresh();
            //set mouse down operation end
            translate = false;
            //set present position of the image after move.
            curImageX = translateX;
            curImageY = translateY;


            if (e.Button == MouseButtons.Right)
            {
                var menu = new CustomMenu();
                menu.Owner = this;
                menu.Location = PointToScreen(e.Location);
                //menu.Show(this);
                var result = menu.ShowDialog(this);
                if (result == DialogResult.OK)
                {
                    this.BringToFront();
                    switch (menu.ReturnValue)
                    {
                        case "Copy":
                            Clipboard.SetImage(bmp);
                            break;
                        case "SaveAs":
                            SaveFileDialog saveFileDialog1 = new SaveFileDialog
                            {
                                InitialDirectory = dispImageDir,// Properties.Settings.Default.defaultSavingPath,
                                Title = "Save an Image File",
                                FileName = System.IO.Path.GetFileNameWithoutExtension(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]),
                                DefaultExt = "bmp",
                                Filter = "Bitmap Image|*.bmp|Jpeg Image|*.jpg|Png Image|*.png|Tiff Image|*.tif|Gif Image|*.gif", //|IFZ Image|*.ifz|StRAW Image|*.straw|WEBP|*.webp
                            };

                            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                if (saveFileDialog1.FileName != "")
                                {
                                    ImageFormat fmt = ImageFormat.Bmp;
                                    switch (saveFileDialog1.FilterIndex)
                                    {
                                        case 1: //BMP
                                            fmt = ImageFormat.Bmp;
                                            break;
                                        case 2: //JPEG
                                            fmt = ImageFormat.Jpeg;
                                            break;
                                        case 3: //PNG
                                            fmt = ImageFormat.Png;
                                            break;
                                        case 4: //TIF
                                            fmt = ImageFormat.Tiff;
                                            break;
                                        case 5: //GIF
                                            fmt = ImageFormat.Gif;
                                            break;
                                            //case 6: //IFZ

                                            //    break;
                                            //case 7: //StRAW
                                            //    fmt = ImageFormat.Jpeg;
                                            //    break;
                                    }
                                    FiltLibIF.savepicture((Bitmap)bmp, saveFileDialog1.FileName, fmt, 100);
                                }
                            }
                            break;
                        case "Print":
                            using (Bitmap bmp2 = new Bitmap(bmp))
                            {
                                using (Bitmap newImage = new Bitmap(bmp2))
                                {
                                    newImage.Save(@"D:\temp.jpg", ImageFormat.Jpeg);
                                }
                            }
                            this.WindowState = FormWindowState.Minimized;
                            //pictureBox1.Image.Save(@"C:\temp.bmp");
                            var p = new Process();
                            p.StartInfo.FileName = @"D:\temp.jpg";
                            p.StartInfo.Verb = "Print";
                            p.Start();
                            break;
                        case "Delete":
                            //btnTrash.PerformClick();
                            DeleteFile();
                            break;
                        case "Convert":
                            Form_Convert frmcvrt = new Form_Convert(dispImageDir);
                            //frmcvrt.StartPosition = FormStartPosition.Manual;
                            frmcvrt.ShowDialog();

                            break;
                        default: break;
                    }
                }
                else
                    this.BringToFront();
            }

        }
        PointF stretched(System.Drawing.Point p0)
        {
            if (bmp == null) return PointF.Empty;
            float posx = p0.X / zoomFac - curImageX;
            float posy = p0.Y / zoomFac - curImageY;

            if (posx >= 0 & posy >= 0 & posx < bmp.Width & posy < bmp.Height)
                return new PointF(posx, posy);
            else
                return new PointF(-1f, -1f);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            int rightThreshold = pictureBox1.Width - 100; // Adjust the threshold as per your requirement

            isMouseOverRight = (e.X >= rightThreshold && !isNextVisible && e.Button != MouseButtons.Left && currentFile < nbIFZ);
            isMouseLeavingRight = (e.X < rightThreshold && isNextVisible);

            isMouseOverLeft = (e.X <= 100 && !isPreviousVisible && e.Button != MouseButtons.Left && currentFile > 0);
            isMouseLeavingLeft = (e.X > 100 && isPreviousVisible);

            if (isMouseOverRight || isMouseLeavingRight || isMouseOverLeft || isMouseLeavingLeft)
            {
                pictureBox1.Refresh();
            }

            if (zoomFac > zoomFit)
            {
                //Cursor = CursorHand;
                if (isNextVisible || isPreviousVisible)
                    Cursor = Cursors.Default;
                else
                    Cursor = CursorHand;
            }
            else
                Cursor = Cursors.Default;

            //If mouse down is true
            if (translate == true)
            {
                Cursor = CursorGrab;
                TranslateManagment(e);

                //call picturebox to update the image in the new position
                pictureBox1.Refresh();

                zoomMode = ZoomMode.None;
                ZoomManagment();
                //PositionImage();
            }
            else
            {
                System.Drawing.Point mDown = System.Drawing.Point.Round(stretched(e.Location));
                if (mDown.X >= 0 && mDown.X < bmp.Width && mDown.Y >= 0 && mDown.Y < bmp.Height)
                {
                    Color c = ((Bitmap)bmp).GetPixel(mDown.X, mDown.Y);
                    lblColor.BackColor = c;

                    lblPixelPos.Text = "X: " + mDown.X.ToString() + " Y: " + mDown.Y.ToString();
                    if (IsGreyScale)
                        lblPixelValue.Text = Properties.strings.lblMono + c.R.ToString();
                    else
                    {
                        var Red = c.R;
                        var Green = c.G;
                        var Blue = c.B;

                        lblPixelValue.Text = Properties.strings.lblColor + $"({Red}, {Green},{Blue})";
                    }
                }
                else
                {
                    lblColor.BackColor = Color.FromArgb(39, 39, 39);
                    lblPixelPos.Text = "";
                    lblPixelValue.Text = "";
                }
            }
        }
        private void pictureBox1_MouseWheel(object sender, MouseEventArgs e)
        {
            //btnZoomToFit.Enabled = true;
            //btnZoomToScale.Enabled = true;

            // Calculate the zooming point
            PointF zoomPoint = new PointF(e.X / zoomFac - translateX, e.Y / zoomFac - translateY);

            translateSet = true;
            zoomSet = zoomFac < 20f && zoomFac > 0.1f;
            //zoomFit = false;

            // Adjust the zoom factor
            if (e.Delta > 0)
                zoomMode = ZoomMode.In;
            else if (e.Delta < 0)
                zoomMode = ZoomMode.Out;

            ZoomManagment();

            //Calcul du point de zoom
            if ((float)bmp.Width * zoomFac < (float)pictureBox1.Width)
            {
                translateX = ((float)pictureBox1.Width - (float)bmp.Width * zoomFac) / 2.0f / zoomFac;
            }
            else
            {
                // Update translation to keep the zooming point under the mouse cursor
                translateX = e.X / zoomFac - zoomPoint.X;
            }
            if ((float)bmp.Height * zoomFac < (float)pictureBox1.Height)
            {
                translateY = ((float)pictureBox1.Height - (float)bmp.Height * zoomFac) / 2.0f / zoomFac;
            }
            else
            {
                // Update translation to keep the zooming point under the mouse cursor
                translateY = e.Y / zoomFac - zoomPoint.Y;
            }
            PositionImage();

            pictureBox1.Refresh();

            lblZoom.Text = string.Format("{0:P0}", zoomFac);

            curImageX = translateX;
            curImageY = translateY;
        }
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (zoomFac > zoomFit)
                Cursor = CursorHand;
            else
                Cursor = Cursors.Default;

            Activate();
            pictureBox1.Focus();
        }
        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            lblColor.BackColor = Color.FromArgb(39, 39, 39);
            lblPixelPos.Text = "";
            lblPixelValue.Text = "";
            isMouseOverRight = false;
            //pictureBox1.Refresh();
            Cursor.Current = Cursors.Default;
            Cursor = Cursors.Default;
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isNextVisible)
            {

                int nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;
                if (currentFile < nbIFZ - 1)
                    currentFile += 1;
                else
                    currentFile = 0;
                ManageButtons();
                LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);
                pictureBox1.Focus();
            }
            if (isPreviousVisible)
            {
                int nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;
                if (currentFile == 0)
                    currentFile = nbIFZ - 1;
                else
                    currentFile -= 1;
                ManageButtons();
                LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);
                pictureBox1.Focus();
            }
        }
        #endregion

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            pnlHeader.Visible = false;
            pnlFooter.Visible = false;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;
            pictureBox1.Focus();//important de donner le Focus, cela permet de capturer la touche echap pour quitter le plein ecran.
            ZoomManagment();
        }

        #region //Button events
        private void Ctrl_Paint(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Control b = (System.Windows.Forms.Control)sender;
            //Paint a semi-transparent black rectangle over the button if disabled
            if (!b.Enabled)
            {
                using (SolidBrush brdim = new SolidBrush(Color.FromArgb(128, 0, 0, 0)))
                {
                    e.Graphics.FillRectangle(brdim, e.ClipRectangle);

                }
            }
        }

        private void lblZoom_Click(object sender, EventArgs e)
        {
            Form_Zoom frmz = new Form_Zoom(lblZoom.Text);
            frmz.StartPosition = FormStartPosition.Manual;
            frmz.Location = lblZoom.PointToScreen(new Point(0, 0));
            var result = frmz.ShowDialog();
            if (result == DialogResult.OK)
            {
                zoomMode = ZoomMode.Free;
                ZoomManagment(frmz.ReturnZoom);
                PositionImage();
                // CenterImage();
                pictureBox1.Refresh();
            }
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            pnlHeader.Visible = false;
            pnlFooter.Visible = false;
            this.TopMost = true;
            this.WindowState = FormWindowState.Maximized;

            ZoomManagment();
            pictureBox1.Focus();//important de donner le Focus, cela permet de capturer la touche echap pour quitter le plein ecran.
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //on ferme le backgroundworker s'il est toujours ouvert.
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                while (backgroundWorker1.IsBusy)
                {
                    Application.DoEvents();
                }
            }
            Properties.Settings.Default.Save();

            bayerMaster.ByrArray = null;
            Close();


        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Red;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(31, 31, 31);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            pictureBox1.Focus();
        }

        private void btnTrash_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        private void DeleteFile()
        {
            Form_Confirm fConf = new Form_Confirm();
            fConf.StartPosition = FormStartPosition.CenterParent;
            DialogResult = fConf.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                string FileName = dispImageDir + @"\" + lblName.Text;
                File.Delete(FileName);
                if (Directory.GetFiles(dispImageDir, "*.ifz").Length >= 1)
                {
                    if (currentFile != 0)
                        currentFile -= 1;

                    LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);


                    lblName.Text = System.IO.Path.GetFileName(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);
                    lblFileNb.Text = (currentFile + 1).ToString() + "/" + Directory.GetFiles(dispImageDir, "*.ifz").Length.ToString();
                }
                else
                {
                    Form_EmpryFolder form_EmpryFolder = new Form_EmpryFolder();
                    form_EmpryFolder.StartPosition = FormStartPosition.CenterParent;
                    DialogResult = form_EmpryFolder.ShowDialog();
                    if (DialogResult == DialogResult.OK)
                        btnFolder.PerformClick();
                    else
                        btnClose.PerformClick();

                }
            }
            pictureBox1.Focus();
        }
        private void btnZoomToScale_Click(object sender, EventArgs e)
        {
            zoomMode = ZoomMode.Scale;
            ZoomManagment();

            pictureBox1.Refresh();
            pictureBox1.Focus();

        }

        private void btnZoomToFit_Click(object sender, EventArgs e)
        {
            zoomMode = ZoomMode.Fit;
            ZoomManagment();
            PositionImage();
            pictureBox1.Refresh();
            pictureBox1.Focus();
        }

        private void btnZoomIn_Click(object sender, EventArgs e)
        {
            zoomMode = ZoomMode.In;
            ZoomManagment();

            pictureBox1.Refresh();
            pictureBox1.Focus();
        }

        private void btnZoomOut_Click(object sender, EventArgs e)
        {
            zoomMode = ZoomMode.Out;
            ZoomManagment();
            PositionImage();
            pictureBox1.Refresh();
            pictureBox1.Focus();
        }

        private void btnRibbon_Click(object sender, EventArgs e)
        {
            if (!thumbnailsCreated)
            {
                LoadIfzThumbnail();

                thumbnailsCreated = true;
            }
            var tewt2 = imageList1.Images;
            var test = listByrImgView.LargeImageList;
            listByrImgView.Visible = !listByrImgView.Visible;
            if (listByrImgView.Visible)
                pictureBox1.PreviewKeyDown -= pictureBox1_PreviewKeyDown;
            else
            {
                pictureBox1.PreviewKeyDown += pictureBox1_PreviewKeyDown;
                pictureBox1.Focus();
            }

        }

        private void btnFolder_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = dispImageDir;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName; //on récupère la première image du répertoire
                if (System.IO.Path.GetDirectoryName(openFileDialog1.FileName) != dispImageDir)
                {
                    //btnRibbon.Enabled = false;
                    KillBGW();

                    //Get the path of specified file   
                    dispImageDir = System.IO.Path.GetDirectoryName(FileName);
                    currentFile = Array.IndexOf(Directory.GetFiles(dispImageDir, "*.ifz"), FileName);

                    nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;

                    LoadImage(FileName);

                    thumbnailsCreated = false;

                    Properties.Settings.Default.LastDir = dispImageDir;
                    zoomMode = ZoomMode.Scale;
                }
                else
                {
                    currentFile = Array.IndexOf(Directory.GetFiles(dispImageDir, "*.ifz"), FileName);
                    LoadImage(Directory.GetFiles(dispImageDir, "*.ifz")[currentFile]);
                }
            }
            pictureBox1.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string TempFileName = "";
            ImageFormat fmt = ImageFormat.Bmp;
            Bitmap bitmap = null;
            FiltLibIF.BayerMaster bayerMaster = new FiltLibIF.BayerMaster();
            FiltLibIF.MakeByrData(FileName, ref bayerMaster);
            int num1 = bayerMaster.camno;
            bayerMaster.ByrArray = null;
            GC.KeepAlive(bayerMaster);
            FiltLibIF.GetImageFileInfo(FileName);

            FiltLibIF.ImageFiletoBitmap(FileName, out bitmap, currentImage, -1, -1);

            if (bitmap != null)
            {
                TempFileName = Path.Combine(Path.GetTempPath(), System.IO.Path.GetFileNameWithoutExtension(FileName) + ".bmp");
                FiltLibIF.savepicture(bitmap, TempFileName, fmt, 100);
            }
            this.WindowState = FormWindowState.Minimized;

            ShellHelper.PrintPhotosWizard(TempFileName);

        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);

            //recalcul du zoomFit
            if ((float)bmp.Width / (float)bmp.Height < (float)pictureBox1.Width / (float)pictureBox1.Height)
                zoomFit = (float)pictureBox1.Height / (float)bmp.Height;
            else
                zoomFit = (float)pictureBox1.Width / (float)bmp.Width;

            //CenterImage();
            ZoomManagment();
            PositionImage();
            pictureBox1.Refresh();
            pictureBox1.Focus();


        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Form_Settings frm = new Form_Settings();
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            pictureBox1.Focus();

            Translation();
            UpdateButtonColor();
        }
        public IEnumerable<System.Windows.Forms.Control> GetAll(System.Windows.Forms.Control control, Type type)
        {
            var controls = control.Controls.Cast<System.Windows.Forms.Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        private void UpdateButtonColor()
        {
            this.Invalidate();
            this.Refresh();
            Properties.Settings.Default.Reload();

            var c = GetAll(this, typeof(System.Windows.Forms.Button));

            foreach (System.Windows.Forms.Button btn in c)
            {
                if (btn.Name != "btnClose")
                {
                    btn.FlatAppearance.MouseOverBackColor = global::OMRON_IFZ_Viewer.Properties.Settings.Default.ButtonBackGroundColor;
                }
            }

            c = GetAll(this, typeof(System.Windows.Forms.CheckBox));
            foreach (System.Windows.Forms.CheckBox btn in c)
                btn.FlatAppearance.MouseOverBackColor = global::OMRON_IFZ_Viewer.Properties.Settings.Default.ButtonBackGroundColor;
        }
        private void btnFlipLR_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Refresh();
        }

        private void btnFlipUD_Click(object sender, EventArgs e)
        {
            bmp.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Refresh();
        }

        private void cb_CheckedChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.CheckBox cb = sender as System.Windows.Forms.CheckBox;
            int value = Int32.Parse(cb.Name.Substring(2));
            currentImage = value - 1;
            DispImage(currentImage);
            ManageButtons();

        }
        #endregion

        #region //ToolTip
        void toolTip1_Draw(object sender, DrawToolTipEventArgs e)
        {
            Font f = new Font("Segoe UI Semibold", 9);
            toolTip1.BackColor = System.Drawing.Color.FromArgb(231, 44, 44, 44);
            e.DrawBackground();
            e.DrawBorder();

            e.Graphics.DrawString(e.ToolTipText, f, Brushes.White, new PointF(2, 0));
        }
        // Determines the correct size for the button2 ToolTip.
        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

            using (Font f = new Font("Segoe UI Semibold", 11))
            {
                e.ToolTipSize = TextRenderer.MeasureText(toolTip1.GetToolTip(e.AssociatedControl), f);

            }

        }
        #endregion


        #region //Filling ribbon area with background worker
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Invoke(new MethodInvoker(delegate
            {
                progressBar1.Value = 100;
            }));
            btnRibbon.Invoke(new MethodInvoker(delegate
            {
                //btnRibbon.Enabled = true;
            }));
            //btnRibbon.Enabled = true;
            // progressBar1.Value = 100;
            var nb = imageList1.Images.Count;
            this.listByrImgView.EndUpdate();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            // Do not try to use in any way an object derived from Control
            // like the ListView when you are inside the DoWork method.....
            BackgroundWorker worker = sender as BackgroundWorker;

            Bitmap bitmap = null;
            string[] files = Directory.GetFiles(this.dispImageDir, "*.ifz");
            int num = 0;
            for (int i = 0; i < (int)files.Length; i++)
            {
                //Permet d'annuler la tâche du background worker et de sortir de cette boucle
                if (worker.CancellationPending)
                {
                    break;
                }

                if (!(this.saveFormat != "bfz") || FiltLibIF.CheckCaptures(files[i]))
                {

                    bitmap = null;
                    FiltLibIF.BayerMaster bayerMaster = new FiltLibIF.BayerMaster();
                    FiltLibIF.MakeByrData(files[i], ref bayerMaster);
                    int num1 = bayerMaster.camno;
                    bayerMaster.ByrArray = null;
                    GC.KeepAlive(bayerMaster);
                    FiltLibIF.GetImageFileInfo(files[i]);
                    string str = "";
                    string str1 = "";
                    for (int j = 0; j < num1; j++)
                    {
                        FiltLibIF.ImageFiletoBitmap(files[i], out bitmap, j, -1, -1);
                        string[] fileName = new string[] { System.IO.Path.GetFileName(files[i]), "_", null, null, null };
                        fileName[2] = (j + 1).ToString();
                        fileName[3] = "/";
                        fileName[4] = num1.ToString();
                        str = string.Concat(fileName);
                        string[] strArrays = new string[] { files[i].Remove(files[i].Length - 4), "_", null, null, null, null };
                        strArrays[2] = (j + 1).ToString();
                        strArrays[3] = "/";
                        strArrays[4] = num1.ToString();
                        strArrays[5] = ".ifz";
                        str1 = string.Concat(strArrays);
                        if (bitmap != null)
                        {
                            worker.ReportProgress((i * 100 / (int)files.Length), new Tuple<Bitmap, int, string, string>(bitmap, num, str, str1));
                            num++;
                        }
                    }

                }

            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            // This code executes in the UI thread, no problem to 
            // work with Controls like the ListView

            var args = (Tuple<Bitmap, int, string, string>)e.UserState;

            // this.imageList1.Images.Add(this.RoundCorners(this.createThumbnail(args.Item1, 160, 120), 10, Color.FromArgb(39, 39, 39)));
            this.imageList1.Images.Add(this.createThumbnail(args.Item1, 100, 75));
            this.listByrImgView.Items.Add(args.Item3, args.Item2);
            this.listByrImgView.Items[args.Item2].Tag = args.Item4;
            this.listByrImgView.Items[args.Item2].ImageIndex = args.Item2;

            ((Bitmap)args.Item1).Dispose();

            progressBar1.Invoke(new MethodInvoker(delegate
            {
                progressBar1.Value = e.ProgressPercentage;
            }));
            // progressBar1.Value = e.ProgressPercentage;
        }
        public void KillBGW()
        {
            //On arrête le BackGroundWorker s'il est toujours en train d'indexer un dossier pour eviter les accès concurrents
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

            //on ne quitte pas cette fonction tant que le BGW n'a pas terminé.
            while (backgroundWorker1.IsBusy)
            {
                Application.DoEvents(); //sans cette ligne, le BGW.isBusy est toujours true
                System.Threading.Thread.Sleep(100);
            }
        }

        private System.Drawing.Image RoundCorners(System.Drawing.Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);

            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.HighQuality;
                g.CompositingQuality = CompositingQuality.HighQuality;
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;

                using (Brush brush = new TextureBrush(StartImage))
                {
                    using (GraphicsPath gp = new GraphicsPath())
                    {
                        gp.AddArc(-1, -1, CornerRadius, CornerRadius, 180, 90);
                        gp.AddArc(0 + RoundedImage.Width - CornerRadius, -1, CornerRadius, CornerRadius, 270, 90);
                        gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                        gp.AddArc(-1, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);

                        g.FillPath(brush, gp);
                    }
                }

                return RoundedImage;
            }
        }

        private System.Drawing.Image createThumbnail(System.Drawing.Image image, int w, int h)
        {
            Bitmap bitmap = new Bitmap(w, h);
            Graphics graphic = Graphics.FromImage(bitmap);
            graphic.FillRectangle(new SolidBrush(Color.FromArgb(27, 27, 27)), 0, 0, w, h);
            float width = (float)w / (float)image.Width;
            float height = (float)h / (float)image.Height;
            float single = Math.Min(width, height);
            width = (float)image.Width * single;
            height = (float)image.Height * single;
            graphic.DrawImage(image, ((float)w - width) / 2f, ((float)h - height) / 2f, width, height);
            graphic.Dispose();
            image.Dispose();

            return bitmap;
        }

        private void listByrImgView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listByrImgView.SelectedItems.Count == 0)
                return;

            string str;
            //int num;
            FiltLibIF.BayerMaster bayerMaster = new FiltLibIF.BayerMaster();
            try
            {
                str = string.Concat(this.listByrImgView.SelectedItems[0].Tag.ToString().Remove(this.listByrImgView.SelectedItems[0].Tag.ToString().Length - 8), ".ifz");
                CurrentImage = Convert.ToInt32(this.listByrImgView.SelectedItems[0].Tag.ToString().Substring(this.listByrImgView.SelectedItems[0].Tag.ToString().Length - 7, 1)) - 1;

                lblName.Text = System.IO.Path.GetFileName(str);
                lblFileNb.Text = (currentFile + 1) + "/" + nbIFZ;

                //LoadImage(dispImageDir, str, CurrentImage);
                LoadImage(str);
                Name = str;
                ManageButtons();
            }
            catch { }
            bayerMaster.ByrArray = null;

        }
        #endregion

        public void Translation()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.LangueSoft);

        }

        public void TranslateManagment(MouseEventArgs e)
        {
            //calculate the total distance to move from 0,0
            //previous image position+ current moving distance
            translateX = curImageX + ((e.X - transStartX) / zoomFac);
            translateY = curImageY + ((e.Y - transStartY) / zoomFac);

            if (bmp.Width * zoomFac > pictureBox1.Width)
            {
                if (translateX > 0)
                {
                    translateX = 0;
                }
                else if (translateX < -((bmp.Width * zoomFac) - pictureBox1.Width) / zoomFac)
                {
                    translateX = -((bmp.Width * zoomFac) - pictureBox1.Width) / zoomFac;
                }
            }
            else
            {
                translateX = -((bmp.Width * zoomFac) - pictureBox1.Width) / zoomFac / 2.0f;
            }
            if (bmp.Height * zoomFac > pictureBox1.Height)
            {
                if (translateY > 0)
                {
                    translateY = 0;
                }
                else if (translateY < -((bmp.Height * zoomFac) - pictureBox1.Height) / zoomFac)
                {
                    translateY = -((bmp.Height * zoomFac) - pictureBox1.Height) / zoomFac;
                }
            }
            else
            {
                translateY = -((bmp.Height * zoomFac) - pictureBox1.Height) / zoomFac / 2.0f;
            }

        }

        public void PositionImage()
        {
            if (bmp.Width * zoomFac > pictureBox1.Width && translateX > 0)
                translateX = 0;

            if (bmp.Height * zoomFac > pictureBox1.Height && translateY > 0)
                translateY = 0;

            if (bmp.Width * zoomFac > pictureBox1.Width && translateX < -((bmp.Width * zoomFac) - pictureBox1.Width) / zoomFac)
                translateX = -((bmp.Width * zoomFac) - pictureBox1.Width) / zoomFac;

            if (bmp.Height * zoomFac > pictureBox1.Height && translateY < -((bmp.Height * zoomFac) - pictureBox1.Height) / zoomFac)
                translateY = -((bmp.Height * zoomFac) - pictureBox1.Height) / zoomFac;


            //translateX = curImageX; translateY = curImageY;

            //centrage image
            if (bmp.Width * zoomFac <= pictureBox1.Width)
            {
                translateX = ((float)pictureBox1.Width - (float)bmp.Width * zoomFac) / 2.0f / zoomFac;
            }
            if (bmp.Height * zoomFac <= pictureBox1.Height)
            {
                translateY = ((float)pictureBox1.Height - (float)bmp.Height * zoomFac) / 2.0f / zoomFac;
            }
            curImageX = translateX; curImageY = translateY;
            //translateX = curImageX; translateY = curImageY;
        }

        public void ZoomManagment([Optional] float ZoomValue)
        {
            if (bmp != null)
            {
                switch (zoomMode)
                {
                    case ZoomMode.Fit:
                        if (bmp.Width < pictureBox1.Width && bmp.Height < pictureBox1.Height)
                        {
                            if ((float)bmp.Width / (float)bmp.Height < (float)pictureBox1.Width / (float)pictureBox1.Height)
                                zoomFac = (float)pictureBox1.Height / (float)bmp.Height;
                            else
                                zoomFac = (float)pictureBox1.Width / (float)bmp.Width;
                        }
                        else
                        {
                            zoomFac = zoomFit;
                        }

                        break;
                    case ZoomMode.Scale:
                        zoomFac = 1f;
                        if (bmp != null)
                        {
                            translateX = ((float)pictureBox1.Width - (float)bmp.Width * zoomFac) / 2.0f / zoomFac;
                            translateY = ((float)pictureBox1.Height - (float)bmp.Height * zoomFac) / 2.0f / zoomFac;
                        }
                        curImageX = translateX; curImageY = translateY;
                        break;
                    case ZoomMode.Free:
                        if (ZoomValue < EPS)
                        {
                            ZoomValue = 1f;
                        }
                        zoomFac = ZoomValue;
                        translateSet = true;
                        //zoomMode = ZoomMode.None;
                        break;
                    case ZoomMode.In:
                        if (zoomFac < 20f)
                            zoomFac *= 1.25f;

                        translateSet = true;
                        if (bmp != null)
                        {
                            translateX = ((float)pictureBox1.Width - (float)bmp.Width * zoomFac) / 2.0f / zoomFac;
                            translateY = ((float)pictureBox1.Height - (float)bmp.Height * zoomFac) / 2.0f / zoomFac;
                        }
                        //zoomMode = ZoomMode.None;
                        curImageX = translateX; curImageY = translateY;
                        break;
                    case ZoomMode.Out:
                        if (zoomFac > 0.1f)
                            zoomFac *= 0.8f;

                        if (zoomFit > 1f) //pour les petites images, le zoom ne peut pas descendre sous 100%
                        {
                            if (zoomFac <= 1f)
                            {
                                zoomFac = 1f;
                            }
                        }
                        else //pour les grandes images, limitation du zoom out si l'image devient plus petite que la zone
                        {
                            if (zoomFac <= zoomFit + 0.01f)
                            {
                                zoomFac = zoomFit;
                            }
                        }
                        translateSet = true;
                        //zoomMode = ZoomMode.None;
                        curImageX = translateX; curImageY = translateY;
                        break;
                    default:
                        if (zoomFac < zoomFit)
                            zoomFac = zoomFit;
                        break;
                }
            }
            btnZoomToScale.Enabled = (Math.Abs(zoomFac - 1f) > EPS);
            btnZoomToFit.Enabled = (Math.Abs(zoomFac - zoomFit) > EPS);
            btnZoomOut.Enabled = ((zoomFit > 1f && zoomFac > 1f) || (zoomFit < 1 && zoomFac > zoomFit));
            btnZoomIn.Enabled = (zoomFac < 20f);
            //    PositionImage();
        }

        public enum ZoomMode : uint
        {
            Fit = 0,
            Scale = 1,
            Free = 2,
            In = 3,
            Out = 4,
            None = 5
        }


        #region //Resize

        bool onFullScreen;
        bool maximized;
        bool on_MinimumSize;
        short minimumWidth = 350;
        short minimumHeight = 26;
        short borderSpace = 5;
        short borderDiameter = 5;

        bool onBorderRight = false;
        bool onBorderLeft = false;
        bool onBorderTop = false;
        bool onBorderBottom = false;
        bool onCornerTopRight = false;
        bool onCornerTopLeft = false;
        bool onCornerBottomRight = false;
        bool onCornerBottomLeft = false;

        bool movingRight = false;
        bool movingLeft = false;
        bool movingTop = false;
        bool movingBottom = false;
        bool movingCornerTopRight = false;
        bool movingCornerTopLeft = false;
        bool movingCornerBottomRight = false;
        bool movingCornerBottomLeft = false;

        private void Borderless_MouseUp(object sender, MouseEventArgs e)
        {
            stopResizer();
        }

        private void Borderless_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (onBorderRight) { movingRight = true; } else { movingRight = false; }
                if (onBorderLeft) { movingLeft = true; } else { movingLeft = false; }
                if (onBorderTop) { movingTop = true; } else { movingTop = false; }
                if (onBorderBottom) { movingBottom = true; } else { movingBottom = false; }
                if (onCornerTopRight) { movingCornerTopRight = true; } else { movingCornerTopRight = false; }
                if (onCornerTopLeft) { movingCornerTopLeft = true; } else { movingCornerTopLeft = false; }
                if (onCornerBottomRight) { movingCornerBottomRight = true; } else { movingCornerBottomRight = false; }
                if (onCornerBottomLeft) { movingCornerBottomLeft = true; } else { movingCornerBottomLeft = false; }
                if (!onBorderRight & !onBorderLeft & !onBorderTop & !onBorderBottom & !onCornerTopRight & !onCornerTopLeft & !onCornerBottomLeft & !onCornerBottomRight)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void Borderless_MouseMove(object sender, MouseEventArgs e)
        {
            if (onFullScreen | maximized) { return; }

            if (this.Width <= minimumWidth) { this.Width = (minimumWidth + 5); on_MinimumSize = true; }
            if (this.Height <= minimumHeight) { this.Height = (minimumHeight + 5); on_MinimumSize = true; }
            if (on_MinimumSize) { stopResizer(); } else { startResizer(); }


            onBorderRight = false;
            onBorderLeft = false;
            onBorderTop = false;
            onBorderBottom = false;
            onCornerTopRight = false;
            onCornerTopLeft = false;
            onCornerBottomRight = false;
            onCornerBottomLeft = false;

            if ((Cursor.Position.X > ((this.Location.X + this.Width) - borderDiameter))
                & (Cursor.Position.Y > (this.Location.Y + borderSpace))
                & (Cursor.Position.Y < ((this.Location.Y + this.Height) - borderSpace)))
            { this.Cursor = Cursors.SizeWE; onBorderRight = true; }

            else if ((Cursor.Position.X < (this.Location.X + borderDiameter))
                & (Cursor.Position.Y > (this.Location.Y + borderSpace))
                & (Cursor.Position.Y < ((this.Location.Y + this.Height) - borderSpace)))
            { this.Cursor = Cursors.SizeWE; onBorderLeft = true; }

            else if ((Cursor.Position.Y < (this.Location.Y + borderDiameter))
                & (Cursor.Position.X > (this.Location.X + borderSpace))
                & (Cursor.Position.X < ((this.Location.X + this.Width) - borderSpace)))
            { this.Cursor = Cursors.SizeNS; onBorderTop = true; }

            else if ((Cursor.Position.Y > ((this.Location.Y + this.Height) - borderDiameter))
                & (Cursor.Position.X > (this.Location.X + borderSpace))
                & (Cursor.Position.X < ((this.Location.X + this.Width) - borderSpace)))
            { this.Cursor = Cursors.SizeNS; onBorderBottom = true; }

            else if ((Cursor.Position.X >= ((this.Location.X + this.Width) - borderDiameter))
                & (Cursor.Position.Y <= this.Location.Y + borderDiameter))
            { this.Cursor = Cursors.SizeNESW; onCornerTopRight = true; }

            else if ((Cursor.Position.X <= this.Location.X + borderDiameter)
                & (Cursor.Position.Y <= this.Location.Y + borderDiameter))
            { this.Cursor = Cursors.SizeNWSE; onCornerTopLeft = true; }

            else if ((Cursor.Position.X >= ((this.Location.X + this.Width) - borderDiameter))
                & (Cursor.Position.Y >= ((this.Location.Y + this.Height) - borderDiameter)))
            { this.Cursor = Cursors.SizeNWSE; onCornerBottomRight = true; }

            else if ((Cursor.Position.X <= this.Location.X + borderDiameter)
                & (Cursor.Position.Y >= ((this.Location.Y + this.Height) - borderDiameter)))
            { this.Cursor = Cursors.SizeNESW; onCornerBottomLeft = true; }

            else
            {
                onBorderRight = false;
                onBorderLeft = false;
                onBorderTop = false;
                onBorderBottom = false;
                onCornerTopRight = false;
                onCornerTopLeft = false;
                onCornerBottomRight = false;
                onCornerBottomLeft = false;
                this.Cursor = Cursors.Default;
            }
        }

        private void startResizer()
        {
            if (movingRight)
            {
                this.Width = Cursor.Position.X - this.Location.X;
            }

            else if (movingLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }

            else if (movingTop)
            {
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingBottom)
            {
                this.Height = (Cursor.Position.Y - this.Location.Y);
            }

            else if (movingCornerTopRight)
            {
                this.Width = (Cursor.Position.X - this.Location.X);
                this.Height = ((this.Location.Y - Cursor.Position.Y) + this.Height);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerTopLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
                this.Height = ((this.Height + this.Location.Y) - Cursor.Position.Y);
                this.Location = new Point(this.Location.X, Cursor.Position.Y);
            }

            else if (movingCornerBottomRight)
            {
                this.Size = new Size(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);

            }

            else if (movingCornerBottomLeft)
            {
                this.Width = ((this.Width + this.Location.X) - Cursor.Position.X);
                this.Height = (Cursor.Position.Y - this.Location.Y);
                this.Location = new Point(Cursor.Position.X, this.Location.Y);
            }
        }

        private void stopResizer()
        {
            movingRight = false;
            movingLeft = false;
            movingTop = false;
            movingBottom = false;
            movingCornerTopRight = false;
            movingCornerTopLeft = false;
            movingCornerBottomRight = false;
            movingCornerBottomLeft = false;
            this.Cursor = Cursors.Default;
            System.Threading.Thread.Sleep(300);
            on_MinimumSize = false;
        }



        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            pnlImageInfo.Visible = true;
            pnlImageInfo.Width = 344;
            PopulatePnlImageInfo();

        }

        private void btnClosePanel_Click(object sender, EventArgs e)
        {
            pnlImageInfo.Visible = false;
            pnlImageInfo.Width = 0;
        }
        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string folder = System.IO.Path.GetDirectoryName(FileName);
                string newName = System.IO.Path.Combine(folder, tbIFZName.Text + ".ifz");
                try { 
                System.IO.File.Move(FileName, newName);
                // FileName = System.IO.Path.GetFileName(newName);
                lblName.Text = System.IO.Path.GetFileName(newName);
                FileName = newName;
            }
                catch(Exception ex)
                {
                MessageBox.Show(ex.Message);
            }
        }
    }

    private void PopulatePnlImageInfo()
    {
        tbIFZName.Text = System.IO.Path.GetFileNameWithoutExtension(lblName.Text);
        //long length = new System.IO.FileInfo(FileName).Length;
        FileInfo fi = new FileInfo(FileName);
        string Size = MyExtensions.FileSizeFormatter.FormatSize(fi.Length);
        lblSizeInfo.Text = Properties.strings.lblSize;
        lblSize2.Text = bmp.Width.ToString() + " x " + bmp.Height.ToString() + "  " + Size;
        lblFolder.Text = Properties.strings.lblFolder;
        linkLabel.Text = FileName;
        lblCamera.Text = Properties.strings.lblCamera;
        lblCamera2.Text = CameraGuess();
    }

    private string CameraGuess()
    {
        string res = bmp.Width.ToString() + " x " + bmp.Height.ToString();
        string camtype = "unknown";
        switch (res)
        {
            case "640 x 480":
                if (IsGreyScale)
                    camtype = "FH-SM/FZ-S/FZ-SH/FZ-SF/FZ-SP";
                else
                    camtype = "FH-SC/FZ-SC/FZ-SHC/FZ-SFC/FZ-SPC";
                break;
            case "720 x 540":
                if (IsGreyScale)
                    camtype = "FH-SMX/FHV7■-M004";
                else
                    camtype = "FH-SCX/FHV7■-C004";
                break;
            case "752 x 480":
                if (IsGreyScale)
                    camtype = "FQ2-CH■-M/FQ2CR■-M/FQ-M12■-M";
                else
                    camtype = "FZ-SQ/FQ2-S1■/FQ2-S2■/FQ-M12■";
                break;
            case "928 x 828":
                if (IsGreyScale)
                    camtype = "FQ2-S3■-08M/FQ2-S4■-08M";
                else
                    camtype = "FQ2-S■-08/FQ2-S4■-08";
                break;
            case "1280 x 1024":
                if (IsGreyScale)
                    camtype = "FQ2-S3■-13M/FQ2-S4■-13M";
                else
                    camtype = "FQ2-S■-13/FQ2-S4■-13";
                break;
            case "1440 x 1080":
                if (IsGreyScale)
                    camtype = "FH-SMX01/FHV7■-M016";
                else
                    camtype = "FH-SCX01/FHV7■-C016";
                break;
            case "1600 x 1200":
                if (IsGreyScale)
                    camtype = "FZ-S2M";
                else
                    camtype = "FZ-SC2M";
                break;
            case "2040 x 1088":
                if (IsGreyScale)
                    camtype = "FH-SM02";
                else
                    camtype = "FH-SC02";
                break;
            case "2046 x 1536":
                if (IsGreyScale)
                    camtype = "FH-SMX03";
                else
                    camtype = "FH-SCX03";
                break;
            case "2048 x 1536":
                if (IsGreyScale)
                    camtype = "FHV7■-M032";
                else
                    camtype = "FHV7■-C032";
                break;
            case "2040 x 2048":
                if (IsGreyScale)
                    camtype = "FH-SM04";
                else
                    camtype = "FH-SC04";
                break;
            case "2448 x 2044":
                if (IsGreyScale)
                    camtype = "FZ-S5M2";
                else
                    camtype = "FZ-SC5M2";
                break;
            case "2448 x 2048":
                if (IsGreyScale)
                    camtype = "FH-SMX05/FHV7■-M050/FZ-S5M3";
                else
                    camtype = "FH-SCX05/FHV7■-C050/FZ-SC5M3";
                break;
            case "2592 x 1944":
                if (IsGreyScale)
                    camtype = "FH-SM05R";
                else
                    camtype = "FH-SC05R";
                break;
            case "3072 x 2048":
                if (IsGreyScale)
                    camtype = "FHV7■-M063R";
                else
                    camtype = "FHV7■-C063R";
                break;
            case "4000 x 3000":
                if (IsGreyScale)
                    camtype = "FHV7■-M120R";
                else
                    camtype = "FHV7■-C120R";
                break;
            case "4084 x 3072":
                if (IsGreyScale)
                    camtype = "FH-SM12";
                else
                    camtype = "FH-SC12";
                break;
            case "4092 x 3000":
                if (IsGreyScale)
                    camtype = "FH-SMX12";
                else
                    camtype = "FH-SCX12";
                break;
            case "5544 x 3692":
                if (IsGreyScale)
                    camtype = "FH-SM21R";
                else
                    camtype = "FH-SC21R";
                break;
        }
        return camtype;
    }

    private void tbIFZName_Leave(object sender, EventArgs e)
    {
        tbIFZName.Text = System.IO.Path.GetFileNameWithoutExtension(lblName.Text);

    }


    private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {

        if (!File.Exists(FileName)) { return; }

        // combine the arguments together
        // it doesn't matter if there is a space after ','
        string argument = "/select, \"" + FileName + "\"";

        Process.Start("explorer.exe", argument);

    }

    private void linkLabel_MouseEnter(object sender, EventArgs e)
    {
        linkLabel.LinkColor = Color.FromArgb(155, 155, 155);
    }

    private void linkLabel_MouseLeave(object sender, EventArgs e)
    {
        linkLabel.LinkColor = Color.FromArgb(0, 120, 215);
    }

    private void Form_DisplayImage_DragEnter(object sender, DragEventArgs e)
    {
        e.Effect = DragDropEffects.Move;
    }

    private void Form_DisplayImage_DragDrop(object sender, DragEventArgs e)
    {
        string[] fileList = (string[])e.Data.GetData(DataFormats.FileDrop, false);
        LoadImage(fileList[0]);

    }
}
public static class MyExtensions
{
    public static class FileSizeFormatter
    {
        // Load all suffixes in an array  
        static readonly string[] suffixes =
        { "Bytes", "KB", "MB", "GB", "TB", "PB" };
        public static string FormatSize(Int64 bytes)
        {
            int counter = 0;
            decimal number = (decimal)bytes;
            while (Math.Round(number / 1024) >= 1)
            {
                number = number / 1024;
                counter++;
            }
            return string.Format("{0:n2}{1}", number, suffixes[counter]);
        }
    }

}
}