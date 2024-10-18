using System;
using System.Runtime;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Runtime.InteropServices;
using System.Drawing;

namespace OMRON_IFZ_Viewer
{
    internal static class Program
    {
        public static string FileName;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            // ***this line is added***
            if (Environment.OSVersion.Version.Major >= 6)
                SetProcessDPIAware();

            int scale = GetDpiScaleFactor();
            Console.WriteLine(scale);
            if (scale != 100)
                MessageBox.Show(String.Format(Properties.strings.DPI_Message,scale));

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //GCSettings.LatencyMode = GCLatencyMode.Interactive;
            GCSettings.LatencyMode = GCLatencyMode.LowLatency;
            //Properties.Settings.Default.LastDir = "";

            SingleInstanceController controller = new SingleInstanceController();
            // etape 0 --> etape 1
            controller.Run(args);

        }

        static int GetDpiScaleFactor()
        {
            const int _DEFAULT_DPI = 96;
            Graphics gr = Graphics.FromImage(new Bitmap(1, 1)); //A Graphics object is needed for native DPI detection.
            return (int)(gr.DpiX / _DEFAULT_DPI * 100); //In percentages, as shown in Windows
        }

        // ***also dllimport of that function***
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool SetProcessDPIAware();

        [DllImport("User32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern uint GetDpiForWindow(IntPtr hwnd);

        public class SingleInstanceController : WindowsFormsApplicationBase
        {
            public delegate void ShowIt();
            public delegate void ConvertIFZ(string FileName, string option);
            public delegate void LoadImageFromIcon(string FileName);
            public SingleInstanceController()
            {

                IsSingleInstance = true;
                StartupNextInstance += this_StartupNextInstance;

            }

            void this_StartupNextInstance(object sender, StartupNextInstanceEventArgs e)
            {
                //Cette méthode est apellée lorsqu'on apelle le soft alors qu'il est déjà ouvert
                // etape 1
                
                switch (e.CommandLine.Count)
                {
                    case 1: // Lorsqu'on double clique sur un fichier IFZ
                       
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(Form_DisplayImage))
                            {
                               ( (Form_DisplayImage)form).LoadImage(e.CommandLine[0]);
                            }
                        }                              
                        break;
                    //case 2:
                    //    // Lorsqu'on utilise Convertir en JPEG du menu contextuel Windows
                    //    (Application.OpenForms["Form1"] as Form_DisplayImage).ConvertIFZ(e.CommandLine[0], e.CommandLine[1]);
                    //    //form.ConvertIFZ(e.CommandLine[0], e.CommandLine[1]);
                    //    break;
                    default:// Lorsqu'on lance l'exe depuis une ligne de commande (sans argument) alors qu'il est deja en cours d'execution
                        foreach (Form form in Application.OpenForms)
                        {
                            if (form.GetType() == typeof(Form_DisplayImage))
                            {
                                ((Form_DisplayImage)form).ShowIt();
                            }
                        }

                        break;
                }

            }
            protected override void OnCreateMainForm()
            {
                //Cette méthode est apellée lorsqu'on lance le soft pour la première fois
                int argnb = Environment.GetCommandLineArgs().Length;
                //using (StreamWriter writer = new StreamWriter("D:\\IFZ Viewer log.txt", true))
                //    writer.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss.ff") + " : " + argnb + " " + Environment.GetCommandLineArgs()[0]);
                //MessageBox.Show("Nb param: " + argnb + " " + Environment.GetCommandLineArgs()[0]);
                    switch (argnb)
                    {

                        case 2:
                        // Lorsqu'on double clique sur un fichier IFZ ou qu'on l'apelle depuis une ligne de commande avec argument
                            
                            FileName = Environment.GetCommandLineArgs()[1];
                            MainForm = new Form_DisplayImage(FileName);
                            break;
                        default:
                        // Lorsqu'on lance l'exe
                            MainForm = new Form_DisplayImage();

                        break;

                    }
            }


            public static void StartForm()
            {
                Application.Run(new Form_DisplayImage(FileName));
            }
        }
    }
}
