using SharpAdbClient;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ADB_Automation_Tool
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Comando consola = new Comando();
            consola.Iniciar();
            Application.Run(new Form1());            
        }
    }
}
