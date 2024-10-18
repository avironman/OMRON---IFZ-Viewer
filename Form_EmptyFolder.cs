using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMRON_IFZ_Viewer
{
    public partial class Form_EmpryFolder : Form
    {
        public string ReturnValue { get; set; }

        public string InitValue { get; set; }

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

        public Form_EmpryFolder()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;

            lblSubtitle.Text = Properties.strings.EmptyFolder_label2;
            lblTitle.Text = Properties.strings.EmptyFolder_label1;
            btnClose.Text = "       " + Properties.strings.EmptyFolder_cancel;
            btnOpenFolder.Text = "       " + Properties.strings.EmptyFolder_browse;
        }
        protected override void OnLostFocus(EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            base.OnLostFocus(e);
        }

        protected override void OnDeactivate(EventArgs e)
        {
            this.BringToFront();
            this.Focus();
            base.OnDeactivate(e);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
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

        private void btnClose_Click(object sender, EventArgs e)
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
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = InitValue;
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.ReturnValue = openFileDialog1.FileName; //on récupère la première image du répertoire
                this.DialogResult = DialogResult.OK;
                //this.ReturnValue = "Print";
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;

            }
            
        }
    }
}
