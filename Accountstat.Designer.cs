namespace FoP_Project
{
    partial class Accountstat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accountstat));
            this.label2 = new System.Windows.Forms.Label();
            this.btnemail = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnviewstat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Email Statement";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnemail
            // 
            this.btnemail.AutoSize = true;
            this.btnemail.BackColor = System.Drawing.Color.Transparent;
            this.btnemail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnemail.BackgroundImage")));
            this.btnemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnemail.FlatAppearance.BorderSize = 0;
            this.btnemail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnemail.Location = new System.Drawing.Point(130, 119);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(98, 90);
            this.btnemail.TabIndex = 8;
            this.btnemail.UseVisualStyleBackColor = false;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(323, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "View Statement";
            // 
            // btnviewstat
            // 
            this.btnviewstat.AutoSize = true;
            this.btnviewstat.BackColor = System.Drawing.Color.Transparent;
            this.btnviewstat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnviewstat.BackgroundImage")));
            this.btnviewstat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnviewstat.FlatAppearance.BorderSize = 0;
            this.btnviewstat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnviewstat.Location = new System.Drawing.Point(327, 119);
            this.btnviewstat.Name = "btnviewstat";
            this.btnviewstat.Size = new System.Drawing.Size(98, 90);
            this.btnviewstat.TabIndex = 10;
            this.btnviewstat.UseVisualStyleBackColor = false;
            this.btnviewstat.Click += new System.EventHandler(this.btnviewstat_Click);
            // 
            // Accountstat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 382);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnviewstat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnemail);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Accountstat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Statement";
            this.Load += new System.EventHandler(this.Accountstat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnviewstat;
    }
}