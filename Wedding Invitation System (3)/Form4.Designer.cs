namespace Wedding_Invitation_System
{
    partial class Form4
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
            System.Windows.Forms.Label label1;
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddInvite = new System.Windows.Forms.Button();
            this.btnUpdateInvite = new System.Windows.Forms.Button();
            this.btnRemoveInvite = new System.Windows.Forms.Button();
            this.btnViewInvite = new System.Windows.Forms.Button();
            this.lblLogOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewClient = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = System.Drawing.Color.LightSteelBlue;
            label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label1.Location = new System.Drawing.Point(-13, -3);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(846, 46);
            label1.TabIndex = 4;
            label1.Text = "Administration Main Page";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClient.Location = new System.Drawing.Point(33, 65);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(160, 42);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "New Client";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddInvite
            // 
            this.btnAddInvite.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddInvite.Location = new System.Drawing.Point(33, 190);
            this.btnAddInvite.Name = "btnAddInvite";
            this.btnAddInvite.Size = new System.Drawing.Size(160, 42);
            this.btnAddInvite.TabIndex = 1;
            this.btnAddInvite.Text = "Add Invitee";
            this.btnAddInvite.UseVisualStyleBackColor = true;
            this.btnAddInvite.Click += new System.EventHandler(this.btnAddInvite_Click);
            // 
            // btnUpdateInvite
            // 
            this.btnUpdateInvite.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateInvite.Location = new System.Drawing.Point(33, 241);
            this.btnUpdateInvite.Name = "btnUpdateInvite";
            this.btnUpdateInvite.Size = new System.Drawing.Size(160, 42);
            this.btnUpdateInvite.TabIndex = 2;
            this.btnUpdateInvite.Text = "Update Invitee";
            this.btnUpdateInvite.UseVisualStyleBackColor = true;
            this.btnUpdateInvite.Click += new System.EventHandler(this.btnUpdateInvite_Click);
            // 
            // btnRemoveInvite
            // 
            this.btnRemoveInvite.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveInvite.Location = new System.Drawing.Point(33, 292);
            this.btnRemoveInvite.Name = "btnRemoveInvite";
            this.btnRemoveInvite.Size = new System.Drawing.Size(160, 42);
            this.btnRemoveInvite.TabIndex = 3;
            this.btnRemoveInvite.Text = "Remove Invitee";
            this.btnRemoveInvite.UseVisualStyleBackColor = true;
            this.btnRemoveInvite.Click += new System.EventHandler(this.btnRemoveInvite_Click);
            // 
            // btnViewInvite
            // 
            this.btnViewInvite.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewInvite.Location = new System.Drawing.Point(33, 343);
            this.btnViewInvite.Name = "btnViewInvite";
            this.btnViewInvite.Size = new System.Drawing.Size(160, 42);
            this.btnViewInvite.TabIndex = 6;
            this.btnViewInvite.Text = "View Invitation";
            this.btnViewInvite.UseVisualStyleBackColor = true;
            this.btnViewInvite.Click += new System.EventHandler(this.btnViewInvite_Click);
            // 
            // lblLogOut
            // 
            this.lblLogOut.AutoSize = true;
            this.lblLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogOut.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogOut.ForeColor = System.Drawing.Color.Blue;
            this.lblLogOut.Location = new System.Drawing.Point(81, 401);
            this.lblLogOut.Name = "lblLogOut";
            this.lblLogOut.Size = new System.Drawing.Size(65, 19);
            this.lblLogOut.TabIndex = 7;
            this.lblLogOut.Text = "Log Out";
            this.lblLogOut.Click += new System.EventHandler(this.lblLogOut_Click);
            this.lblLogOut.MouseLeave += new System.EventHandler(this.lblLogOut_MouseLeave);
            this.lblLogOut.MouseHover += new System.EventHandler(this.lblLogOut_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wedding_Invitation_System.Properties.Resources.img5;
            this.pictureBox1.Location = new System.Drawing.Point(233, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(614, 479);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewClient
            // 
            this.btnViewClient.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewClient.Location = new System.Drawing.Point(33, 116);
            this.btnViewClient.Name = "btnViewClient";
            this.btnViewClient.Size = new System.Drawing.Size(160, 42);
            this.btnViewClient.TabIndex = 8;
            this.btnViewClient.Text = "View Client";
            this.btnViewClient.UseVisualStyleBackColor = true;
            this.btnViewClient.Click += new System.EventHandler(this.btnViewClient_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 439);
            this.Controls.Add(this.btnViewClient);
            this.Controls.Add(this.lblLogOut);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnViewInvite);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRemoveInvite);
            this.Controls.Add(this.btnUpdateInvite);
            this.Controls.Add(this.btnAddInvite);
            this.Controls.Add(this.btnAddClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddInvite;
        private System.Windows.Forms.Button btnUpdateInvite;
        private System.Windows.Forms.Button btnRemoveInvite;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnViewInvite;
        private System.Windows.Forms.Label lblLogOut;
        private System.Windows.Forms.Button btnViewClient;
    }
}