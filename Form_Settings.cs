using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OMRON_IFZ_Viewer
{
    public partial class Form_Settings : Form
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

        public Form_Settings()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.ShowInTaskbar = false;
            //allows to have this non-modal window always in front.
            //permet d'avoir cette fenêtre non modale toujours devant.
            this.TopMost = true; 

            lblVersion.Text = Application.ProductVersion;
            
            Translation();

            InitializeCmbColor();
            InitializeCmbThemeColor();

        }

        private void Form_Settings_Load(object sender, EventArgs e)
        {
            // Set Language
            switch (Properties.Settings.Default.LangueSoft)
            {
                case "fr-FR":
                    cmbLanguage.SelectedIndex = 0;
                    break;

                case "it-IT":
                    cmbLanguage.SelectedIndex = 2;
                    break;

                case "de-DE":
                    cmbLanguage.SelectedIndex = 3;
                    break;

                case "en-US":
                    cmbLanguage.SelectedIndex = 1;
                    break;

                default:
                    cmbLanguage.SelectedIndex = 1;
                    break;

            }
            
            // Set Zoom
            cmbZoom.SelectedIndex = Properties.Settings.Default.ZoomMode;

            // lblVersion.Text= Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        private void InitializeCmbColor()
        {
            // Set ComboBox properties for a modern look
            cmbColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbColor.FlatStyle = FlatStyle.Flat;
            cmbColor.DrawMode = DrawMode.OwnerDrawFixed;
            // colorComboBox.Width = 150;

            // Add colors to ComboBox
            cmbColor.Items.Add(Color.FromArgb(31, 31, 31));    //default black
            cmbColor.Items.Add(Color.FromArgb(204,204,204));   //grey
            cmbColor.Items.Add(Color.FromArgb(222,12,140));    //pink
            cmbColor.Items.Add(Color.FromArgb(0, 94, 184));    //blue
            cmbColor.Items.Add(Color.FromArgb(140,222, 12));   //light green
            cmbColor.Items.Add(Color.FromArgb(122, 73, 165));  //vio
            cmbColor.Items.Add(Color.FromArgb(0,153,99));      //green
            cmbColor.Items.Add(Color.FromArgb(255,165,0));     //orange

            // Events defined in Properties of the Form_Settings

            // Set initial selection for Color
            cmbColor.SelectedIndex = cmbColor.Items.IndexOf(Properties.Settings.Default.ButtonBackGroundColor);

        }

        private void cmbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            
            // Get color item
            Color color = (Color)cmbColor.Items[e.Index];

            // Draw background and selection
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds.X + 2, e.Bounds.Y + 2, 20, e.Bounds.Height - 4);

            // Draw color name next to color box
            TextRenderer.DrawText(e.Graphics, color.Name, e.Font, new Point(e.Bounds.X + 30, e.Bounds.Y + 2), Color.Black);

            e.DrawFocusRectangle();
        }

        private void cmbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set form background to selected color
            btnSettings.BackColor = (Color)cmbColor.SelectedItem;
            Properties.Settings.Default.ButtonBackGroundColor = (Color)cmbColor.SelectedItem;
        }

        /// <summary>
        /// Init theme color selector combobox
        /// </summary>
        private void InitializeCmbThemeColor()
        {
            // Set ComboBox properties for a modern look
            cmbThemeColor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbThemeColor.FlatStyle = FlatStyle.Flat;
            cmbThemeColor.DrawMode = DrawMode.OwnerDrawFixed;

            // Add colors to ComboBox
            cmbThemeColor.Items.Add(Color.FromArgb(31, 31, 31));    //default black
            cmbThemeColor.Items.Add(Color.FromArgb(204, 204, 204));   //grey
            cmbThemeColor.Items.Add(Color.FromArgb(222, 12, 140));    //pink
            cmbThemeColor.Items.Add(Color.FromArgb(0, 94, 184));    //blue
            cmbThemeColor.Items.Add(Color.FromArgb(140, 222, 12));   //light green
            cmbThemeColor.Items.Add(Color.FromArgb(122, 73, 165));  //vio
            cmbThemeColor.Items.Add(Color.FromArgb(0, 153, 99));      //green
            cmbThemeColor.Items.Add(Color.FromArgb(255, 165, 0));     //orange

            // Set initial selection for Theme
            cmbThemeColor.SelectedIndex = cmbThemeColor.Items.IndexOf(Properties.Settings.Default.ThemeColor);
        }

        private void cmbThemeColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            // Get color item
            Color color = (Color)cmbThemeColor.Items[e.Index];

            // Draw background and selection
            e.DrawBackground();
            e.Graphics.FillRectangle(new SolidBrush(color), e.Bounds.X + 2, e.Bounds.Y + 2, 20, e.Bounds.Height - 4);

            // Draw color name next to color box
            TextRenderer.DrawText(e.Graphics, color.Name, e.Font, new Point(e.Bounds.X + 30, e.Bounds.Y + 2), Color.Black);

            e.DrawFocusRectangle();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.Reload();
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

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            string language;
            switch (cmbLanguage.SelectedItem)
            {
                case "Français":
                    language = "fr-FR";
                    break;

                case "Italiano":
                    language = "it-IT";
                    break;

                case "Deutsch":
                    language = "de-DE";
                    break;

                case "English":
                    language = "en-US";
                    break;

                default:
                    language = "en-US";
                    break;

            }
            Properties.Settings.Default.LangueSoft = language;
            Translation();
        }

        private void Translation()
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(Properties.Settings.Default.LangueSoft);
            lblTitle.Text = Properties.strings.Settings_Title;
            lbl1.Text = Properties.strings.Settings_lbl1;
            lbl2.Text = Properties.strings.Settings_lbl2;
            lbl3.Text = Properties.strings.Settings_lbl3;
            lbl4.Text = Properties.strings.Settings_lbl4;
            lbl5.Text = Properties.strings.Settings_lbl5;
            lbl6.Text = Properties.strings.Settings_lbl6;

            cmbZoom.Items.Clear();
            cmbZoom.Items.Add(Properties.strings.Settings_cb2_opt1);
            cmbZoom.Items.Add(Properties.strings.Settings_cb2_opt2);
        
            btnClose.Text = Properties.strings.Settings_btnClose;

            Refresh();
        }

        private void cmbZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.ZoomMode = cmbZoom.SelectedIndex;
            Console.WriteLine(cmbZoom.SelectedIndex);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = @".\ServerRegistrationManager.exe";
            process.StartInfo.Arguments = "install IfzThumbnailHandler.dll -codebase";
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.
        }

        private void emailJerome_Click(object sender, EventArgs e)
        {
            var url = "mailto:pinard.jerome@gmail.com";
            Process.Start(url);
        }

        private void emailYury_Click(object sender, EventArgs e)
        {
            var url = "mailto:yury.puzino@omron.com";
            Process.Start(url);
        }

        private void cmbThemeColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set form background to selected color
            // btnSettings.BackColor = (Color)cmbColor.SelectedItem;
            Properties.Settings.Default.ThemeColor = (Color)cmbThemeColor.SelectedItem;
        }
    }
}
