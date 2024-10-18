using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMRON_IFZ_Viewer
{
    public partial class Form_Convert : Form
    {

        public string dispImageDir;
        public ImageFormat fmt = ImageFormat.Bmp;
        public string fileExtension = ".bmp";
        public int nbIFZ;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public Form_Convert(string Folder)
        {
            dispImageDir = Folder;
            InitializeComponent();
            progressBar1.Value = 0;
            nbIFZ = Directory.GetFiles(dispImageDir, "*.ifz").Length;
            this.TopMost = true; //permet d'avoir cette fenêtre non modale toujours devant.
            //this.BringToFront();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;

            lblSubtitle.Text = Properties.strings.Convert_label;
            lblTitle.Text = Properties.strings.Convert_title;
            btnCancel.Text = Properties.strings.Convert_cancel;
            btnConvert.Text = Properties.strings.Convert_convert;

            comboBox1.SelectedIndex= Properties.Settings.Default.ConversionFileFormat;
            label1.Text = "0/" + nbIFZ.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            KillBGW();
            
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private const int CS_DROPSHADOW = 0x00020000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        #region // Déplacement de la fenêtre

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        private void Form_Convert_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        #endregion



        private void btnConvert_Click(object sender, EventArgs e)
        {
            
            //progressBar1.Maximum = nbIFZ;
            ConvertIfz();
        }

        private void ConvertIfz()
        {
            if (!backgroundWorker1.IsBusy)
            {
                progressBar1.Value = 0;
                backgroundWorker1.RunWorkerAsync();
            }
        }

        #region // background worker to convert
        private void BackgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Invoke(new MethodInvoker(delegate
            {
                progressBar1.Value = 100;
            }));
            label1.Invoke(new MethodInvoker(delegate
            {

                label1.Text = nbIFZ.ToString() + "/" + nbIFZ.ToString();
            }));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            string FileName;
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

                FileName = "a construire";

               

                if (FiltLibIF.CheckCaptures(files[i]))
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
                        
                        if (bitmap != null)
                        {
                            if(num1==1)
                                FileName = System.IO.Path.GetFileNameWithoutExtension(files[i])+ fileExtension;
                            else
                                FileName = System.IO.Path.GetFileNameWithoutExtension(files[i]) +"_"+j.ToString()+ fileExtension;


                            FiltLibIF.savepicture(bitmap, dispImageDir+"\\"+FileName, fmt, 100);
                            worker.ReportProgress((i * 100 / (int)files.Length),FileName);
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

            var FileName = (string)e.UserState;

            progressBar1.Invoke(new MethodInvoker(delegate
            {
                progressBar1.Value = e.ProgressPercentage;
            }));
            // progressBar1.Value = e.ProgressPercentage;

            var val=Math.Round((double)e.ProgressPercentage* nbIFZ/100);
            label1.Invoke(new MethodInvoker(delegate
            {

                label1.Text = val.ToString()+"/" + nbIFZ.ToString();
            }));
            
        }
        public void KillBGW()
        {
            //On arrête le BackGroundWorker s'il est toujours en train d'indexer un dossier pour eviter les accès concurrents
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
            }

            while (backgroundWorker1.IsBusy)
            {
                Application.DoEvents();//sans cette ligne, le BGW.isBusy est toujours true
                System.Threading.Thread.Sleep(100);
            }
        }

        #endregion

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex+1)
            {
                case 1: //BMP
                    fmt = ImageFormat.Bmp;
                    fileExtension = ".bmp";
                    break;
                case 2: //JPEG
                    fmt = ImageFormat.Jpeg;
                    fileExtension = ".jpg";
                    break;
                case 3: //PNG
                    fmt = ImageFormat.Png;
                    fileExtension = ".png";
                    break;
                case 4: //TIF
                    fmt = ImageFormat.Tiff;
                    fileExtension = ".tif";
                    break;
                case 5: //GIF
                    fmt = ImageFormat.Gif;
                    fileExtension = ".gif";
                    break;
                    //case 6: //IFZ

                    //    break;
                    //case 7: //StRAW
                    //    fmt = ImageFormat.Jpeg;
                    //    break;
            }
            Properties.Settings.Default.ConversionFileFormat=comboBox1.SelectedIndex;
        }

        private void Form_Convert_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
