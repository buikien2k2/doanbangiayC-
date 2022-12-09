using System.Windows.Forms;

namespace Shoes.GUI
{
    partial class Form_CUSTOMER
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblSum = new System.Windows.Forms.Label();
            this.lblNumFemale = new System.Windows.Forms.Label();
            this.lblNumMale = new System.Windows.Forms.Label();
            this.lblNumCustomer = new System.Windows.Forms.Label();
            this.rdBNu = new System.Windows.Forms.RadioButton();
            this.lblFemaleCus = new System.Windows.Forms.Label();
            this.lblMaleCus = new System.Windows.Forms.Label();
            this.rdBNam = new System.Windows.Forms.RadioButton();
            this.lblCus = new System.Windows.Forms.Label();
            this.grBInfo = new System.Windows.Forms.GroupBox();
            this.CBGender = new System.Windows.Forms.ComboBox();
            this.tbCustomerId = new System.Windows.Forms.TextBox();
            this.tbCustomerPhone = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblphnumber = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblKhachhang = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.dgvCustomer = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.grbnumcustomer = new System.Windows.Forms.GroupBox();
            this.customerIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerGenderDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.customerPhoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grBInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grbnumcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(43, 52);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(58, 23);
            this.lblSum.TabIndex = 10;
            this.lblSum.Text = "Tổng";
            // 
            // lblNumFemale
            // 
            this.lblNumFemale.AutoSize = true;
            this.lblNumFemale.ForeColor = System.Drawing.Color.HotPink;
            this.lblNumFemale.Location = new System.Drawing.Point(138, 146);
            this.lblNumFemale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumFemale.Name = "lblNumFemale";
            this.lblNumFemale.Size = new System.Drawing.Size(22, 23);
            this.lblNumFemale.TabIndex = 9;
            this.lblNumFemale.Text = "0";
            // 
            // lblNumMale
            // 
            this.lblNumMale.AutoSize = true;
            this.lblNumMale.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNumMale.Location = new System.Drawing.Point(138, 99);
            this.lblNumMale.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumMale.Name = "lblNumMale";
            this.lblNumMale.Size = new System.Drawing.Size(22, 23);
            this.lblNumMale.TabIndex = 8;
            this.lblNumMale.Text = "0";
            // 
            // lblNumCustomer
            // 
            this.lblNumCustomer.AutoSize = true;
            this.lblNumCustomer.Location = new System.Drawing.Point(138, 52);
            this.lblNumCustomer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNumCustomer.Name = "lblNumCustomer";
            this.lblNumCustomer.Size = new System.Drawing.Size(22, 23);
            this.lblNumCustomer.TabIndex = 7;
            this.lblNumCustomer.Text = "0";
            // 
            // rdBNu
            // 
            this.rdBNu.AutoSize = true;
            this.rdBNu.ForeColor = System.Drawing.Color.HotPink;
            this.rdBNu.Location = new System.Drawing.Point(47, 145);
            this.rdBNu.Margin = new System.Windows.Forms.Padding(2);
            this.rdBNu.Name = "rdBNu";
            this.rdBNu.Size = new System.Drawing.Size(56, 27);
            this.rdBNu.TabIndex = 6;
            this.rdBNu.TabStop = true;
            this.rdBNu.Text = "Nữ";
            this.rdBNu.UseVisualStyleBackColor = true;
            this.rdBNu.CheckedChanged += new System.EventHandler(this.rdBNu_CheckedChanged);
            // 
            // lblFemaleCus
            // 
            this.lblFemaleCus.AutoSize = true;
            this.lblFemaleCus.ForeColor = System.Drawing.Color.HotPink;
            this.lblFemaleCus.Location = new System.Drawing.Point(212, 146);
            this.lblFemaleCus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFemaleCus.Name = "lblFemaleCus";
            this.lblFemaleCus.Size = new System.Drawing.Size(121, 23);
            this.lblFemaleCus.TabIndex = 5;
            this.lblFemaleCus.Text = "Khách hàng";
            // 
            // lblMaleCus
            // 
            this.lblMaleCus.AutoSize = true;
            this.lblMaleCus.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblMaleCus.Location = new System.Drawing.Point(212, 98);
            this.lblMaleCus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaleCus.Name = "lblMaleCus";
            this.lblMaleCus.Size = new System.Drawing.Size(121, 23);
            this.lblMaleCus.TabIndex = 4;
            this.lblMaleCus.Text = "Khách hàng";
            // 
            // rdBNam
            // 
            this.rdBNam.AutoSize = true;
            this.rdBNam.ForeColor = System.Drawing.Color.RoyalBlue;
            this.rdBNam.Location = new System.Drawing.Point(47, 97);
            this.rdBNam.Margin = new System.Windows.Forms.Padding(2);
            this.rdBNam.Name = "rdBNam";
            this.rdBNam.Size = new System.Drawing.Size(72, 27);
            this.rdBNam.TabIndex = 2;
            this.rdBNam.TabStop = true;
            this.rdBNam.Text = "Nam";
            this.rdBNam.UseVisualStyleBackColor = true;
            this.rdBNam.CheckedChanged += new System.EventHandler(this.rdBNam_CheckedChanged);
            // 
            // lblCus
            // 
            this.lblCus.AutoSize = true;
            this.lblCus.Location = new System.Drawing.Point(212, 52);
            this.lblCus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCus.Name = "lblCus";
            this.lblCus.Size = new System.Drawing.Size(121, 23);
            this.lblCus.TabIndex = 1;
            this.lblCus.Text = "Khách hàng";
            // 
            // grBInfo
            // 
            this.grBInfo.Controls.Add(this.CBGender);
            this.grBInfo.Controls.Add(this.tbCustomerId);
            this.grBInfo.Controls.Add(this.tbCustomerPhone);
            this.grBInfo.Controls.Add(this.tbCustomerName);
            this.grBInfo.Controls.Add(this.lblGender);
            this.grBInfo.Controls.Add(this.lblphnumber);
            this.grBInfo.Controls.Add(this.lblMaKH);
            this.grBInfo.Controls.Add(this.lblKhachhang);
            this.grBInfo.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBInfo.Location = new System.Drawing.Point(81, 36);
            this.grBInfo.Margin = new System.Windows.Forms.Padding(2);
            this.grBInfo.Name = "grBInfo";
            this.grBInfo.Padding = new System.Windows.Forms.Padding(2);
            this.grBInfo.Size = new System.Drawing.Size(874, 212);
            this.grBInfo.TabIndex = 1;
            this.grBInfo.TabStop = false;
            this.grBInfo.Text = "Thông tin khách hàng";
            // 
            // CBGender
            // 
            this.CBGender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBGender.FormattingEnabled = true;
            this.CBGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.CBGender.Location = new System.Drawing.Point(591, 142);
            this.CBGender.Margin = new System.Windows.Forms.Padding(2);
            this.CBGender.Name = "CBGender";
            this.CBGender.Size = new System.Drawing.Size(163, 31);
            this.CBGender.TabIndex = 8;
            // 
            // tbCustomerId
            // 
            this.tbCustomerId.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerId.Location = new System.Drawing.Point(588, 63);
            this.tbCustomerId.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerId.Name = "tbCustomerId";
            this.tbCustomerId.Size = new System.Drawing.Size(224, 30);
            this.tbCustomerId.TabIndex = 7;
            // 
            // tbCustomerPhone
            // 
            this.tbCustomerPhone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerPhone.Location = new System.Drawing.Point(184, 141);
            this.tbCustomerPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerPhone.Name = "tbCustomerPhone";
            this.tbCustomerPhone.Size = new System.Drawing.Size(228, 30);
            this.tbCustomerPhone.TabIndex = 6;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomerName.Location = new System.Drawing.Point(188, 63);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(224, 30);
            this.tbCustomerName.TabIndex = 5;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(494, 146);
            this.lblGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(79, 23);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Giới tính";
            // 
            // lblphnumber
            // 
            this.lblphnumber.AutoSize = true;
            this.lblphnumber.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphnumber.Location = new System.Drawing.Point(56, 145);
            this.lblphnumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblphnumber.Name = "lblphnumber";
            this.lblphnumber.Size = new System.Drawing.Size(120, 23);
            this.lblphnumber.TabIndex = 2;
            this.lblphnumber.Text = "Số điện thoại";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaKH.Location = new System.Drawing.Point(442, 68);
            this.lblMaKH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(140, 23);
            this.lblMaKH.TabIndex = 1;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblKhachhang
            // 
            this.lblKhachhang.AutoSize = true;
            this.lblKhachhang.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachhang.Location = new System.Drawing.Point(32, 66);
            this.lblKhachhang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKhachhang.Name = "lblKhachhang";
            this.lblKhachhang.Size = new System.Drawing.Size(147, 23);
            this.lblKhachhang.TabIndex = 0;
            this.lblKhachhang.Text = "Tên khách hàng";
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(725, 265);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(140, 35);
            this.btnInsert.TabIndex = 3;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(885, 265);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 35);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1045, 265);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 35);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(565, 265);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 35);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.Location = new System.Drawing.Point(275, 269);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(263, 29);
            this.tbSearch.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(1205, 265);
            this.btnReload.Margin = new System.Windows.Forms.Padding(2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(140, 35);
            this.btnReload.TabIndex = 9;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowCustomTheming = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCustomer.AutoGenerateColumns = false;
            this.dgvCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCustomer.ColumnHeadersHeight = 40;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerIdDataGridViewTextBoxColumn1,
            this.customerNameDataGridViewTextBoxColumn1,
            this.customerGenderDataGridViewCheckBoxColumn1,
            this.customerPhoneDataGridViewTextBoxColumn1});
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomer.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvCustomer.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.Name = null;
            this.dgvCustomer.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCustomer.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvCustomer.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvCustomer.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvCustomer.DataSource = this.customerDTOBindingSource;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCustomer.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvCustomer.EnableHeadersVisualStyles = false;
            this.dgvCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvCustomer.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvCustomer.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvCustomer.HeaderForeColor = System.Drawing.Color.White;
            this.dgvCustomer.Location = new System.Drawing.Point(81, 315);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowHeadersVisible = false;
            this.dgvCustomer.RowTemplate.Height = 40;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.Size = new System.Drawing.Size(1263, 387);
            this.dgvCustomer.TabIndex = 10;
            this.dgvCustomer.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellClick);
            // 
            // cbSelect
            // 
            this.cbSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.ItemHeight = 24;
            this.cbSelect.Items.AddRange(new object[] {
            "Mã khách hàng",
            "Tên khách hàng",
            "Số điện thoại"});
            this.cbSelect.Location = new System.Drawing.Point(81, 267);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(186, 32);
            this.cbSelect.TabIndex = 11;
            // 
            // grbnumcustomer
            // 
            this.grbnumcustomer.Controls.Add(this.lblSum);
            this.grbnumcustomer.Controls.Add(this.lblNumFemale);
            this.grbnumcustomer.Controls.Add(this.lblCus);
            this.grbnumcustomer.Controls.Add(this.lblNumCustomer);
            this.grbnumcustomer.Controls.Add(this.lblNumMale);
            this.grbnumcustomer.Controls.Add(this.rdBNam);
            this.grbnumcustomer.Controls.Add(this.rdBNu);
            this.grbnumcustomer.Controls.Add(this.lblFemaleCus);
            this.grbnumcustomer.Controls.Add(this.lblMaleCus);
            this.grbnumcustomer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbnumcustomer.ForeColor = System.Drawing.Color.Green;
            this.grbnumcustomer.Location = new System.Drawing.Point(972, 36);
            this.grbnumcustomer.Name = "grbnumcustomer";
            this.grbnumcustomer.Size = new System.Drawing.Size(372, 212);
            this.grbnumcustomer.TabIndex = 12;
            this.grbnumcustomer.TabStop = false;
            this.grbnumcustomer.Text = "Thống kê";
            // 
            // customerIdDataGridViewTextBoxColumn1
            // 
            this.customerIdDataGridViewTextBoxColumn1.DataPropertyName = "CustomerId";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customerIdDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle9;
            this.customerIdDataGridViewTextBoxColumn1.HeaderText = "Mã khách hàng";
            this.customerIdDataGridViewTextBoxColumn1.Name = "customerIdDataGridViewTextBoxColumn1";
            // 
            // customerNameDataGridViewTextBoxColumn1
            // 
            this.customerNameDataGridViewTextBoxColumn1.DataPropertyName = "CustomerName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customerNameDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle10;
            this.customerNameDataGridViewTextBoxColumn1.HeaderText = "Tên khách hàng";
            this.customerNameDataGridViewTextBoxColumn1.Name = "customerNameDataGridViewTextBoxColumn1";
            // 
            // customerGenderDataGridViewCheckBoxColumn1
            // 
            this.customerGenderDataGridViewCheckBoxColumn1.DataPropertyName = "CustomerGender";
            this.customerGenderDataGridViewCheckBoxColumn1.HeaderText = "Giới tính";
            this.customerGenderDataGridViewCheckBoxColumn1.Name = "customerGenderDataGridViewCheckBoxColumn1";
            // 
            // customerPhoneDataGridViewTextBoxColumn1
            // 
            this.customerPhoneDataGridViewTextBoxColumn1.DataPropertyName = "CustomerPhone";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customerPhoneDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle11;
            this.customerPhoneDataGridViewTextBoxColumn1.HeaderText = "Số điện thoại";
            this.customerPhoneDataGridViewTextBoxColumn1.Name = "customerPhoneDataGridViewTextBoxColumn1";
            // 
            // customerDTOBindingSource
            // 
            this.customerDTOBindingSource.DataSource = typeof(Shoes.DTO.customerDTO);
            // 
            // Form_CUSTOMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1418, 754);
            this.Controls.Add(this.grbnumcustomer);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.grBInfo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1433, 792);
            this.Name = "Form_CUSTOMER";
            this.Text = "Customer Manage";
            this.Load += new System.EventHandler(this.Form_CUSTOMER_Load);
            this.grBInfo.ResumeLayout(false);
            this.grBInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grbnumcustomer.ResumeLayout(false);
            this.grbnumcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerDTOBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox grBInfo;
        private TextBox tbCustomerId;
        private TextBox tbCustomerPhone;
        private TextBox tbCustomerName;
        private Label lblGender;
        private Label lblphnumber;
        private Label lblMaKH;
        private Label lblKhachhang;
        private ComboBox CBGender;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private BindingSource customerDTOBindingSource;
        private Button btnSearch;
        private TextBox tbSearch;
        private Label lblCus;
        private RadioButton rdBNam;
        private Label lblMaleCus;
        private Label lblFemaleCus;
        private RadioButton rdBNu;
        private Button btnReload;
        private Label lblNumCustomer;
        private Label lblNumMale;
        private Label lblNumFemale;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvCustomer;
        private Label lblSum;
        private ComboBox cbSelect;
        private GroupBox grbnumcustomer;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn customerGenderDataGridViewCheckBoxColumn1;
        private DataGridViewTextBoxColumn customerPhoneDataGridViewTextBoxColumn1;
    }
}