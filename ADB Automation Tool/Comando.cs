using SharpAdbClient;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace ADB_Automation_Tool
{
    class Comando
    {
        AdbServer server;
        String pluginsFolder = "Plugins";

        public void Iniciar()
        {
            if (server == null)
            {
                server = new AdbServer();
                var result = server.StartServer(this.getPath() + "adb.exe", restartServerIfNewer: false);
                server.RestartServer();
            }
        }

        private String getPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }

        public string Argumentos(String argumento)
        {
                var device = AdbClient.Instance.GetDevices().First();
                var receiver = new ConsoleOutputReceiver();

                AdbClient.Instance.ExecuteRemoteCommand(argumento, device, receiver);

                return receiver.ToString();
        }


        public String[] plugins()
        {
            Directory.CreateDirectory(pluginsFolder);
            string[] files = Directory.GetFiles(this.getPath()+pluginsFolder);
            return files;
            /*foreach (string file in files)
            {
            comboBox1.Items.AddRange(Directory.GetFiles(@"C:\\"));
                comboBox1.Items.AddRange(files);
            }
            */
        }

    }
}
