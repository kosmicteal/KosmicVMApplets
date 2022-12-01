using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VMAppletsClass
{
    public class VMAppletsCalls
    {

        public string ProcessCall(string FileName, string Arguments)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = FileName;
                process.StartInfo.Arguments = Arguments;
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                //read the standard output of vboxmanage
                StreamReader reader = process.StandardOutput;
                String output = reader.ReadToEnd();

                if (!process.HasExited)
                {
                    process.Kill();
                }

                return output;
            }
        }
    }
}
