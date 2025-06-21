namespace Wedding_Invitation_System
{
    partial class Form12
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
            this.lblWedID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxClientList = new System.Windows.Forms.ComboBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dgvInvite = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.LightSteelBlue;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(-1, -2);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(799, 46);
            label2.TabIndex = 59;
            label2.Text = "Invitation System : Multiple Remove Invitee";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWedID
            // 
            this.lblWedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWedID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedID.Location = new System.Drawing.Point(419, 120);
            this.lblWedID.Name = "lblWedID";
            this.lblWedID.Size = new System.Drawing.Size(142, 27);
            this.lblWedID.TabIndex = 58;
            this.lblWedID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(318, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 57;
            this.label9.Text = "Wedding ID";
            // 
            // lblClientName
            // 
            this.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(419, 73);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(348, 27);
            this.lblClientName.TabIndex = 56;
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(318, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "Client Name";
            // 
            // cbxTable
            // 
            this.cbxTable.DropDownHeight = 90;
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.IntegralHeight = false;
            this.cbxTable.Location = new System.Drawing.Point(115, 121);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(106, 27);
            this.cbxTable.TabIndex = 53;
            this.cbxTable.SelectedIndexChanged += new System.EventHandler(this.cbxTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 52;
            this.label1.Text = "Client ID";
            // 
            // cbxClientList
            // 
            this.cbxClientList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClientList.FormattingEnabled = true;
            this.cbxClientList.Location = new System.Drawing.Point(114, 73);
            this.cbxClientList.Name = "cbxClientList";
            this.cbxClientList.Size = new System.Drawing.Size(183, 27);
            this.cbxClientList.TabIndex = 51;
            this.cbxClientList.SelectedIndexChanged += new System.EventHandler(this.cbxClientList_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(646, 532);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(104, 32);
            this.btnRemove.TabIndex = 50;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(522, 532);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 32);
            this.btnBack.TabIndex = 49;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            this.dgvInvite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.c4,
            this.c5});
            this.dgvInvite.Location = new System.Drawing.Point(-33, 178);
            this.dgvInvite.Name = "dgvInvite";
            this.dgvInvite.ReadOnly = true;
            this.dgvInvite.RowHeadersWidth = 51;
            this.dgvInvite.RowTemplate.Height = 24;
            this.dgvInvite.Size = new System.Drawing.Size(800, 334);
            this.dgvInvite.TabIndex = 48;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-85, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 365);
            this.label8.TabIndex = 65;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // c1
            // 
            this.c1.HeaderText = "Guest ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 85;
            // 
            // c2
            // 
            this.c2.HeaderText = "Guest Name";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Width = 233;
            // 
            // c3
            // 
            this.c3.HeaderText = "Phone Number";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            // 
            // c4
            // 
            this.c4.HeaderText = "Relationship";
            this.c4.MinimumWidth = 6;
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Width = 80;
            // 
            // c5
            // 
            this.c5.HeaderText = "Select";
            this.c5.MinimumWidth = 6;
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Width = 50;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 576);
            this.Controls.Add(this.label8);
            this.Controls.Add(label2);
            this.Controls.Add(this.lblWedID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTable);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClientList);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvInvite);
            this.Name = "Form12";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form12";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWedID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxClientList;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dgvInvite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn c5;
    }
}