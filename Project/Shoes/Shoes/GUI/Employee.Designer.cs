namespace Shoes.GUI
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grbemployee = new System.Windows.Forms.GroupBox();
            this.txbemployeePhone = new System.Windows.Forms.TextBox();
            this.txbemployeeGender = new System.Windows.Forms.TextBox();
            this.txbemployeeName = new System.Windows.Forms.TextBox();
            this.dtpemployeeDatejoined = new System.Windows.Forms.DateTimePicker();
            this.dtpemployeeDateofBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDJ = new System.Windows.Forms.Label();
            this.lblSĐT = new System.Windows.Forms.Label();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.lblemployeeID = new System.Windows.Forms.Label();
            this.pbAvartar = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbsearch = new System.Windows.Forms.GroupBox();
            this.cbxchoose = new System.Windows.Forms.ComboBox();
            this.tbxsearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.ListEmployee = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.grbemployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grbsearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // grbemployee
            // 
            this.grbemployee.Controls.Add(this.txbemployeePhone);
            this.grbemployee.Controls.Add(this.txbemployeeGender);
            this.grbemployee.Controls.Add(this.txbemployeeName);
            this.grbemployee.Controls.Add(this.dtpemployeeDatejoined);
            this.grbemployee.Controls.Add(this.dtpemployeeDateofBirth);
            this.grbemployee.Controls.Add(this.lblDJ);
            this.grbemployee.Controls.Add(this.lblSĐT);
            this.grbemployee.Controls.Add(this.lbldob);
            this.grbemployee.Controls.Add(this.lblgender);
            this.grbemployee.Controls.Add(this.lblName);
            this.grbemployee.Controls.Add(this.lblQuyen);
            this.grbemployee.Controls.Add(this.lblemployeeID);
            this.grbemployee.Controls.Add(this.pbAvartar);
            this.grbemployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbemployee.Location = new System.Drawing.Point(73, 46);
            this.grbemployee.Name = "grbemployee";
            this.grbemployee.Size = new System.Drawing.Size(1016, 259);
            this.grbemployee.TabIndex = 1;
            this.grbemployee.TabStop = false;
            this.grbemployee.Text = "Thông tin nhân viên";
            // 
            // txbemployeePhone
            // 
            this.txbemployeePhone.Enabled = false;
            this.txbemployeePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemployeePhone.Location = new System.Drawing.Point(728, 122);
            this.txbemployeePhone.Multiline = true;
            this.txbemployeePhone.Name = "txbemployeePhone";
            this.txbemployeePhone.Size = new System.Drawing.Size(245, 29);
            this.txbemployeePhone.TabIndex = 12;
            // 
            // txbemployeeGender
            // 
            this.txbemployeeGender.Enabled = false;
            this.txbemployeeGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemployeeGender.Location = new System.Drawing.Point(345, 126);
            this.txbemployeeGender.Multiline = true;
            this.txbemployeeGender.Name = "txbemployeeGender";
            this.txbemployeeGender.Size = new System.Drawing.Size(128, 29);
            this.txbemployeeGender.TabIndex = 11;
            // 
            // txbemployeeName
            // 
            this.txbemployeeName.Enabled = false;
            this.txbemployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbemployeeName.Location = new System.Drawing.Point(345, 56);
            this.txbemployeeName.Multiline = true;
            this.txbemployeeName.Name = "txbemployeeName";
            this.txbemployeeName.Size = new System.Drawing.Size(316, 29);
            this.txbemployeeName.TabIndex = 10;
            // 
            // dtpemployeeDatejoined
            // 
            this.dtpemployeeDatejoined.Enabled = false;
            this.dtpemployeeDatejoined.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpemployeeDatejoined.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpemployeeDatejoined.Location = new System.Drawing.Point(728, 188);
            this.dtpemployeeDatejoined.Name = "dtpemployeeDatejoined";
            this.dtpemployeeDatejoined.Size = new System.Drawing.Size(175, 30);
            this.dtpemployeeDatejoined.TabIndex = 9;
            // 
            // dtpemployeeDateofBirth
            // 
            this.dtpemployeeDateofBirth.Enabled = false;
            this.dtpemployeeDateofBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpemployeeDateofBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpemployeeDateofBirth.Location = new System.Drawing.Point(345, 193);
            this.dtpemployeeDateofBirth.Name = "dtpemployeeDateofBirth";
            this.dtpemployeeDateofBirth.Size = new System.Drawing.Size(169, 30);
            this.dtpemployeeDateofBirth.TabIndex = 8;
            // 
            // lblDJ
            // 
            this.lblDJ.AutoSize = true;
            this.lblDJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDJ.Location = new System.Drawing.Point(560, 193);
            this.lblDJ.Name = "lblDJ";
            this.lblDJ.Size = new System.Drawing.Size(137, 25);
            this.lblDJ.TabIndex = 7;
            this.lblDJ.Text = "Ngày tham gia";
            // 
            // lblSĐT
            // 
            this.lblSĐT.AutoSize = true;
            this.lblSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSĐT.Location = new System.Drawing.Point(571, 126);
            this.lblSĐT.Name = "lblSĐT";
            this.lblSĐT.Size = new System.Drawing.Size(126, 25);
            this.lblSĐT.TabIndex = 6;
            this.lblSĐT.Text = "Số điện thoại";
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(211, 198);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(99, 25);
            this.lbldob.TabIndex = 5;
            this.lbldob.Text = "Ngày sinh";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(228, 130);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(82, 25);
            this.lblgender.TabIndex = 4;
            this.lblgender.Text = "Giới tính";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(228, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 25);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Họ và tên";
            // 
            // lblQuyen
            // 
            this.lblQuyen.AutoSize = true;
            this.lblQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.Location = new System.Drawing.Point(38, 225);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(64, 18);
            this.lblQuyen.TabIndex = 2;
            this.lblQuyen.Text = "Chưa có";
            // 
            // lblemployeeID
            // 
            this.lblemployeeID.AutoSize = true;
            this.lblemployeeID.Location = new System.Drawing.Point(36, 188);
            this.lblemployeeID.Name = "lblemployeeID";
            this.lblemployeeID.Size = new System.Drawing.Size(116, 25);
            this.lblemployeeID.TabIndex = 1;
            this.lblemployeeID.Text = "employeeID";
            this.lblemployeeID.TextChanged += new System.EventHandler(this.lblemployeeID_TextChanged);
            // 
            // pbAvartar
            // 
            this.pbAvartar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbAvartar.Image = ((System.Drawing.Image)(resources.GetObject("pbAvartar.Image")));
            this.pbAvartar.Location = new System.Drawing.Point(24, 32);
            this.pbAvartar.Name = "pbAvartar";
            this.pbAvartar.Size = new System.Drawing.Size(147, 153);
            this.pbAvartar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAvartar.TabIndex = 0;
            this.pbAvartar.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSum);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox1.Location = new System.Drawing.Point(1115, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 120);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblSum.Location = new System.Drawing.Point(142, 76);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(24, 25);
            this.lblSum.TabIndex = 14;
            this.lblSum.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(63, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Tổng số nhân viên";
            // 
            // grbsearch
            // 
            this.grbsearch.Controls.Add(this.cbxchoose);
            this.grbsearch.Controls.Add(this.tbxsearch);
            this.grbsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbsearch.Location = new System.Drawing.Point(106, 311);
            this.grbsearch.Name = "grbsearch";
            this.grbsearch.Size = new System.Drawing.Size(735, 74);
            this.grbsearch.TabIndex = 2;
            this.grbsearch.TabStop = false;
            this.grbsearch.Text = "Tìm kiếm";
            // 
            // cbxchoose
            // 
            this.cbxchoose.FormattingEnabled = true;
            this.cbxchoose.Items.AddRange(new object[] {
            "ID",
            "Họ Tên",
            "Giới Tính",
            "Số điện thoại"});
            this.cbxchoose.Location = new System.Drawing.Point(8, 28);
            this.cbxchoose.Name = "cbxchoose";
            this.cbxchoose.Size = new System.Drawing.Size(186, 33);
            this.cbxchoose.TabIndex = 14;
            // 
            // tbxsearch
            // 
            this.tbxsearch.Location = new System.Drawing.Point(200, 30);
            this.tbxsearch.Multiline = true;
            this.tbxsearch.Name = "tbxsearch";
            this.tbxsearch.Size = new System.Drawing.Size(254, 29);
            this.tbxsearch.TabIndex = 13;
            this.tbxsearch.TextChanged += new System.EventHandler(this.tbxsearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(881, 331);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 48);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1011, 330);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(114, 49);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1144, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 48);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnDetail.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.Location = new System.Drawing.Point(1274, 331);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(110, 48);
            this.btnDetail.TabIndex = 6;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ListEmployee
            // 
            this.ListEmployee.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.ListEmployee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ListEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ListEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListEmployee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ListEmployee.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ListEmployee.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ListEmployee.ColumnHeadersHeight = 40;
            this.ListEmployee.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.ListEmployee.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListEmployee.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListEmployee.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListEmployee.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.ListEmployee.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.ListEmployee.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListEmployee.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.ListEmployee.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.ListEmployee.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ListEmployee.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.ListEmployee.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.ListEmployee.CurrentTheme.Name = null;
            this.ListEmployee.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ListEmployee.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ListEmployee.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.ListEmployee.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.ListEmployee.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ListEmployee.DefaultCellStyle = dataGridViewCellStyle3;
            this.ListEmployee.EnableHeadersVisualStyles = false;
            this.ListEmployee.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.ListEmployee.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.ListEmployee.HeaderBgColor = System.Drawing.Color.Empty;
            this.ListEmployee.HeaderForeColor = System.Drawing.Color.White;
            this.ListEmployee.Location = new System.Drawing.Point(73, 391);
            this.ListEmployee.Name = "ListEmployee";
            this.ListEmployee.ReadOnly = true;
            this.ListEmployee.RowHeadersVisible = false;
            this.ListEmployee.RowHeadersWidth = 51;
            this.ListEmployee.RowTemplate.Height = 40;
            this.ListEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListEmployee.Size = new System.Drawing.Size(1326, 369);
            this.ListEmployee.TabIndex = 7;
            this.ListEmployee.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.ListEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListEmployee_CellClick_1);
            this.ListEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListEmployee_CellContentClick);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1462, 792);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ListEmployee);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.grbsearch);
            this.Controls.Add(this.grbemployee);
            this.Name = "Employee";
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            this.grbemployee.ResumeLayout(false);
            this.grbemployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAvartar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbsearch.ResumeLayout(false);
            this.grbsearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbemployee;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.Label lblemployeeID;
        private System.Windows.Forms.PictureBox pbAvartar;
        private System.Windows.Forms.GroupBox grbsearch;
        private System.Windows.Forms.TextBox txbemployeePhone;
        private System.Windows.Forms.TextBox txbemployeeGender;
        private System.Windows.Forms.TextBox txbemployeeName;
        private System.Windows.Forms.DateTimePicker dtpemployeeDatejoined;
        private System.Windows.Forms.DateTimePicker dtpemployeeDateofBirth;
        private System.Windows.Forms.Label lblDJ;
        private System.Windows.Forms.Label lblSĐT;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cbxchoose;
        private System.Windows.Forms.TextBox tbxsearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.UI.WinForms.BunifuDataGridView ListEmployee;
    }
}