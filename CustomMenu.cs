using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMRON_IFZ_Viewer
{
    public partial class CustomMenu : Form
    {
        public string ReturnValue { get; set; }

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
        public CustomMenu()
        {
            InitializeComponent();
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.LangueSoft);

            this.StartPosition = FormStartPosition.Manual;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;
            this.DialogResult = DialogResult.Cancel;

            btnSaveas.Text = "       " + Properties.strings.CM_Saveas;
            btnPrint.Text = "       " + Properties.strings.CM_Print;
            btnCopy.Text = "       "+Properties.strings.CM_Copy;
            btnOpenwith.Text = "       " + Properties.strings.CM_Openwith;
            btnOpenInBrowser.Text = "       " + Properties.strings.CM_OpenFolder;
            btnCopyPath.Text = "       " + Properties.strings.CM_CopyPath;
            btnBatchConvert.Text = "       " + Properties.strings.CM_BatchConvert;

            btnErase.Text = "       " + Properties.strings.CM_Delete;
            btnFolder.Text = "       " + Properties.strings.CM_OpenFolder;
            btnRotate.Text = "       " + Properties.strings.CM_Rotate;
            btnSettings.Text = "       " + Properties.strings.CM_Settings;
            btnFlipLR.Text = "       " + Properties.strings.CM_FlipLR;
            btnFlipUD.Text = "       " + Properties.strings.CM_FlipUD;
            btnInfo.Text = "       " + Properties.strings.CM_Info;
            //--- --- ---

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

        private void handleDeactivate()
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            const UInt32 WM_NCACTIVATE = 0x0086;

            if (m.Msg == WM_NCACTIVATE && m.WParam.ToInt32() == 0)
            {
                handleDeactivate();
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        // --- --- --- _Click button functions from menu --- --- ---

        private void btnSaveAs_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "SaveAs";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Print";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Copy";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCopyPath_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "CopyPath";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOpenWith_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "OpenWith";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOpenInExplorer_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "OpenInExplorer";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatchConvert_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Convert";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Delete";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnGetPixel_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "GetPixelValue";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Rotate";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFlipLR_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "FlipLR";
            this.DialogResult = DialogResult.OK;
            this.Close();
            
        }

        private void btnFlipUD_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "FlipUD";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "OpenFolder";
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Delete";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Settings";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Info";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
