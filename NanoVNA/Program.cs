using System;
using System.Drawing;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace NanoVNA
{
    internal static class Program
    {
        [STAThread]
        [SupportedOSPlatform("windows")]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: false);
            Application.SetDefaultFont(new Font(new FontFamily("Segoe UI"), 8f));

            MainForm mainForm = new MainForm
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            new IController(mainForm);

            Application.Run(mainForm);
        }
    }
}
