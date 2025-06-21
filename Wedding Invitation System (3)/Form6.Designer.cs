namespace Wedding_Invitation_System
{
    partial class Form6
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
            this.cbxClientList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxTable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.dgvAddInvite = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGuestName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGuestPhone = new System.Windows.Forms.TextBox();
            this.lblWedID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxGuestRelay = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddInvite)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.Color.LightSteelBlue;
            label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            label2.Location = new System.Drawing.Point(-11, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(824, 46);
            label2.TabIndex = 5;
            label2.Text = "Invitation System : Add Invitee";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxClientList
            // 
            this.cbxClientList.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxClientList.FormattingEnabled = true;
            this.cbxClientList.Location = new System.Drawing.Point(96, 78);
            this.cbxClientList.Name = "cbxClientList";
            this.cbxClientList.Size = new System.Drawing.Size(183, 27);
            this.cbxClientList.TabIndex = 0;
            this.cbxClientList.SelectedIndexChanged += new System.EventHandler(this.cbxClientList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client ID";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(534, 587);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 32);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(644, 587);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 32);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Client Name";
            // 
            // cbxTable
            // 
            this.cbxTable.DropDownHeight = 90;
            this.cbxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTable.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTable.FormattingEnabled = true;
            this.cbxTable.IntegralHeight = false;
            this.cbxTable.Location = new System.Drawing.Point(97, 126);
            this.cbxTable.Name = "cbxTable";
            this.cbxTable.Size = new System.Drawing.Size(106, 27);
            this.cbxTable.TabIndex = 6;
            this.cbxTable.SelectedIndexChanged += new System.EventHandler(this.cbxTable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table";
            // 
            // lblClientName
            // 
            this.lblClientName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblClientName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(401, 78);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(387, 27);
            this.lblClientName.TabIndex = 9;
            this.lblClientName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvAddInvite
            // 
            this.dgvAddInvite.AllowUserToAddRows = false;
            this.dgvAddInvite.AllowUserToDeleteRows = false;
            this.dgvAddInvite.AllowUserToResizeColumns = false;
            this.dgvAddInvite.AllowUserToResizeRows = false;
            this.dgvAddInvite.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvAddInvite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddInvite.ColumnHeadersHeight = 30;
            this.dgvAddInvite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAddInvite.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c2,
            this.c3,
            this.C4});
            this.dgvAddInvite.Location = new System.Drawing.Point(-16, 247);
            this.dgvAddInvite.Name = "dgvAddInvite";
            this.dgvAddInvite.ReadOnly = true;
            this.dgvAddInvite.RowHeadersWidth = 51;
            this.dgvAddInvite.RowTemplate.Height = 24;
            this.dgvAddInvite.Size = new System.Drawing.Size(777, 334);
            this.dgvAddInvite.TabIndex = 10;
            // 
            // c1
            // 
            this.c1.HeaderText = "Guest ID";
            this.c1.MinimumWidth = 6;
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c1.Width = 80;
            // 
            // c2
            // 
            this.c2.HeaderText = "Guest Name";
            this.c2.MinimumWidth = 6;
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c2.Width = 230;
            // 
            // c3
            // 
            this.c3.HeaderText = "Phone Number";
            this.c3.MinimumWidth = 6;
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.c3.Width = 110;
            // 
            // C4
            // 
            this.C4.HeaderText = "Relationship";
            this.C4.MinimumWidth = 6;
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.Width = 80;
            // 
            // txtGuestName
            // 
            this.txtGuestName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestName.Location = new System.Drawing.Point(94, 191);
            this.txtGuestName.Name = "txtGuestName";
            this.txtGuestName.Size = new System.Drawing.Size(250, 27);
            this.txtGuestName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(356, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Phone No.";
            // 
            // txtGuestPhone
            // 
            this.txtGuestPhone.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestPhone.Location = new System.Drawing.Point(443, 191);
            this.txtGuestPhone.Name = "txtGuestPhone";
            this.txtGuestPhone.Size = new System.Drawing.Size(147, 27);
            this.txtGuestPhone.TabIndex = 14;
            // 
            // lblWedID
            // 
            this.lblWedID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWedID.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedID.Location = new System.Drawing.Point(401, 125);
            this.lblWedID.Name = "lblWedID";
            this.lblWedID.Size = new System.Drawing.Size(142, 27);
            this.lblWedID.TabIndex = 19;
            this.lblWedID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(300, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Wedding ID";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(-67, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 365);
            this.label8.TabIndex = 20;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxGuestRelay
            // 
            this.cbxGuestRelay.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGuestRelay.FormattingEnabled = true;
            this.cbxGuestRelay.Items.AddRange(new object[] {
            "Family",
            "Friend",
            "Guest"});
            this.cbxGuestRelay.Location = new System.Drawing.Point(608, 192);
            this.cbxGuestRelay.Name = "cbxGuestRelay";
            this.cbxGuestRelay.Size = new System.Drawing.Size(153, 27);
            this.cbxGuestRelay.TabIndex = 21;
            this.cbxGuestRelay.Text = " Select Relation";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 631);
            this.Controls.Add(this.cbxGuestRelay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblWedID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtGuestPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGuestName);
            this.Controls.Add(this.dgvAddInvite);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxTable);
            this.Controls.Add(label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxClientList);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Invitee Form";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddInvite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxTable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.DataGridView dgvAddInvite;
        private System.Windows.Forms.TextBox txtGuestName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGuestPhone;
        private System.Windows.Forms.Label lblWedID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxGuestRelay;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
    }
}