using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;


// VMIPCheck v1.0.1

namespace VMIPCheck
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //avoid loading the app more than once
            String currentprocess = Process.GetCurrentProcess().ProcessName;

            if (Process.GetProcesses().Count(p => p.ProcessName == currentprocess) > 1)
                return;

            

            using (Process process = new Process())
            {
                args = Environment.GetCommandLineArgs();
                String output, VMname;

                VMAppletsClass.VMAppletsCalls vmclass = new VMAppletsClass.VMAppletsCalls();

                try
                {
                    //launch vboxmanage
                    String filename = args[1] + "\\VBoxManage.exe";
                    String arguments = "guestproperty get \"" + args[2] + "\" \"/VirtualBox/GuestInfo/Net/0/V4/IP\"";

                    output = vmclass.ProcessCall(filename, arguments);
                    VMname = args[2];

                    if (output.Equals("")) { output = "VM not found or available."; } else if (args[1].Equals("about")) { output = "KosmicTeal - 2022"; }
                }
                catch (System.IndexOutOfRangeException)
                {
                    output = "Out of range, I need two arguments!";
                    VMname = "Argument Error";
                }
                catch (System.ComponentModel.Win32Exception)
                {
                    output = "VBoxManage.exe not found, check the file address argument.";
                    VMname = "Filename Error";
                }

                //get value of IP
                if (output.StartsWith("Value"))
                {
                    output = output.Substring(7);
                }

                //send a notification about the result
                vmclass.NotifyWindows(Properties.Resources.kosmicVMapp, "VMIPCheck | " + VMname, output, ToolTipIcon.Info, 60000);

                try
                {
                    //close the app once it's complete
                    System.Threading.Thread.Sleep(1000);
                    if (!process.HasExited)
                    {
                        process.Kill();
                    }
                }
                catch (System.InvalidOperationException)
                {
                    Console.WriteLine("Closing software, unable to get VBoxManage.exe");
                }
            }

        }
    }
}
