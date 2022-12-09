namespace Shoes.GUI
{
    partial class TimSanPham
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboPhuongThuc = new System.Windows.Forms.ComboBox();
            this.txtNoiDung = new System.Windows.Forms.TextBox();
            this.shoesDataGridView = new System.Windows.Forms.DataGridView();
            this.shoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.shoestoreDataSet = new Shoes.GUI.shoestoreDataSet();
            this.shoesTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.shoesTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.checkConHang = new System.Windows.Forms.CheckBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.labelSLSP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeGenderDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(45, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương thức tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(458, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nội dung tìm kiếm";
            // 
            // cboPhuongThuc
            // 
            this.cboPhuongThuc.FormattingEnabled = true;
            this.cboPhuongThuc.Items.AddRange(new object[] {
            "Mã sản phẩm",
            "Tên sản phẩm",
            "Loại giày",
            "Giới tính",
            "Size",
            "Brand",
            "Giá bán"});
            this.cboPhuongThuc.Location = new System.Drawing.Point(194, 29);
            this.cboPhuongThuc.Name = "cboPhuongThuc";
            this.cboPhuongThuc.Size = new System.Drawing.Size(225, 25);
            this.cboPhuongThuc.TabIndex = 2;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(584, 31);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(263, 23);
            this.txtNoiDung.TabIndex = 3;
            this.txtNoiDung.TextChanged += new System.EventHandler(this.txtNoiDung_TextChanged);
            // 
            // shoesDataGridView
            // 
            this.shoesDataGridView.AutoGenerateColumns = false;
            this.shoesDataGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.shoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.productTypeDataGridViewTextBoxColumn,
            this.typeGenderDataGridViewCheckBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.productPriceDataGridViewTextBoxColumn,
            this.brandDataGridViewTextBoxColumn,
            this.productAmountDataGridViewTextBoxColumn});
            this.shoesDataGridView.DataSource = this.shoesBindingSource;
            this.shoesDataGridView.Location = new System.Drawing.Point(15, 130);
            this.shoesDataGridView.Name = "shoesDataGridView";
            this.shoesDataGridView.RowHeadersWidth = 51;
            this.shoesDataGridView.Size = new System.Drawing.Size(1025, 264);
            this.shoesDataGridView.TabIndex = 4;
            this.shoesDataGridView.DoubleClick += new System.EventHandler(this.shoesDataGridView_DoubleClick);
            // 
            // shoesBindingSource
            // 
            this.shoesBindingSource.DataMember = "shoes";
            this.shoesBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // shoesTableAdapter
            // 
            this.shoesTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(883, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Còn hàng trong kho";
            // 
            // checkConHang
            // 
            this.checkConHang.AutoSize = true;
            this.checkConHang.Location = new System.Drawing.Point(1022, 94);
            this.checkConHang.Name = "checkConHang";
            this.checkConHang.Size = new System.Drawing.Size(18, 17);
            this.checkConHang.TabIndex = 6;
            this.checkConHang.UseVisualStyleBackColor = true;
            this.checkConHang.CheckedChanged += new System.EventHandler(this.checkConHang_CheckedChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkRed;
            this.btnTimKiem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTimKiem.Location = new System.Drawing.Point(461, 79);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(99, 44);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // labelSLSP
            // 
            this.labelSLSP.AutoSize = true;
            this.labelSLSP.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelSLSP.Location = new System.Drawing.Point(12, 88);
            this.labelSLSP.Name = "labelSLSP";
            this.labelSLSP.Size = new System.Drawing.Size(138, 17);
            this.labelSLSP.TabIndex = 9;
            this.labelSLSP.Text = "Số lượng sản phẩm: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhấn đúp để chọn sản phẩm";
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "Mã sản phẩm";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Tên sản phẩm";
            this.productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // productTypeDataGridViewTextBoxColumn
            // 
            this.productTypeDataGridViewTextBoxColumn.DataPropertyName = "ProductType";
            this.productTypeDataGridViewTextBoxColumn.HeaderText = "Loại giày";
            this.productTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productTypeDataGridViewTextBoxColumn.Name = "productTypeDataGridViewTextBoxColumn";
            this.productTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // typeGenderDataGridViewCheckBoxColumn
            // 
            this.typeGenderDataGridViewCheckBoxColumn.DataPropertyName = "TypeGender";
            this.typeGenderDataGridViewCheckBoxColumn.HeaderText = "Giới tính";
            this.typeGenderDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.typeGenderDataGridViewCheckBoxColumn.Name = "typeGenderDataGridViewCheckBoxColumn";
            this.typeGenderDataGridViewCheckBoxColumn.Width = 70;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.Width = 50;
            // 
            // productPriceDataGridViewTextBoxColumn
            // 
            this.productPriceDataGridViewTextBoxColumn.DataPropertyName = "ProductPrice";
            this.productPriceDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.productPriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productPriceDataGridViewTextBoxColumn.Name = "productPriceDataGridViewTextBoxColumn";
            this.productPriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // brandDataGridViewTextBoxColumn
            // 
            this.brandDataGridViewTextBoxColumn.DataPropertyName = "Brand";
            this.brandDataGridViewTextBoxColumn.HeaderText = "Brand";
            this.brandDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.brandDataGridViewTextBoxColumn.Name = "brandDataGridViewTextBoxColumn";
            this.brandDataGridViewTextBoxColumn.Width = 125;
            // 
            // productAmountDataGridViewTextBoxColumn
            // 
            this.productAmountDataGridViewTextBoxColumn.DataPropertyName = "ProductAmount";
            this.productAmountDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.productAmountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productAmountDataGridViewTextBoxColumn.Name = "productAmountDataGridViewTextBoxColumn";
            this.productAmountDataGridViewTextBoxColumn.Width = 80;
            // 
            // TimSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1052, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelSLSP);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.checkConHang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.shoesDataGridView);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.cboPhuongThuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "TimSanPham";
            this.Text = "TimSanPham";
            this.Load += new System.EventHandler(this.TimSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboPhuongThuc;
        private System.Windows.Forms.TextBox txtNoiDung;
        private System.Windows.Forms.DataGridView shoesDataGridView;
        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource shoesBindingSource;
        private shoestoreDataSetTableAdapters.shoesTableAdapter shoesTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkConHang;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label labelSLSP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn typeGenderDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productAmountDataGridViewTextBoxColumn;
    }
}