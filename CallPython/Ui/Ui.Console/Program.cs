using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.x53olution.CallPython.Ui.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string myPythonApp = "main.py";

            string pythonPath = "Program Files (x86)/Python/Python37-32/python.exe";

            



            ProcessStartInfo pySkript = new ProcessStartInfo();

            pySkript.WorkingDirectory = @"%%";

            pySkript.FileName = @"";

            pySkript.Arguments = string.Format("{0} {1}", pythonPath, myPythonApp);

            pySkript.UseShellExecute = false;

            pySkript.RedirectStandardOutput = true;



            using (Process process = Process.Start(pySkript))

            {

                using (StreamReader reader = process.StandardOutput)

                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }

            }
        }
    }
}
