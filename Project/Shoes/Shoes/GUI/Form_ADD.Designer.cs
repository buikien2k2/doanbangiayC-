using System.Windows.Forms;

namespace Shoes.GUI
{
    partial class Form_ADD
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grBImportnotedetail = new System.Windows.Forms.GroupBox();
            this.tbproductid = new System.Windows.Forms.TextBox();
            this.dgvNotedetail = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.lblsoluong = new System.Windows.Forms.Label();
            this.cbproductname = new System.Windows.Forms.ComboBox();
            this.grbInfoHDdetail = new System.Windows.Forms.GroupBox();
            this.lbltotalmoney = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.lbldetailnum = new System.Windows.Forms.Label();
            this.lblSumHD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnResetdetail = new System.Windows.Forms.Button();
            this.btnDeleteDetail = new System.Windows.Forms.Button();
            this.btnAdddetail = new System.Windows.Forms.Button();
            this.btnExportPDF = new System.Windows.Forms.Button();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblProductAmount = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductId = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grNote = new System.Windows.Forms.GroupBox();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.buttonsearch = new System.Windows.Forms.Button();
            this.lblDH = new System.Windows.Forms.Label();
            this.lblnumnote = new System.Windows.Forms.Label();
            this.dgvNote = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.grbInfoDH = new System.Windows.Forms.GroupBox();
            this.cbSupplierID = new System.Windows.Forms.ComboBox();
            this.lblSupplierId = new System.Windows.Forms.Label();
            this.lblNoteId = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblnumsupplier = new System.Windows.Forms.Label();
            this.tbHDid = new System.Windows.Forms.TextBox();
            this.lblNCC = new System.Windows.Forms.Label();
            this.tbNhapId = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grBTool = new System.Windows.Forms.GroupBox();
            this.btnResetGridView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.sqlCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlCommand2 = new System.Data.SqlClient.SqlCommand();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.noteIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notedetailIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adddetailDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.grBImportnotedetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotedetail)).BeginInit();
            this.grbInfoHDdetail.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).BeginInit();
            this.grbInfoDH.SuspendLayout();
            this.grBTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddetailDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grBImportnotedetail
            // 
            this.grBImportnotedetail.Controls.Add(this.textBox1);
            this.grBImportnotedetail.Controls.Add(this.label2);
            this.grBImportnotedetail.Controls.Add(this.tbproductid);
            this.grBImportnotedetail.Controls.Add(this.dgvNotedetail);
            this.grBImportnotedetail.Controls.Add(this.lblsoluong);
            this.grBImportnotedetail.Controls.Add(this.cbproductname);
            this.grBImportnotedetail.Controls.Add(this.grbInfoHDdetail);
            this.grBImportnotedetail.Controls.Add(this.groupBox1);
            this.grBImportnotedetail.Controls.Add(this.tbQuantity);
            this.grBImportnotedetail.Controls.Add(this.tbPrice);
            this.grBImportnotedetail.Controls.Add(this.lblPrice);
            this.grBImportnotedetail.Controls.Add(this.lblQuantity);
            this.grBImportnotedetail.Controls.Add(this.lblProductAmount);
            this.grBImportnotedetail.Controls.Add(this.lblProductName);
            this.grBImportnotedetail.Controls.Add(this.lblProductId);
            this.grBImportnotedetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grBImportnotedetail.Location = new System.Drawing.Point(724, 33);
            this.grBImportnotedetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBImportnotedetail.Name = "grBImportnotedetail";
            this.grBImportnotedetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBImportnotedetail.Size = new System.Drawing.Size(1152, 901);
            this.grBImportnotedetail.TabIndex = 0;
            this.grBImportnotedetail.TabStop = false;
            this.grBImportnotedetail.Text = "Chi tiết Phiếu nhập";
            // 
            // tbproductid
            // 
            this.tbproductid.Location = new System.Drawing.Point(228, 110);
            this.tbproductid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbproductid.Name = "tbproductid";
            this.tbproductid.Size = new System.Drawing.Size(272, 34);
            this.tbproductid.TabIndex = 17;
            // 
            // dgvNotedetail
            // 
            this.dgvNotedetail.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvNotedetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNotedetail.AutoGenerateColumns = false;
            this.dgvNotedetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNotedetail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNotedetail.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNotedetail.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotedetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvNotedetail.ColumnHeadersHeight = 40;
            this.dgvNotedetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.notedetailIdDataGridViewTextBoxColumn,
            this.productIdDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn,
            this.importPriceDataGridViewTextBoxColumn,
            this.importQuantityDataGridViewTextBoxColumn});
            this.dgvNotedetail.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNotedetail.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNotedetail.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNotedetail.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNotedetail.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNotedetail.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNotedetail.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNotedetail.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNotedetail.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNotedetail.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNotedetail.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNotedetail.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNotedetail.CurrentTheme.Name = null;
            this.dgvNotedetail.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNotedetail.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNotedetail.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNotedetail.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNotedetail.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNotedetail.DataSource = this.adddetailDTOBindingSource;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotedetail.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNotedetail.EnableHeadersVisualStyles = false;
            this.dgvNotedetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNotedetail.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNotedetail.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNotedetail.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNotedetail.Location = new System.Drawing.Point(13, 402);
            this.dgvNotedetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNotedetail.Name = "dgvNotedetail";
            this.dgvNotedetail.RowHeadersVisible = false;
            this.dgvNotedetail.RowHeadersWidth = 51;
            this.dgvNotedetail.RowTemplate.Height = 40;
            this.dgvNotedetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNotedetail.Size = new System.Drawing.Size(1124, 479);
            this.dgvNotedetail.TabIndex = 16;
            this.dgvNotedetail.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvNotedetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNotedetail_CellClick);
            // 
            // lblsoluong
            // 
            this.lblsoluong.AutoSize = true;
            this.lblsoluong.Location = new System.Drawing.Point(231, 167);
            this.lblsoluong.Name = "lblsoluong";
            this.lblsoluong.Size = new System.Drawing.Size(27, 29);
            this.lblsoluong.TabIndex = 14;
            this.lblsoluong.Text = "0";
            // 
            // cbproductname
            // 
            this.cbproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbproductname.FormattingEnabled = true;
            this.cbproductname.Location = new System.Drawing.Point(227, 47);
            this.cbproductname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbproductname.Name = "cbproductname";
            this.cbproductname.Size = new System.Drawing.Size(563, 37);
            this.cbproductname.TabIndex = 13;
            this.cbproductname.SelectedIndexChanged += new System.EventHandler(this.cbproductname_SelectedIndexChanged);
            // 
            // grbInfoHDdetail
            // 
            this.grbInfoHDdetail.Controls.Add(this.lbltotalmoney);
            this.grbInfoHDdetail.Controls.Add(this.lblnum);
            this.grbInfoHDdetail.Controls.Add(this.lbldetailnum);
            this.grbInfoHDdetail.Controls.Add(this.lblSumHD);
            this.grbInfoHDdetail.Location = new System.Drawing.Point(695, 96);
            this.grbInfoHDdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoHDdetail.Name = "grbInfoHDdetail";
            this.grbInfoHDdetail.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoHDdetail.Size = new System.Drawing.Size(380, 289);
            this.grbInfoHDdetail.TabIndex = 12;
            this.grbInfoHDdetail.TabStop = false;
            this.grbInfoHDdetail.Text = "Thông tin chi tiết phiếu nhập";
            // 
            // lbltotalmoney
            // 
            this.lbltotalmoney.AutoSize = true;
            this.lbltotalmoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalmoney.Location = new System.Drawing.Point(157, 201);
            this.lbltotalmoney.Name = "lbltotalmoney";
            this.lbltotalmoney.Size = new System.Drawing.Size(82, 29);
            this.lbltotalmoney.TabIndex = 12;
            this.lbltotalmoney.Text = "0 VND";
            // 
            // lblnum
            // 
            this.lblnum.AutoSize = true;
            this.lblnum.Location = new System.Drawing.Point(157, 114);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(27, 29);
            this.lblnum.TabIndex = 1;
            this.lblnum.Text = "0";
            // 
            // lbldetailnum
            // 
            this.lbldetailnum.AutoSize = true;
            this.lbldetailnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldetailnum.Location = new System.Drawing.Point(11, 78);
            this.lbldetailnum.Name = "lbldetailnum";
            this.lbldetailnum.Size = new System.Drawing.Size(315, 29);
            this.lbldetailnum.TabIndex = 0;
            this.lbldetailnum.Text = "Số lượng phiếu nhập chi tiết:";
            // 
            // lblSumHD
            // 
            this.lblSumHD.AutoSize = true;
            this.lblSumHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSumHD.Location = new System.Drawing.Point(121, 145);
            this.lblSumHD.Name = "lblSumHD";
            this.lblSumHD.Size = new System.Drawing.Size(174, 29);
            this.lblSumHD.TabIndex = 3;
            this.lblSumHD.Text = "Tổng tiền nhập";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnResetdetail);
            this.groupBox1.Controls.Add(this.btnDeleteDetail);
            this.groupBox1.Controls.Add(this.btnAdddetail);
            this.groupBox1.Controls.Add(this.btnExportPDF);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(515, 96);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(175, 289);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sửa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnResetdetail
            // 
            this.btnResetdetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetdetail.Location = new System.Drawing.Point(17, 193);
            this.btnResetdetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetdetail.Name = "btnResetdetail";
            this.btnResetdetail.Size = new System.Drawing.Size(140, 37);
            this.btnResetdetail.TabIndex = 11;
            this.btnResetdetail.Text = "Reset";
            this.btnResetdetail.UseVisualStyleBackColor = true;
            this.btnResetdetail.Click += new System.EventHandler(this.btnResetdetail_Click);
            // 
            // btnDeleteDetail
            // 
            this.btnDeleteDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDetail.Location = new System.Drawing.Point(17, 142);
            this.btnDeleteDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteDetail.Name = "btnDeleteDetail";
            this.btnDeleteDetail.Size = new System.Drawing.Size(140, 37);
            this.btnDeleteDetail.TabIndex = 9;
            this.btnDeleteDetail.Text = "Xóa";
            this.btnDeleteDetail.UseVisualStyleBackColor = true;
            this.btnDeleteDetail.Click += new System.EventHandler(this.btnDeleteDetail_Click);
            // 
            // btnAdddetail
            // 
            this.btnAdddetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdddetail.Location = new System.Drawing.Point(17, 39);
            this.btnAdddetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdddetail.Name = "btnAdddetail";
            this.btnAdddetail.Size = new System.Drawing.Size(140, 37);
            this.btnAdddetail.TabIndex = 7;
            this.btnAdddetail.Text = "Thêm";
            this.btnAdddetail.UseVisualStyleBackColor = true;
            this.btnAdddetail.Click += new System.EventHandler(this.btnAdddetail_Click);
            // 
            // btnExportPDF
            // 
            this.btnExportPDF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportPDF.Location = new System.Drawing.Point(17, 240);
            this.btnExportPDF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportPDF.Name = "btnExportPDF";
            this.btnExportPDF.Size = new System.Drawing.Size(140, 37);
            this.btnExportPDF.TabIndex = 7;
            this.btnExportPDF.Text = "Xuất file PDF";
            this.btnExportPDF.UseVisualStyleBackColor = true;
            this.btnExportPDF.Click += new System.EventHandler(this.btnExportPDF_Click);
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(228, 263);
            this.tbQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(272, 34);
            this.tbQuantity.TabIndex = 10;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(228, 210);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(272, 34);
            this.tbPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(111, 213);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(109, 29);
            this.lblPrice.TabIndex = 5;
            this.lblPrice.Text = "Giá nhập";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(44, 267);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(173, 29);
            this.lblQuantity.TabIndex = 4;
            this.lblQuantity.Text = "Số lượng Nhập";
            // 
            // lblProductAmount
            // 
            this.lblProductAmount.AutoSize = true;
            this.lblProductAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductAmount.Location = new System.Drawing.Point(19, 166);
            this.lblProductAmount.Name = "lblProductAmount";
            this.lblProductAmount.Size = new System.Drawing.Size(193, 29);
            this.lblProductAmount.TabIndex = 3;
            this.lblProductAmount.Text = "Số lượng hiện có";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(41, 49);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(170, 29);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Tên Sản phẩm";
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductId.Location = new System.Drawing.Point(53, 113);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(160, 29);
            this.lblProductId.TabIndex = 1;
            this.lblProductId.Text = "Mã Sản phẩm";
            // 
            // grNote
            // 
            this.grNote.Controls.Add(this.tbsearch);
            this.grNote.Controls.Add(this.buttonsearch);
            this.grNote.Controls.Add(this.lblDH);
            this.grNote.Controls.Add(this.lblnumnote);
            this.grNote.Controls.Add(this.dgvNote);
            this.grNote.Controls.Add(this.grbInfoDH);
            this.grNote.Controls.Add(this.tbNhapId);
            this.grNote.Controls.Add(this.btnSearch);
            this.grNote.Controls.Add(this.grBTool);
            this.grNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNote.Location = new System.Drawing.Point(12, 33);
            this.grNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grNote.Name = "grNote";
            this.grNote.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grNote.Size = new System.Drawing.Size(707, 901);
            this.grNote.TabIndex = 1;
            this.grNote.TabStop = false;
            this.grNote.Text = "Đơn hàng";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(16, 345);
            this.tbsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(221, 34);
            this.tbsearch.TabIndex = 12;
            // 
            // buttonsearch
            // 
            this.buttonsearch.Location = new System.Drawing.Point(251, 345);
            this.buttonsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonsearch.Name = "buttonsearch";
            this.buttonsearch.Size = new System.Drawing.Size(128, 39);
            this.buttonsearch.TabIndex = 11;
            this.buttonsearch.Text = "Search";
            this.buttonsearch.UseVisualStyleBackColor = true;
            this.buttonsearch.Click += new System.EventHandler(this.buttonsearch_Click);
            // 
            // lblDH
            // 
            this.lblDH.AutoSize = true;
            this.lblDH.Location = new System.Drawing.Point(61, 214);
            this.lblDH.Name = "lblDH";
            this.lblDH.Size = new System.Drawing.Size(234, 29);
            this.lblDH.TabIndex = 9;
            this.lblDH.Text = "Số lượng phiếu nhập";
            // 
            // lblnumnote
            // 
            this.lblnumnote.AutoSize = true;
            this.lblnumnote.Location = new System.Drawing.Point(319, 214);
            this.lblnumnote.Name = "lblnumnote";
            this.lblnumnote.Size = new System.Drawing.Size(26, 29);
            this.lblnumnote.TabIndex = 8;
            this.lblnumnote.Text = "0";
            // 
            // dgvNote
            // 
            this.dgvNote.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvNote.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvNote.AutoGenerateColumns = false;
            this.dgvNote.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNote.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNote.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNote.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvNote.ColumnHeadersHeight = 40;
            this.dgvNote.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noteIdDataGridViewTextBoxColumn,
            this.supplierIdDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn});
            this.dgvNote.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.dgvNote.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNote.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNote.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNote.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNote.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.dgvNote.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNote.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNote.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.dgvNote.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNote.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.dgvNote.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvNote.CurrentTheme.Name = null;
            this.dgvNote.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNote.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.dgvNote.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvNote.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.dgvNote.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvNote.DataSource = this.addDTOBindingSource;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNote.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvNote.EnableHeadersVisualStyles = false;
            this.dgvNote.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.dgvNote.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.dgvNote.HeaderBgColor = System.Drawing.Color.Empty;
            this.dgvNote.HeaderForeColor = System.Drawing.Color.White;
            this.dgvNote.Location = new System.Drawing.Point(16, 402);
            this.dgvNote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvNote.Name = "dgvNote";
            this.dgvNote.RowHeadersVisible = false;
            this.dgvNote.RowHeadersWidth = 51;
            this.dgvNote.RowTemplate.Height = 40;
            this.dgvNote.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNote.Size = new System.Drawing.Size(679, 479);
            this.dgvNote.TabIndex = 10;
            this.dgvNote.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            this.dgvNote.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNote_CellClick);
            // 
            // grbInfoDH
            // 
            this.grbInfoDH.Controls.Add(this.cbSupplierID);
            this.grbInfoDH.Controls.Add(this.lblSupplierId);
            this.grbInfoDH.Controls.Add(this.lblNoteId);
            this.grbInfoDH.Controls.Add(this.dateTimePicker1);
            this.grbInfoDH.Controls.Add(this.label1);
            this.grbInfoDH.Controls.Add(this.lblnumsupplier);
            this.grbInfoDH.Controls.Add(this.tbHDid);
            this.grbInfoDH.Controls.Add(this.lblNCC);
            this.grbInfoDH.Location = new System.Drawing.Point(16, 32);
            this.grbInfoDH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDH.Name = "grbInfoDH";
            this.grbInfoDH.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grbInfoDH.Size = new System.Drawing.Size(501, 287);
            this.grbInfoDH.TabIndex = 9;
            this.grbInfoDH.TabStop = false;
            this.grbInfoDH.Text = "Thông tin Phiếu nhập";
            // 
            // cbSupplierID
            // 
            this.cbSupplierID.FormattingEnabled = true;
            this.cbSupplierID.Location = new System.Drawing.Point(299, 82);
            this.cbSupplierID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSupplierID.Name = "cbSupplierID";
            this.cbSupplierID.Size = new System.Drawing.Size(184, 37);
            this.cbSupplierID.TabIndex = 12;
            // 
            // lblSupplierId
            // 
            this.lblSupplierId.AutoSize = true;
            this.lblSupplierId.Location = new System.Drawing.Point(87, 86);
            this.lblSupplierId.Name = "lblSupplierId";
            this.lblSupplierId.Size = new System.Drawing.Size(194, 29);
            this.lblSupplierId.TabIndex = 5;
            this.lblSupplierId.Text = "Mã nhà cung cấp";
            // 
            // lblNoteId
            // 
            this.lblNoteId.AutoSize = true;
            this.lblNoteId.Location = new System.Drawing.Point(113, 38);
            this.lblNoteId.Name = "lblNoteId";
            this.lblNoteId.Size = new System.Drawing.Size(173, 29);
            this.lblNoteId.TabIndex = 1;
            this.lblNoteId.Text = "Mã Phiếu nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(299, 132);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 34);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày cung cấp";
            // 
            // lblnumsupplier
            // 
            this.lblnumsupplier.AutoSize = true;
            this.lblnumsupplier.Location = new System.Drawing.Point(301, 229);
            this.lblnumsupplier.Name = "lblnumsupplier";
            this.lblnumsupplier.Size = new System.Drawing.Size(26, 29);
            this.lblnumsupplier.TabIndex = 11;
            this.lblnumsupplier.Text = "0";
            // 
            // tbHDid
            // 
            this.tbHDid.Location = new System.Drawing.Point(299, 34);
            this.tbHDid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbHDid.Name = "tbHDid";
            this.tbHDid.Size = new System.Drawing.Size(188, 34);
            this.tbHDid.TabIndex = 3;
            // 
            // lblNCC
            // 
            this.lblNCC.AutoSize = true;
            this.lblNCC.Location = new System.Drawing.Point(17, 229);
            this.lblNCC.Name = "lblNCC";
            this.lblNCC.Size = new System.Drawing.Size(257, 29);
            this.lblNCC.TabIndex = 10;
            this.lblNCC.Text = "Số lượng nhà cung cấp";
            // 
            // tbNhapId
            // 
            this.tbNhapId.Location = new System.Drawing.Point(123, 186);
            this.tbNhapId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNhapId.Name = "tbNhapId";
            this.tbNhapId.Size = new System.Drawing.Size(232, 34);
            this.tbNhapId.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(23, 186);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(93, 22);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search Id";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grBTool
            // 
            this.grBTool.Controls.Add(this.btnResetGridView);
            this.grBTool.Controls.Add(this.btnDelete);
            this.grBTool.Controls.Add(this.btnEdit);
            this.grBTool.Controls.Add(this.btnAdd);
            this.grBTool.Location = new System.Drawing.Point(523, 32);
            this.grBTool.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBTool.Name = "grBTool";
            this.grBTool.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grBTool.Size = new System.Drawing.Size(172, 287);
            this.grBTool.TabIndex = 1;
            this.grBTool.TabStop = false;
            this.grBTool.Text = "Chức năng";
            // 
            // btnResetGridView
            // 
            this.btnResetGridView.Location = new System.Drawing.Point(13, 220);
            this.btnResetGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnResetGridView.Name = "btnResetGridView";
            this.btnResetGridView.Size = new System.Drawing.Size(140, 37);
            this.btnResetGridView.TabIndex = 10;
            this.btnResetGridView.Text = "Reset";
            this.btnResetGridView.UseVisualStyleBackColor = true;
            this.btnResetGridView.Click += new System.EventHandler(this.btnResetGridView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 161);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(140, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(16, 101);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(140, 37);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(16, 41);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(140, 37);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 332);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 34);
            this.textBox1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "size";
            // 
            // noteIdDataGridViewTextBoxColumn
            // 
            this.noteIdDataGridViewTextBoxColumn.DataPropertyName = "NoteId";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.noteIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle12;
            this.noteIdDataGridViewTextBoxColumn.HeaderText = "Mã phiếu nhập";
            this.noteIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.noteIdDataGridViewTextBoxColumn.Name = "noteIdDataGridViewTextBoxColumn";
            // 
            // supplierIdDataGridViewTextBoxColumn
            // 
            this.supplierIdDataGridViewTextBoxColumn.DataPropertyName = "SupplierId";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.supplierIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle13;
            this.supplierIdDataGridViewTextBoxColumn.HeaderText = "Mã nhà cung cấp";
            this.supplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIdDataGridViewTextBoxColumn.Name = "supplierIdDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle14;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Ngày nhập";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // addDTOBindingSource
            // 
            this.addDTOBindingSource.DataSource = typeof(Shoes.DTO.addDTO);
            // 
            // notedetailIdDataGridViewTextBoxColumn
            // 
            this.notedetailIdDataGridViewTextBoxColumn.DataPropertyName = "NotedetailId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.notedetailIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.notedetailIdDataGridViewTextBoxColumn.HeaderText = "Tên phiếu nhập";
            this.notedetailIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notedetailIdDataGridViewTextBoxColumn.Name = "notedetailIdDataGridViewTextBoxColumn";
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            this.productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productIdDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.productIdDataGridViewTextBoxColumn.HeaderText = "Mã Sản phẩm";
            this.productIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Số lượng hiện có";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            // 
            // importPriceDataGridViewTextBoxColumn
            // 
            this.importPriceDataGridViewTextBoxColumn.DataPropertyName = "ImportPrice";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.importPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.importPriceDataGridViewTextBoxColumn.HeaderText = "Giá nhập";
            this.importPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importPriceDataGridViewTextBoxColumn.Name = "importPriceDataGridViewTextBoxColumn";
            // 
            // importQuantityDataGridViewTextBoxColumn
            // 
            this.importQuantityDataGridViewTextBoxColumn.DataPropertyName = "ImportQuantity";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.importQuantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.importQuantityDataGridViewTextBoxColumn.HeaderText = "Số lượng nhập";
            this.importQuantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.importQuantityDataGridViewTextBoxColumn.Name = "importQuantityDataGridViewTextBoxColumn";
            // 
            // adddetailDTOBindingSource
            // 
            this.adddetailDTOBindingSource.DataSource = typeof(Shoes.DTO.adddetailDTO);
            // 
            // Form_ADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1891, 928);
            this.Controls.Add(this.grNote);
            this.Controls.Add(this.grBImportnotedetail);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ADD";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.Form_ADD_Load);
            this.grBImportnotedetail.ResumeLayout(false);
            this.grBImportnotedetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotedetail)).EndInit();
            this.grbInfoHDdetail.ResumeLayout(false);
            this.grbInfoHDdetail.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grNote.ResumeLayout(false);
            this.grNote.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNote)).EndInit();
            this.grbInfoDH.ResumeLayout(false);
            this.grbInfoDH.PerformLayout();
            this.grBTool.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adddetailDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox grBImportnotedetail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grNote;
        private Label lblSumHD;
        private Label lblNoteId;
        private System.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox tbHDid;
        private DateTimePicker dateTimePicker1;
        private Label lblSupplierId;
        private Label label1;
        private Button btnAdd;
        private Button btnExportPDF;
        private Button btnEdit;
        private GroupBox grBTool;
        private Button btnDelete;
        private Button btnSearch;
        private TextBox tbNhapId;
        private Button btnResetGridView;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblProductAmount;
        private System.Data.SqlClient.SqlCommand sqlCommand2;
        private Label lblQuantity;
        private Label lblPrice;
        private TextBox tbPrice;
        private TextBox tbQuantity;
        private GroupBox groupBox1;
        private Button btnDeleteDetail;
        private Button btnAdddetail;
        private BindingSource adddetailDTOBindingSource;
        private BindingSource addDTOBindingSource;
        private Button btnResetdetail;
        private Label lblnumnote;
        private Label lblDH;
        private Label lblNCC;
        private Label lblnumsupplier;
        private GroupBox grbInfoDH;
        private GroupBox grbInfoHDdetail;
        private Label lblnum;
        private Label lbldetailnum;
        private Label lbltotalmoney;
        private ComboBox cbproductname;
        private Label lblsoluong;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNotedetail;
        private Bunifu.UI.WinForms.BunifuDataGridView dgvNote;
        private ComboBox cbSupplierID;
        private DataGridViewTextBoxColumn notedetailIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn importQuantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn noteIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn supplierIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private TextBox tbsearch;
        private Button buttonsearch;
        private TextBox tbproductid;
        private Button button1;
        private TextBox textBox1;
        private Label label2;
    }
}