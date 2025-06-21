namespace Wedding_Invitation_System
{
    partial class Form2
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
            this.lblGoGuest = new System.Windows.Forms.Label();
            this.btnALog = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAPass = new System.Windows.Forms.TextBox();
            this.txtAName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGoGuest
            // 
            this.lblGoGuest.AutoSize = true;
            this.lblGoGuest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblGoGuest.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoGuest.ForeColor = System.Drawing.Color.Blue;
            this.lblGoGuest.Location = new System.Drawing.Point(186, 286);
            this.lblGoGuest.Name = "lblGoGuest";
            this.lblGoGuest.Size = new System.Drawing.Size(178, 19);
            this.lblGoGuest.TabIndex = 16;
            this.lblGoGuest.Text = "Go Back to Guest Log In";
            this.lblGoGuest.Click += new System.EventHandler(this.lblGoGuest_Click);
            this.lblGoGuest.MouseLeave += new System.EventHandler(this.lblGoGuest_MouseLeave);
            this.lblGoGuest.MouseHover += new System.EventHandler(this.lblGoGuest_MouseHover);
            // 
            // btnALog
            // 
            this.btnALog.AutoSize = true;
            this.btnALog.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnALog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnALog.Location = new System.Drawing.Point(219, 223);
            this.btnALog.Name = "btnALog";
            this.btnALog.Size = new System.Drawing.Size(117, 32);
            this.btnALog.TabIndex = 15;
            this.btnALog.Text = "Log In";
            this.btnALog.UseVisualStyleBackColor = false;
            this.btnALog.Click += new System.EventHandler(this.btnALog_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 22);
            this.label3.TabIndex = 14;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Admin Username";
            // 
            // txtAPass
            // 
            this.txtAPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAPass.Location = new System.Drawing.Point(219, 157);
            this.txtAPass.Name = "txtAPass";
            this.txtAPass.Size = new System.Drawing.Size(229, 30);
            this.txtAPass.TabIndex = 12;
            // 
            // txtAName
            // 
            this.txtAName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAName.Location = new System.Drawing.Point(219, 111);
            this.txtAName.Name = "txtAName";
            this.txtAName.Size = new System.Drawing.Size(229, 30);
            this.txtAName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 31.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(96, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 64);
            this.label1.TabIndex = 17;
            this.label1.Text = "Welcome Back";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 326);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGoGuest);
            this.Controls.Add(this.btnALog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAPass);
            this.Controls.Add(this.txtAName);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGoGuest;
        private System.Windows.Forms.Button btnALog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAPass;
        private System.Windows.Forms.TextBox txtAName;
        private System.Windows.Forms.Label label1;
    }
}