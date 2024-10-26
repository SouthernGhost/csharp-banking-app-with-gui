namespace FoP_Project
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtboxwithdraw = new System.Windows.Forms.TextBox();
            this.lblwithdraw = new System.Windows.Forms.Label();
            this.lblcredits = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtboxseckey = new System.Windows.Forms.TextBox();
            this.lblsecuritykey = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 52;
            this.pictureBox1.TabStop = false;
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnwithdraw.Location = new System.Drawing.Point(387, 320);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(71, 38);
            this.btnwithdraw.TabIndex = 2;
            this.btnwithdraw.Text = "OK";
            this.btnwithdraw.UseVisualStyleBackColor = true;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // btncancel
            // 
            this.btncancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.FlatAppearance.BorderSize = 2;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btncancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btncancel.Location = new System.Drawing.Point(474, 320);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(71, 38);
            this.btncancel.TabIndex = 3;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(32, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 1);
            this.panel1.TabIndex = 48;
            // 
            // txtboxwithdraw
            // 
            this.txtboxwithdraw.BackColor = System.Drawing.Color.White;
            this.txtboxwithdraw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxwithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxwithdraw.Location = new System.Drawing.Point(32, 134);
            this.txtboxwithdraw.MaxLength = 20000;
            this.txtboxwithdraw.Name = "txtboxwithdraw";
            this.txtboxwithdraw.Size = new System.Drawing.Size(171, 22);
            this.txtboxwithdraw.TabIndex = 0;
            this.txtboxwithdraw.TextChanged += new System.EventHandler(this.txtboxwithdraw_TextChanged);
            // 
            // lblwithdraw
            // 
            this.lblwithdraw.AutoSize = true;
            this.lblwithdraw.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblwithdraw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblwithdraw.Location = new System.Drawing.Point(23, 20);
            this.lblwithdraw.Name = "lblwithdraw";
            this.lblwithdraw.Size = new System.Drawing.Size(349, 37);
            this.lblwithdraw.TabIndex = 46;
            this.lblwithdraw.Text = "Enter Amount To Withdraw";
            this.lblwithdraw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcredits
            // 
            this.lblcredits.AutoSize = true;
            this.lblcredits.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblcredits.Location = new System.Drawing.Point(209, 138);
            this.lblcredits.Name = "lblcredits";
            this.lblcredits.Size = new System.Drawing.Size(62, 21);
            this.lblcredits.TabIndex = 53;
            this.lblcredits.Text = "Credits";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Location = new System.Drawing.Point(32, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 1);
            this.panel3.TabIndex = 76;
            // 
            // txtboxseckey
            // 
            this.txtboxseckey.BackColor = System.Drawing.Color.White;
            this.txtboxseckey.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxseckey.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxseckey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtboxseckey.Location = new System.Drawing.Point(32, 206);
            this.txtboxseckey.MaxLength = 8;
            this.txtboxseckey.Name = "txtboxseckey";
            this.txtboxseckey.Size = new System.Drawing.Size(171, 22);
            this.txtboxseckey.TabIndex = 1;
            this.txtboxseckey.UseSystemPasswordChar = true;
            this.txtboxseckey.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblsecuritykey
            // 
            this.lblsecuritykey.AutoSize = true;
            this.lblsecuritykey.BackColor = System.Drawing.Color.Transparent;
            this.lblsecuritykey.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lblsecuritykey.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblsecuritykey.Location = new System.Drawing.Point(27, 178);
            this.lblsecuritykey.Name = "lblsecuritykey";
            this.lblsecuritykey.Size = new System.Drawing.Size(179, 21);
            this.lblsecuritykey.TabIndex = 74;
            this.lblsecuritykey.Text = "Enter Your Security Key";
            // 
            // Withdraw
            // 
            this.AcceptButton = this.btnwithdraw;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtboxseckey);
            this.Controls.Add(this.lblsecuritykey);
            this.Controls.Add(this.lblcredits);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtboxwithdraw);
            this.Controls.Add(this.lblwithdraw);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtboxwithdraw;
        private System.Windows.Forms.Label lblwithdraw;
        private System.Windows.Forms.Label lblcredits;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtboxseckey;
        private System.Windows.Forms.Label lblsecuritykey;
    }
}