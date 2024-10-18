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

            btnCopy.Text = "       "+Properties.strings.CM_Copy;
            btnOpenwith.Text = "       " + Properties.strings.CM_Openwith;
            btnPrint.Text = "       " + Properties.strings.CM_Print;
            btnSaveas.Text = "       " + Properties.strings.CM_Saveas;
            btnOpenFolder.Text = "       " + Properties.strings.CM_OpenFolder;
            btnCopyPath.Text = "       " + Properties.strings.CM_CopyPath;
            btnErase.Text = "       " + Properties.strings.CM_Erase;
        }
        public static void ShowOpenWithDialog(string path)
        {
            var args = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "shell32.dll");
            args += ",OpenAs_RunDLL " + path;
            Process.Start("rundll32.exe", args);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Print";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "SaveAs";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Copy";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string FileName = ((Form_DisplayImage)this.Owner).dispImageDir + "\\" + ((Form_DisplayImage)this.Owner).lblName.Text;
            ShowOpenWithDialog(FileName);
            this.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            string FileName = Path.GetDirectoryName(((Form_DisplayImage)this.Owner).dispImageDir + "\\" + ((Form_DisplayImage)this.Owner).lblName.Text);
            Process.Start(FileName);
            this.Close();
        }

        private void btnCopyPath_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText(((Form_DisplayImage)this.Owner).dispImageDir + "\\" + ((Form_DisplayImage)this.Owner).lblName.Text);
            this.Close();
        }

        private void btnErase_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Delete";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatchConvert_Click(object sender, EventArgs e)
        {
            this.ReturnValue = "Convert";
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
