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
    public partial class Form_Confirm : Form
    {
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

        public Form_Confirm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;
            this.TopMost = true; //permet d'avoir cette fenêtre non modale toujours devant.
           //this.BringToFront();
            lblSubtitle.Text = Properties.strings.Confirm_label1;
            lblTitle.Text = Properties.strings.Confirm_label2;
            btnCancel.Text = Properties.strings.Confirm_cancel;
            btnDelete.Text = Properties.strings.Confirm_delete;
        }
        //protected override void OnLostFocus(EventArgs e)
        //{
        //    this.BringToFront();
        //    this.Focus();
        //    base.OnLostFocus(e);
        //}

        //protected override void OnDeactivate(EventArgs e)
        //{
        //    this.BringToFront();
        //    this.Focus();
        //    base.OnDeactivate(e);
        //}
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
    }
}
