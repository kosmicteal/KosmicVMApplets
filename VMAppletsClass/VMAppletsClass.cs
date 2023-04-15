using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public void NotifyWindows(System.Drawing.Icon icon, string title, string text, ToolTipIcon balloonicon, int time)
        {
            //send a notification about the result
            NotifyIcon notifyIcon1 = new NotifyIcon();
            notifyIcon1.Icon = icon;
            notifyIcon1.BalloonTipTitle = title;
            notifyIcon1.BalloonTipText = text;
            notifyIcon1.BalloonTipIcon = balloonicon;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(time);

        }
    }

}
