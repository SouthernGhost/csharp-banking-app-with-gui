namespace FoP_Project
{
    partial class Passreset
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Passreset));
            this.btnpassreset = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxseckey = new System.Windows.Forms.TextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.lblsecuritykey = new System.Windows.Forms.Label();
            this.lblaccountid = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtboxnewpass = new System.Windows.Forms.TextBox();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblpassresetdetails = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.Location = new System.Drawing.Point(421, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(198, 220);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // btnpassreset
            // 
            this.btnpassreset.BackColor = System.Drawing.Color.Transparent;
            this.btnpassreset.FlatAppearance.BorderSize = 2;
            this.btnpassreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpassreset.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpassreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpassreset.Location = new System.Drawing.Point(45, 309);
            this.btnpassreset.Name = "btnpassreset";
            this.btnpassreset.Size = new System.Drawing.Size(91, 42);
            this.btnpassreset.TabIndex = 3;
            this.btnpassreset.Text = "Reset";
            this.btnpassreset.UseVisualStyleBackColor = false;
            this.btnpassreset.Click += new System.EventHandler(this.btnpassreset_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(45, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 1);
            this.panel2.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(45, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 1);
            this.panel1.TabIndex = 31;
            // 
            // txtboxseckey
            // 
            this.txtboxseckey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxseckey.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxseckey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxseckey.Location = new System.Drawing.Point(45, 195);
            this.txtboxseckey.MaxLength = 8;
            this.txtboxseckey.Name = "txtboxseckey";
            this.txtboxseckey.Size = new System.Drawing.Size(207, 22);
            this.txtboxseckey.TabIndex = 1;
            this.txtboxseckey.UseSystemPasswordChar = true;
            this.txtboxseckey.WordWrap = false;
            // 
            // txtboxemail
            // 
            this.txtboxemail.AcceptsTab = true;
            this.txtboxemail.BackColor = System.Drawing.Color.White;
            this.txtboxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxemail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxemail.Location = new System.Drawing.Point(45, 129);
            this.txtboxemail.MaxLength = 100;
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(207, 22);
            this.txtboxemail.TabIndex = 0;
            this.txtboxemail.WordWrap = false;
            // 
            // lblsecuritykey
            // 
            this.lblsecuritykey.AutoSize = true;
            this.lblsecuritykey.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblsecuritykey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsecuritykey.Location = new System.Drawing.Point(41, 174);
            this.lblsecuritykey.Name = "lblsecuritykey";
            this.lblsecuritykey.Size = new System.Drawing.Size(167, 17);
            this.lblsecuritykey.TabIndex = 28;
            this.lblsecuritykey.Text = "Security Key (8 characters)";
            // 
            // lblaccountid
            // 
            this.lblaccountid.AutoSize = true;
            this.lblaccountid.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblaccountid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblaccountid.Location = new System.Drawing.Point(41, 107);
            this.lblaccountid.Name = "lblaccountid";
            this.lblaccountid.Size = new System.Drawing.Size(40, 17);
            this.lblaccountid.TabIndex = 27;
            this.lblaccountid.Text = "Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(45, 288);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(207, 1);
            this.panel3.TabIndex = 36;
            // 
            // txtboxnewpass
            // 
            this.txtboxnewpass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxnewpass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxnewpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxnewpass.Location = new System.Drawing.Point(45, 264);
            this.txtboxnewpass.MaxLength = 50;
            this.txtboxnewpass.Name = "txtboxnewpass";
            this.txtboxnewpass.Size = new System.Drawing.Size(207, 22);
            this.txtboxnewpass.TabIndex = 2;
            this.txtboxnewpass.UseSystemPasswordChar = true;
            this.txtboxnewpass.WordWrap = false;
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpassword.Location = new System.Drawing.Point(41, 240);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(260, 17);
            this.lblpassword.TabIndex = 34;
            this.lblpassword.Text = "New Password (Max 50 characters, Min 6)";
            // 
            // lblpassresetdetails
            // 
            this.lblpassresetdetails.AutoSize = true;
            this.lblpassresetdetails.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblpassresetdetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpassresetdetails.Location = new System.Drawing.Point(37, 44);
            this.lblpassresetdetails.Name = "lblpassresetdetails";
            this.lblpassresetdetails.Size = new System.Drawing.Size(401, 37);
            this.lblpassresetdetails.TabIndex = 37;
            this.lblpassresetdetails.Text = "Enter Details To Reset Password";
            this.lblpassresetdetails.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.FlatAppearance.BorderSize = 2;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.Location = new System.Drawing.Point(161, 309);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(91, 42);
            this.btncancel.TabIndex = 4;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // Passreset
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 432);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.lblpassresetdetails);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtboxnewpass);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.btnpassreset);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxseckey);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.lblsecuritykey);
            this.Controls.Add(this.lblaccountid);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Passreset";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reset Password";
            this.Load += new System.EventHandler(this.Passwordreset_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnpassreset;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxseckey;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.Label lblsecuritykey;
        private System.Windows.Forms.Label lblaccountid;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxnewpass;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblpassresetdetails;
        private System.Windows.Forms.Button btncancel;
    }
}