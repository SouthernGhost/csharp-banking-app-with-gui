namespace FoP_Project
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.btnsignout = new System.Windows.Forms.Button();
            this.btnchkbal = new System.Windows.Forms.Button();
            this.btndeposit = new System.Windows.Forms.Button();
            this.btnaccstat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnwithdraw = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btntransfer = new System.Windows.Forms.Button();
            this.tiprefresh = new System.Windows.Forms.ToolTip(this.components);
            this.tiplogout = new System.Windows.Forms.ToolTip(this.components);
            this.lblweluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnsignout
            // 
            this.btnsignout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnsignout.BackColor = System.Drawing.Color.Transparent;
            this.btnsignout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsignout.BackgroundImage")));
            this.btnsignout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnsignout.FlatAppearance.BorderSize = 0;
            this.btnsignout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsignout.Location = new System.Drawing.Point(740, 12);
            this.btnsignout.Name = "btnsignout";
            this.btnsignout.Size = new System.Drawing.Size(32, 27);
            this.btnsignout.TabIndex = 0;
            this.btnsignout.UseVisualStyleBackColor = false;
            this.btnsignout.Click += new System.EventHandler(this.btnlogout_Click);
            this.btnsignout.MouseHover += new System.EventHandler(this.btnsignout_MouseHover);
            // 
            // btnchkbal
            // 
            this.btnchkbal.AutoSize = true;
            this.btnchkbal.BackColor = System.Drawing.Color.Transparent;
            this.btnchkbal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnchkbal.BackgroundImage")));
            this.btnchkbal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnchkbal.FlatAppearance.BorderSize = 0;
            this.btnchkbal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnchkbal.Location = new System.Drawing.Point(158, 156);
            this.btnchkbal.Name = "btnchkbal";
            this.btnchkbal.Size = new System.Drawing.Size(98, 90);
            this.btnchkbal.TabIndex = 2;
            this.btnchkbal.UseVisualStyleBackColor = false;
            this.btnchkbal.Click += new System.EventHandler(this.btnchkbalance_Click);
            // 
            // btndeposit
            // 
            this.btndeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btndeposit.AutoSize = true;
            this.btndeposit.BackColor = System.Drawing.Color.Transparent;
            this.btndeposit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndeposit.BackgroundImage")));
            this.btndeposit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btndeposit.FlatAppearance.BorderSize = 0;
            this.btndeposit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeposit.Location = new System.Drawing.Point(348, 156);
            this.btndeposit.Name = "btndeposit";
            this.btndeposit.Size = new System.Drawing.Size(108, 90);
            this.btndeposit.TabIndex = 3;
            this.btndeposit.UseVisualStyleBackColor = false;
            this.btndeposit.Click += new System.EventHandler(this.btndeposit_Click);
            // 
            // btnaccstat
            // 
            this.btnaccstat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnaccstat.AutoSize = true;
            this.btnaccstat.BackColor = System.Drawing.Color.Transparent;
            this.btnaccstat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnaccstat.BackgroundImage")));
            this.btnaccstat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnaccstat.FlatAppearance.BorderSize = 0;
            this.btnaccstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaccstat.Location = new System.Drawing.Point(367, 325);
            this.btnaccstat.Name = "btnaccstat";
            this.btnaccstat.Size = new System.Drawing.Size(75, 90);
            this.btnaccstat.TabIndex = 4;
            this.btnaccstat.UseVisualStyleBackColor = false;
            this.btnaccstat.Click += new System.EventHandler(this.btnaccstat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Check Balance";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Deposit";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(324, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Account Statement";
            // 
            // btnwithdraw
            // 
            this.btnwithdraw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnwithdraw.AutoSize = true;
            this.btnwithdraw.BackColor = System.Drawing.Color.Transparent;
            this.btnwithdraw.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnwithdraw.BackgroundImage")));
            this.btnwithdraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnwithdraw.FlatAppearance.BorderSize = 0;
            this.btnwithdraw.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnwithdraw.Location = new System.Drawing.Point(529, 156);
            this.btnwithdraw.Name = "btnwithdraw";
            this.btnwithdraw.Size = new System.Drawing.Size(98, 90);
            this.btnwithdraw.TabIndex = 10;
            this.btnwithdraw.UseVisualStyleBackColor = false;
            this.btnwithdraw.Click += new System.EventHandler(this.btnwithdraw_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(538, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Withdraw";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(144, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Transfer Money";
            // 
            // btntransfer
            // 
            this.btntransfer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btntransfer.AutoSize = true;
            this.btntransfer.BackColor = System.Drawing.Color.Transparent;
            this.btntransfer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btntransfer.BackgroundImage")));
            this.btntransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btntransfer.FlatAppearance.BorderSize = 0;
            this.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransfer.Location = new System.Drawing.Point(158, 325);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(98, 90);
            this.btntransfer.TabIndex = 12;
            this.btntransfer.UseVisualStyleBackColor = false;
            this.btntransfer.Click += new System.EventHandler(this.btntransfer_Click);
            // 
            // lblweluser
            // 
            this.lblweluser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblweluser.AutoSize = true;
            this.lblweluser.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold);
            this.lblweluser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblweluser.Location = new System.Drawing.Point(160, 47);
            this.lblweluser.Name = "lblweluser";
            this.lblweluser.Size = new System.Drawing.Size(0, 37);
            this.lblweluser.TabIndex = 47;
            this.lblweluser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblweluser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btntransfer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnwithdraw);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnaccstat);
            this.Controls.Add(this.btndeposit);
            this.Controls.Add(this.btnchkbal);
            this.Controls.Add(this.btnsignout);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnchkbal;
        private System.Windows.Forms.Button btndeposit;
        private System.Windows.Forms.Button btnaccstat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnwithdraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsignout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btntransfer;
        private System.Windows.Forms.ToolTip tiprefresh;
        private System.Windows.Forms.ToolTip tiplogout;
        private System.Windows.Forms.Label lblweluser;
    }
}