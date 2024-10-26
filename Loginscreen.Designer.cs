using System;
using System.Windows.Forms;

namespace FoP_Project
{
    partial class Loginscreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loginscreen));
            this.lblemail = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxpassword = new System.Windows.Forms.TextBox();
            this.picloginkey = new System.Windows.Forms.PictureBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.picbank = new System.Windows.Forms.PictureBox();
            this.lblnoaccmsg = new System.Windows.Forms.Label();
            this.lblcreateacc = new System.Windows.Forms.Label();
            this.btnadduser = new System.Windows.Forms.Button();
            this.lblsignin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnpassreset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tipaccid = new System.Windows.Forms.ToolTip(this.components);
            this.tippass = new System.Windows.Forms.ToolTip(this.components);
            this.tippassreset = new System.Windows.Forms.ToolTip(this.components);
            this.tipnewacc = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picloginkey)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblemail.Location = new System.Drawing.Point(63, 184);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(40, 17);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Email";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblpassword.Location = new System.Drawing.Point(63, 251);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(66, 17);
            this.lblpassword.TabIndex = 1;
            this.lblpassword.Text = "Password";
            // 
            // txtboxemail
            // 
            this.txtboxemail.AcceptsTab = true;
            this.txtboxemail.BackColor = System.Drawing.Color.White;
            this.txtboxemail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxemail.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxemail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxemail.Location = new System.Drawing.Point(67, 206);
            this.txtboxemail.MaxLength = 100;
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(207, 22);
            this.txtboxemail.TabIndex = 0;
            this.txtboxemail.WordWrap = false;
            this.txtboxemail.TextChanged += new System.EventHandler(this.txtboxaccountid_TextChanged);
            this.txtboxemail.MouseHover += new System.EventHandler(this.txtboxaccountid_MouseHover);
            // 
            // txtboxpassword
            // 
            this.txtboxpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxpassword.Location = new System.Drawing.Point(67, 272);
            this.txtboxpassword.MaxLength = 50;
            this.txtboxpassword.Name = "txtboxpassword";
            this.txtboxpassword.Size = new System.Drawing.Size(207, 22);
            this.txtboxpassword.TabIndex = 1;
            this.txtboxpassword.UseSystemPasswordChar = true;
            this.txtboxpassword.WordWrap = false;
            this.txtboxpassword.TextChanged += new System.EventHandler(this.txtboxpassword_TextChanged);
            this.txtboxpassword.MouseHover += new System.EventHandler(this.txtboxpassword_MouseHover);
            // 
            // picloginkey
            // 
            this.picloginkey.BackColor = System.Drawing.Color.Transparent;
            this.picloginkey.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picloginkey.Image = ((System.Drawing.Image)(resources.GetObject("picloginkey.Image")));
            this.picloginkey.Location = new System.Drawing.Point(66, 66);
            this.picloginkey.Name = "picloginkey";
            this.picloginkey.Size = new System.Drawing.Size(69, 53);
            this.picloginkey.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloginkey.TabIndex = 4;
            this.picloginkey.TabStop = false;
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleDescription = "";
            this.LoginButton.AccessibleName = "";
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginButton.Location = new System.Drawing.Point(612, 290);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(25, 39);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.UseVisualStyleBackColor = true;
            // 
            // picbank
            // 
            this.picbank.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picbank.BackColor = System.Drawing.Color.Transparent;
            this.picbank.Image = ((System.Drawing.Image)(resources.GetObject("picbank.Image")));
            this.picbank.Location = new System.Drawing.Point(416, 66);
            this.picbank.Name = "picbank";
            this.picbank.Size = new System.Drawing.Size(336, 311);
            this.picbank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbank.TabIndex = 7;
            this.picbank.TabStop = false;
            // 
            // lblnoaccmsg
            // 
            this.lblnoaccmsg.AutoSize = true;
            this.lblnoaccmsg.BackColor = System.Drawing.Color.Transparent;
            this.lblnoaccmsg.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblnoaccmsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblnoaccmsg.Location = new System.Drawing.Point(388, 452);
            this.lblnoaccmsg.Name = "lblnoaccmsg";
            this.lblnoaccmsg.Size = new System.Drawing.Size(176, 21);
            this.lblnoaccmsg.TabIndex = 9;
            this.lblnoaccmsg.Text = "Don\'t have an account?";
            this.lblnoaccmsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblcreateacc
            // 
            this.lblcreateacc.AutoSize = true;
            this.lblcreateacc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblcreateacc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblcreateacc.Location = new System.Drawing.Point(388, 473);
            this.lblcreateacc.Name = "lblcreateacc";
            this.lblcreateacc.Size = new System.Drawing.Size(201, 21);
            this.lblcreateacc.TabIndex = 10;
            this.lblcreateacc.Text = "Create one today for free!";
            // 
            // btnadduser
            // 
            this.btnadduser.BackColor = System.Drawing.Color.Transparent;
            this.btnadduser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnadduser.BackgroundImage")));
            this.btnadduser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnadduser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnadduser.FlatAppearance.BorderSize = 0;
            this.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadduser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnadduser.Location = new System.Drawing.Point(595, 432);
            this.btnadduser.Name = "btnadduser";
            this.btnadduser.Size = new System.Drawing.Size(71, 67);
            this.btnadduser.TabIndex = 4;
            this.btnadduser.UseVisualStyleBackColor = false;
            this.btnadduser.Click += new System.EventHandler(this.btnadduser_Click);
            this.btnadduser.MouseHover += new System.EventHandler(this.btnadduser_MouseHover);
            // 
            // lblsignin
            // 
            this.lblsignin.AutoSize = true;
            this.lblsignin.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblsignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsignin.Location = new System.Drawing.Point(60, 122);
            this.lblsignin.Name = "lblsignin";
            this.lblsignin.Size = new System.Drawing.Size(106, 37);
            this.lblsignin.TabIndex = 13;
            this.lblsignin.Text = "Sign-In";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(67, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 1);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(67, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 1);
            this.panel2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(62, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Forgot password?";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnlogin.Location = new System.Drawing.Point(183, 305);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(91, 42);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click_1);
            // 
            // btnpassreset
            // 
            this.btnpassreset.BackColor = System.Drawing.Color.Transparent;
            this.btnpassreset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpassreset.BackgroundImage")));
            this.btnpassreset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpassreset.FlatAppearance.BorderSize = 0;
            this.btnpassreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpassreset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnpassreset.Location = new System.Drawing.Point(229, 432);
            this.btnpassreset.Name = "btnpassreset";
            this.btnpassreset.Size = new System.Drawing.Size(65, 67);
            this.btnpassreset.TabIndex = 3;
            this.btnpassreset.UseVisualStyleBackColor = false;
            this.btnpassreset.Click += new System.EventHandler(this.btnpassreset_Click);
            this.btnpassreset.MouseHover += new System.EventHandler(this.btnpassreset_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(64, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "Reset with one click!";
            // 
            // tipaccid
            // 
            this.tipaccid.Popup += new System.Windows.Forms.PopupEventHandler(this.tipaccid_Popup);
            // 
            // Loginscreen
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(784, 581);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnpassreset);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblsignin);
            this.Controls.Add(this.btnadduser);
            this.Controls.Add(this.lblcreateacc);
            this.Controls.Add(this.lblnoaccmsg);
            this.Controls.Add(this.picbank);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.picloginkey);
            this.Controls.Add(this.txtboxpassword);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblemail);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Loginscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picloginkey)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tooltxtboxaccid_Popup(object sender, PopupEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxpassword;
        private System.Windows.Forms.PictureBox picloginkey;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.PictureBox picbank;
        private System.Windows.Forms.Label lblnoaccmsg;
        private System.Windows.Forms.Label lblcreateacc;
        private System.Windows.Forms.Button btnadduser;
        private System.Windows.Forms.Label lblsignin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private Button btnlogin;
        private Button btnpassreset;
        private Label label2;
        private ToolTip tipaccid;
        private ToolTip tippass;
        private ToolTip tippassreset;
        private ToolTip tipnewacc;
        
    }
}

