namespace Wedding_Invitation_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIC = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRLog = new System.Windows.Forms.Button();
            this.lblGoAdmin = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to WIS";
            // 
            // txtIC
            // 
            this.txtIC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIC.Location = new System.Drawing.Point(407, 147);
            this.txtIC.Name = "txtIC";
            this.txtIC.Size = new System.Drawing.Size(229, 30);
            this.txtIC.TabIndex = 5;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(407, 193);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(229, 30);
            this.txtPass.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(290, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Client IC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(290, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // btnRLog
            // 
            this.btnRLog.AutoSize = true;
            this.btnRLog.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnRLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRLog.Location = new System.Drawing.Point(415, 259);
            this.btnRLog.Name = "btnRLog";
            this.btnRLog.Size = new System.Drawing.Size(117, 32);
            this.btnRLog.TabIndex = 9;
            this.btnRLog.Text = "Log In";
            this.btnRLog.UseVisualStyleBackColor = false;
            this.btnRLog.Click += new System.EventHandler(this.btnRLog_Click);
            // 
            // lblGoAdmin
            // 
            this.lblGoAdmin.AutoSize = true;
            this.lblGoAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoAdmin.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoAdmin.ForeColor = System.Drawing.Color.Blue;
            this.lblGoAdmin.Location = new System.Drawing.Point(418, 316);
            this.lblGoAdmin.Name = "lblGoAdmin";
            this.lblGoAdmin.Size = new System.Drawing.Size(102, 19);
            this.lblGoAdmin.TabIndex = 10;
            this.lblGoAdmin.Text = "Admin Log In";
            this.lblGoAdmin.Click += new System.EventHandler(this.lblGoAdmin_Click);
            this.lblGoAdmin.MouseLeave += new System.EventHandler(this.lblGoAdmin_MouseLeave);
            this.lblGoAdmin.MouseHover += new System.EventHandler(this.lblGoAdmin_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Script", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(289, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 27);
            this.label5.TabIndex = 11;
            this.label5.Text = "A Perfect Plan For Your Special Day";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wedding_Invitation_System.Properties.Resources.img1;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 356);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 353);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGoAdmin);
            this.Controls.Add(this.btnRLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtIC);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtIC;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRLog;
        private System.Windows.Forms.Label lblGoAdmin;
        private System.Windows.Forms.Label label5;
    }
}

