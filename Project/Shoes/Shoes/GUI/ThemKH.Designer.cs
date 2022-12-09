namespace Shoes.GUI
{
    partial class ThemKH
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
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label phoneLabel;
            this.shoestoreDataSet = new Shoes.GUI.shoestoreDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Shoes.GUI.shoestoreDataSetTableAdapters.customerTableAdapter();
            this.tableAdapterManager = new Shoes.GUI.shoestoreDataSetTableAdapters.TableAdapterManager();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.checkGender = new System.Windows.Forms.CheckBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnEditInfor = new System.Windows.Forms.Button();
            this.labelSLKH = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(69, 20);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(81, 13);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "ID khách hàng:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(69, 46);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(92, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Tên khách hàng: ";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Location = new System.Drawing.Point(69, 74);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(53, 13);
            genderLabel.TabIndex = 5;
            genderLabel.Text = "Giới tính: ";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(69, 102);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(76, 13);
            phoneLabel.TabIndex = 7;
            phoneLabel.Text = "Số điện thoại: ";
            // 
            // shoestoreDataSet
            // 
            this.shoestoreDataSet.DataSetName = "shoestoreDataSet";
            this.shoestoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.shoestoreDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.accountTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.employeeTableAdapter = null;
            this.tableAdapterManager.importnotedetailTableAdapter = null;
            this.tableAdapterManager.importnoteTableAdapter = null;
            this.tableAdapterManager.receiptdetailTableAdapter = null;
            this.tableAdapterManager.receiptTableAdapter = null;
            this.tableAdapterManager.shoesTableAdapter = null;
            this.tableAdapterManager.supplierTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Shoes.GUI.shoestoreDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "CustomerID", true));
            this.txtCustomerID.Enabled = false;
            this.txtCustomerID.Location = new System.Drawing.Point(179, 17);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(228, 20);
            this.txtCustomerID.TabIndex = 2;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Name", true));
            this.txtCustomerName.Location = new System.Drawing.Point(179, 43);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(228, 20);
            this.txtCustomerName.TabIndex = 4;
            // 
            // checkGender
            // 
            this.checkGender.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.customerBindingSource, "Gender", true));
            this.checkGender.Location = new System.Drawing.Point(179, 69);
            this.checkGender.Name = "checkGender";
            this.checkGender.Size = new System.Drawing.Size(228, 24);
            this.checkGender.TabIndex = 6;
            this.checkGender.Text = "Nam";
            this.checkGender.UseVisualStyleBackColor = true;
            // 
            // txtPhone
            // 
            this.txtPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "Phone", true));
            this.txtPhone.Location = new System.Drawing.Point(179, 99);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(228, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn3});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(22, 184);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(517, 229);
            this.customerDataGridView.TabIndex = 9;
            this.customerDataGridView.Click += new System.EventHandler(this.customerDataGridView_Click);
            this.customerDataGridView.DoubleClick += new System.EventHandler(this.customerDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Khách hàng";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 115;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên khách hàng";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Gender";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Giới tính";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 90;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.DarkRed;
            this.btnThemKH.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThemKH.Location = new System.Drawing.Point(213, 132);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(117, 36);
            this.btnThemKH.TabIndex = 10;
            this.btnThemKH.Text = "Thêm khách hàng";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnEditInfor
            // 
            this.btnEditInfor.BackColor = System.Drawing.Color.DarkRed;
            this.btnEditInfor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditInfor.Location = new System.Drawing.Point(363, 132);
            this.btnEditInfor.Name = "btnEditInfor";
            this.btnEditInfor.Size = new System.Drawing.Size(117, 36);
            this.btnEditInfor.TabIndex = 11;
            this.btnEditInfor.Text = "Chỉnh thông tin";
            this.btnEditInfor.UseVisualStyleBackColor = false;
            this.btnEditInfor.Click += new System.EventHandler(this.btnEditInfor_Click);
            // 
            // labelSLKH
            // 
            this.labelSLKH.AutoSize = true;
            this.labelSLKH.Location = new System.Drawing.Point(19, 144);
            this.labelSLKH.Name = "labelSLKH";
            this.labelSLKH.Size = new System.Drawing.Size(115, 13);
            this.labelSLKH.TabIndex = 12;
            this.labelSLKH.Text = "Số lượng khách hàng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(19, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nhấn đúp để xóa";
            // 
            // ThemKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(558, 425);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelSLKH);
            this.Controls.Add(this.btnEditInfor);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.customerDataGridView);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(genderLabel);
            this.Controls.Add(this.checkGender);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.txtPhone);
            this.Name = "ThemKH";
            this.Text = "Thêm Khách hàng";
            this.Load += new System.EventHandler(this.ThemKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.shoestoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private shoestoreDataSet shoestoreDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private shoestoreDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private shoestoreDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.CheckBox checkGender;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnEditInfor;
        private System.Windows.Forms.Label labelSLKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}