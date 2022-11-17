using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMIconChange
{
    public partial class VMIconChange : Form
    {
        private String VBMAddress, VMimage;
        private bool addressCheck, imageCheck, nameCheck;

        public VMIconChange()
        {
            InitializeComponent();
        }


        private void b_Locate_Click(object sender, EventArgs e)
        {
            if (openVBoxManage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // code here for user pressing OK instead of the 'X' or 'Cancel'
                VBMAddress = openVBoxManage.FileName;
                if (VBMAddress.EndsWith("VBoxManage.exe")) { 
                    b_Locate.BackColor = ColorTranslator.FromHtml("#87E783");
                    b_Locate.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#51982D");
                    addressCheck = true;
                    valueChange();
                } else  {
                    b_Locate.BackColor = ColorTranslator.FromHtml("#E78383");
                    b_Locate.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#982D2D");
                }
                Console.WriteLine(VBMAddress);
            }
        }

        private void replaceButton_Click(object sender, EventArgs e)
        {
            using (Process process = new Process())
            {
                process.StartInfo.FileName = VBMAddress;
                process.StartInfo.Arguments = "modifyvm \"" + VMname.Text + "\" --iconfile \"" + VMimage + "\"";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.CreateNoWindow = true;
                process.StartInfo.RedirectStandardOutput = true;
                process.Start();

                //read the standard output of vboxmanage
                StreamReader reader = process.StandardOutput;
                String output = reader.ReadToEnd();
                Console.WriteLine(output);

                if (!process.HasExited)
                {
                    process.Kill();
                }

                MessageBox.Show("VM's icon has been changed correctly.", "Change completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KosmicTeal - v1.0.0 (17/11/2022)", "About");
        }

        private void b_Image_Click(object sender, EventArgs e)
        {
            if (openVMimage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                // code here for user pressing OK instead of the 'X' or 'Cancel'
                VMimage = openVMimage.FileName;
                if (VMimage.EndsWith(".png"))
                {
                    b_Image.BackColor = ColorTranslator.FromHtml("#87E783");
                    b_Image.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#51982D");
                    pictureBox.BackgroundImage = new Bitmap(VMimage);
                    imageCheck = true;
                    valueChange();
                }
                else
                {
                    b_Image.BackColor = ColorTranslator.FromHtml("#E78383");
                    b_Image.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#982D2D");
                }
                Console.WriteLine(VMimage);
            }
        }
        private void VMname_TextChanged(object sender, EventArgs e)
        {
            if (!VMname.Text.Trim().Equals(""))
            {
                VMname.BackColor = ColorTranslator.FromHtml("#87E783");
                nameCheck = true;
                valueChange();
            }
            else
            {
                VMname.BackColor = ColorTranslator.FromHtml("#E78383");
            }
        }

        private void valueChange()
        {
            if(addressCheck && imageCheck && nameCheck)
            {
                replaceButton.Enabled = true;
                replaceButton.BackColor = ColorTranslator.FromHtml("#20a8c9");
                replaceButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#0a647a");
            }
        }
    }
}
