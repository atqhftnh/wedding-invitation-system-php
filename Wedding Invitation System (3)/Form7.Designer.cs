namespace Wedding_Invitation_System
{
    partial class Form7
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
            System.Windows.Forms.Label label2;
            this.label8 = new System.Windows.Forms.Label();
            this.dgvInvite = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.LightSteelBlue;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(-2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(916, 46);
            label2.TabIndex = 44;
            label2.Text = "Invitation System : View Client";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-103, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 365);
            this.label8.TabIndex = 22;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvInvite
            // 
            this.dgvInvite.AllowUserToAddRows = false;
            this.dgvInvite.AllowUserToDeleteRows = false;
            this.dgvInvite.AllowUserToResizeColumns = false;
            this.dgvInvite.AllowUserToResizeRows = false;
            this.dgvInvite.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvInvite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInvite.ColumnHeadersHeight = 30;
            this.dgvInvite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInvite.Location = new System.Drawing.Point(-52, 67);
            this.dgvInvite.Name = "dgvInvite";
            this.dgvInvite.ReadOnly = true;
            this.dgvInvite.RowHeadersWidth = 51;
            this.dgvInvite.RowTemplate.Height = 24;
            this.dgvInvite.Size = new System.Drawing.Size(908, 334);
            this.dgvInvite.TabIndex = 21;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(358, 414);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 32);
            this.btnBack.TabIndex = 45;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 458);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvInvite);
            this.Name = "Form7";
            this.Text = "Client List";
            this.Load += new System.EventHandler(this.Form7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvInvite;
        private System.Windows.Forms.Button btnBack;
    }
}