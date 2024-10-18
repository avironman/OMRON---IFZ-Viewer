using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMRON_IFZ_Viewer
{
    public partial class Form_Zoom : Form
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

        public float ReturnZoom { get; set; }
        public Form_Zoom(string ZoomValue)
        {
            InitializeComponent();
            this.TopMost = true;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;
            textBox1.Text = ZoomValue;
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

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) || e.KeyChar== Convert.ToChar(Keys.Delete))
            {
                this.DialogResult = DialogResult.OK;
                
                    int found = textBox1.Text.IndexOf("%", 0, textBox1.Text.Length) ;
                if (found != -1)        
                    this.ReturnZoom = float.Parse(textBox1.Text.Remove(found, 1)) / 100;
                else
                    this.ReturnZoom = float.Parse(textBox1.Text)/100;

                if (this.ReturnZoom <= 0)
                    this.ReturnZoom = 1;

                Close();
            }
            e.Handled = !char.IsDigit(e.KeyChar);

            
          
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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            textBox1.Text = String.Format("{0:P2}", textBox1.Text);
        }
    }
}
