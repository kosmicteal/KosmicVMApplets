using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VMIconChange
{
    public partial class VMIconChange : Form
    {
        private String VBMAddress, VMimage;
        private bool addressCheck, imageCheck;

        public VMIconChange()
        {
            InitializeComponent();
        }


        private void b_Locate_Click(object sender, EventArgs e)
        {
            if (openVBoxManage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VBMAddress = openVBoxManage.FileName;

                if (VBMAddress.EndsWith("VBoxManage.exe"))
                {

                    b_Locate.BackColor = ColorTranslator.FromHtml("#87E783");
                    b_Locate.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#51982D");
                    addressCheck = true;
                    valueChange();

                    using (Process process = new Process())
                    {
                        VMAppletsClass.VMAppletsCalls vmclass = new VMAppletsClass.VMAppletsCalls();
                        String output = vmclass.ProcessCall(VBMAddress, "list vms");

                        Regex regex = new Regex("\"(.*?)\"");
                        var listVMs = regex.Matches(output);

                        for (int i = 0; i < listVMs.Count; i++)
                        {
                            cb_VMname.Items.Add(listVMs[i].Value.Trim('"'));
                        }

                    }

                }
                else
                {
                    b_Locate.BackColor = ColorTranslator.FromHtml("#E78383");
                    b_Locate.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#982D2D");
                }

                Console.WriteLine(VBMAddress);
            }
        }

        private void b_Image_Click(object sender, EventArgs e)
        {
            if (openVMimage.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                VMimage = openVMimage.FileName;

                if (VMimage.EndsWith(".png"))
                {
                    b_Image.BackColor = ColorTranslator.FromHtml("#87E783");
                    b_Image.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#51982D");
                    pictureBox.BackgroundImage = new Bitmap(VMimage);
                    imageCheck = true;
                    cb_VMname.Enabled = true;
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

        private void replaceButton_Click(object sender, EventArgs e)
        {
            String arguments = "modifyvm \"" + cb_VMname.Text + "\" --iconfile \"" + VMimage + "\"";

            VMAppletsClass.VMAppletsCalls vmclass = new VMAppletsClass.VMAppletsCalls();
            _ = vmclass.ProcessCall(VBMAddress, arguments);

            MessageBox.Show("VM's icon has been changed correctly.", "Change completed", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("KosmicTeal - v1.0.0 (17/11/2022)", "About");
        }


        private void cb_VMname_DropDownClosed(object sender, EventArgs e)
        {
            valueChange();
        }


        //------------------------------------------Value Check Calls

        private void valueChange()
        {
            if (addressCheck && imageCheck && cb_VMname.SelectedIndex != -1)
            {
                replaceButton.Enabled = true;
                replaceButton.BackColor = ColorTranslator.FromHtml("#20a8c9");
                replaceButton.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#0a647a");
            }
        }

        //------------------------------------------UI dynamic changes
        private void cb_VMname_DropDown(object sender, EventArgs e)
        {
            //code from: https://www.codeproject.com/Articles/5801/Adjust-combo-box-drop-down-list-width-to-longest-s
            ComboBox senderComboBox = (ComboBox)sender;
            int width = senderComboBox.DropDownWidth;
            Graphics g = senderComboBox.CreateGraphics();
            Font font = senderComboBox.Font;
            int vertScrollBarWidth =
                (senderComboBox.Items.Count > senderComboBox.MaxDropDownItems)
                ? SystemInformation.VerticalScrollBarWidth : 0;

            int newWidth;
            foreach (string s in ((ComboBox)sender).Items)
            {
                newWidth = (int)g.MeasureString(s, font).Width
                    + vertScrollBarWidth;
                if (width < newWidth)
                {
                    width = newWidth;
                }
            }
            senderComboBox.DropDownWidth = width;
        }

    }
}
