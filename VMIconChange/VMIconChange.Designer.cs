
namespace VMIconChange
{
    partial class VMIconChange
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VMIconChange));
            this.label1 = new System.Windows.Forms.Label();
            this.b_Locate = new System.Windows.Forms.Button();
            this.b_Image = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.replaceButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openVBoxManage = new System.Windows.Forms.OpenFileDialog();
            this.openVMimage = new System.Windows.Forms.OpenFileDialog();
            this.cb_VMname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(67, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "VM\'s name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // b_Locate
            // 
            this.b_Locate.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.b_Locate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Locate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Locate.Location = new System.Drawing.Point(12, 12);
            this.b_Locate.Name = "b_Locate";
            this.b_Locate.Size = new System.Drawing.Size(203, 47);
            this.b_Locate.TabIndex = 1;
            this.b_Locate.Text = "Locate VBoxManage.exe";
            this.b_Locate.UseVisualStyleBackColor = true;
            this.b_Locate.Click += new System.EventHandler(this.b_Locate_Click);
            // 
            // b_Image
            // 
            this.b_Image.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Image.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Image.Location = new System.Drawing.Point(12, 65);
            this.b_Image.Name = "b_Image";
            this.b_Image.Size = new System.Drawing.Size(203, 44);
            this.b_Image.TabIndex = 2;
            this.b_Image.Text = "Select new VM image";
            this.b_Image.UseVisualStyleBackColor = true;
            this.b_Image.Click += new System.EventHandler(this.b_Image_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(221, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(160, 160);
            this.pictureBox.TabIndex = 4;
            this.pictureBox.TabStop = false;
            // 
            // replaceButton
            // 
            this.replaceButton.BackColor = System.Drawing.Color.Silver;
            this.replaceButton.Enabled = false;
            this.replaceButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.replaceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replaceButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replaceButton.Location = new System.Drawing.Point(12, 193);
            this.replaceButton.Name = "replaceButton";
            this.replaceButton.Size = new System.Drawing.Size(320, 49);
            this.replaceButton.TabIndex = 5;
            this.replaceButton.Text = "Replace selected VM\'s icon";
            this.replaceButton.UseVisualStyleBackColor = false;
            this.replaceButton.Click += new System.EventHandler(this.replaceButton_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(338, 193);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 49);
            this.button2.TabIndex = 6;
            this.button2.Text = "?";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openVBoxManage
            // 
            this.openVBoxManage.FileName = "VBoxManage.exe";
            this.openVBoxManage.Filter = "VBoxManage executable|VBoxManage.exe";
            this.openVBoxManage.RestoreDirectory = true;
            this.openVBoxManage.Title = "Locate VBoxManage.exe";
            // 
            // openVMimage
            // 
            this.openVMimage.FileName = "*.png";
            this.openVMimage.Filter = "PNG Files (*.png)|*.png";
            this.openVMimage.RestoreDirectory = true;
            this.openVMimage.Title = "Select your VM\'s new image (*.png)";
            // 
            // cb_VMname
            // 
            this.cb_VMname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_VMname.Enabled = false;
            this.cb_VMname.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cb_VMname.Location = new System.Drawing.Point(12, 143);
            this.cb_VMname.Name = "cb_VMname";
            this.cb_VMname.Size = new System.Drawing.Size(203, 29);
            this.cb_VMname.TabIndex = 7;
            this.cb_VMname.DropDown += new System.EventHandler(this.cb_VMname_DropDown);
            this.cb_VMname.DropDownClosed += new System.EventHandler(this.cb_VMname_DropDownClosed);
            // 
            // VMIconChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(396, 254);
            this.Controls.Add(this.cb_VMname);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.replaceButton);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.b_Image);
            this.Controls.Add(this.b_Locate);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VMIconChange";
            this.Text = "VMIconChange";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Locate;
        private System.Windows.Forms.Button b_Image;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button replaceButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openVBoxManage;
        private System.Windows.Forms.OpenFileDialog openVMimage;
        private System.Windows.Forms.ComboBox cb_VMname;
    }
}

