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
            string pythonPath = @"C:\Program Files (x86)\Python\Python37-32\python.exe";

            ProcessStartInfo pySkript = new ProcessStartInfo();
            pySkript.WorkingDirectory = @"D:\GitRepos\CallPythonByCSharp\FibonacciCalculator\";
            pySkript.FileName = pythonPath;
            pySkript.Arguments = string.Format("{0} {1}",myPythonApp, 1000);
            pySkript.UseShellExecute = false;
            pySkript.RedirectStandardOutput = true;

            System.Console.WriteLine("Start python programm!");

            using (Process process = Process.Start(pySkript))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    System.Console.Write(result);
                }
            }
            System.Console.ReadKey();
        }
    }
}
