using Shoes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Shoes.GUI
{
    public partial class Form_ADD : Form
    {
        int index;
        int quantity;
        string HDiDcheck;
        string supplieridcheck;
        string datetimecheck;
        public Form_ADD()
        {
            InitializeComponent();
        }
        public void loadform()
        {
            dgvNote.DataSource = addBLL.Instance.getaddlist();
            lblnumnote.Text = addBLL.Instance.getnumnote();
            lblnumsupplier.Text = addBLL.Instance.getnumsupplier();
            cbSupplierID.DataSource = supplierBLL.Instance.getSupplierList();
            cbSupplierID.DisplayMember = "SupplierID";
            cbSupplierID.ValueMember = "SupplierID";
            dgvNote.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNote.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNote.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void loaddetailform()
        {
            dgvNotedetail.DataSource = adddetailBLL.Instance.getadddetaillist(tbHDid.Text);
            cbproductname.DataSource = shoesBLL.Instance.getShoesList();
            cbproductname.DisplayMember = "ProductName";
            cbproductname.ValueMember = "ProductName";
            tbproductid.Text = "";
            lblsoluong.Text = "0";
            tbPrice.Text = "";
            tbQuantity.Text = "";
            lblnum.Text = dgvNotedetail.Rows.Count.ToString();
            dgvNotedetail.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotedetail.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotedetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotedetail.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotedetail.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvNotedetail.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            lbltotalmoney.Text = adddetailBLL.Instance.gettotalhd(tbHDid.Text).ToString() + " VND";
        }
        private void Form_ADD_Load(object sender, EventArgs e)
        {
            loadform();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addBLL.Instance.checkinsertadd(tbHDid.Text, cbSupplierID.Text, dateTimePicker1.Text);
            loadform();
        }

        private void btnEdit_Click(object sender, EventArgs e) 
        {

            if (HDiDcheck == tbHDid.Text)
            {
                addBLL.Instance.updateadd(tbHDid.Text, cbSupplierID.Text, dateTimePicker1.Text);
            }
            else
            {
                MessageBox.Show("Không được thay đổi Mã Phiếu nhập");
            }
            loadform();
    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (HDiDcheck == tbHDid.Text)
            {
                addBLL.Instance.deleteadd(tbHDid.Text);
            }
            else
            {
                MessageBox.Show("Không được thay đổi Mã Phiếu nhập");
            }
            loadform();
        }

        private void btnResetGridView_Click(object sender, EventArgs e)
        {
            tbHDid.Text = "";
            cbSupplierID.Text = "";
            dateTimePicker1.Value = DateTime.Today;
            tbNhapId.Text = "";
            tbsearch.Text = "";
            loadform();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNote.DataSource = addBLL.Instance.search(tbNhapId.Text);
        }

        private void btnAdddetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                cbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                adddetailBLL.Instance.checkinsert(tbHDid.Text,tbproductid.Text,cbproductname.Text,Convert.ToInt32(lblsoluong.Text),float.Parse(tbPrice.Text),Convert.ToInt32(tbQuantity.Text),Convert.ToInt32(textBox1.Text));
            }
            loaddetailform();
        }

        private void btnDeleteDetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                cbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                adddetailBLL.Instance.deletedetail(tbHDid.Text, tbproductid.Text);
            }
            loaddetailform();
        }

        private void btnExportPDF_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                cbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                    // Khởi động chương trình Excel
                    COMExcel.Application exApp = new COMExcel.Application();
                    COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
                    COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
                    COMExcel.Range exRange;
                    int hang = 0, cot = 0;
                    string gender;
                    DataTable tblThongtinHang;
                    exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
                    exSheet = exBook.Worksheets[1];
                    // Định dạng chung
                    exRange = exSheet.Cells[1, 1];
                    exRange.Range["A1:Z300"].Font.Name = "Times new roman"; //Font chữ
                    exRange.Range["A1:B3"].Font.Size = 10;
                    exRange.Range["A1:B3"].Font.Bold = true;
                    exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
                    exRange.Range["A1:A1"].ColumnWidth = 7;
                    exRange.Range["B1:B1"].ColumnWidth = 15;
                    exRange.Range["A1:B1"].MergeCells = true;
                    exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A1:B1"].Value = "Shop B.A.";
                    exRange.Range["A2:B2"].MergeCells = true;
                    exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A2:B2"].Value = "Quận 5 - TP.HCM";
                    exRange.Range["A3:B3"].MergeCells = true;
                    exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["A3:B3"].Value = "Điện thoại: (04)38520214";
                    exRange.Range["C2:E2"].Font.Size = 16;
                    exRange.Range["C2:E2"].Font.Bold = true;
                    exRange.Range["C2:E2"].Font.ColorIndex = 3; //Màu đỏ
                    exRange.Range["C2:E2"].MergeCells = true;
                    exRange.Range["C2:E2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["C2:E2"].Value = "PHIẾU NHẬP";
                // Biểu diễn thông tin chung của hóa đơn bán
                    exRange.Range["B6:C9"].Font.Size = 12;
                    exRange.Range["B6:B6"].Value = "Mã phiếu nhập:";
                 
                    exRange.Range["C6:C6"].Value = HDiDcheck;
                    exRange.Range["B7:B7"].Value = "Mã nhà cung cấp:";
                    
                    exRange.Range["C7:C7"].Value = supplieridcheck;
                    exRange.Range["B8:B8"].Value = "Ngày nhập:";

                    exRange.Range["C8:C8"].Value = datetimecheck.ToString();
                    exRange.Range["C8:C8"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignLeft;
                    tblThongtinHang = adddetailBLL.Instance.getdetailfromnoteid(tbHDid.Text);
                    //Tạo dòng tiêu đề bảng
                    exRange.Range["A11:F11"].Font.Bold = true;
                    exRange.Range["A11:F11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                    exRange.Range["C11:F11"].ColumnWidth = 12;
                    exRange.Range["A11:A11"].Value = "STT";
                    exRange.Range["B11:B11"].Value = "Mã sản phẩm";
                    exRange.Range["B11:B11"].ColumnWidth = 17;
                    exRange.Range["C11:C11"].Value = "Tên sản phẩm";
                    exRange.Range["C11:C11"].ColumnWidth = 66;
                    exRange.Range["D11:D11"].Value = "Giá nhập";
                    exRange.Range["D11:D11"].ColumnWidth = 20;
                    exRange.Range["E11:E11"].Value = "Số lượng nhập";
                    exRange.Range["E11:E11"].ColumnWidth = 20;
                    exRange.Range["F11:F11"].Value = "Thành tiền";
                    exRange.Range["F11:F11"].ColumnWidth = 30;
                    for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
                    {
                        //Điền số thứ tự vào cột 1 từ dòng 12
                        exSheet.Cells[1][hang + 12] = hang + 1;
                        for (cot = 0; cot < tblThongtinHang.Columns.Count; cot++)
                        //Điền thông tin hàng từ cột thứ 2, dòng 12
                        {
                            exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                            //if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                        }
                    }

                    if (cot == 0)
                    {
                        //cot = 5;
                        MessageBox.Show("Phiếu nhập trống!");
                    }
                    else
                    {
                    exRange = exSheet.Cells[cot][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = "Tổng tiền:";
                    exRange = exSheet.Cells[cot + 1][hang + 14];
                    exRange.Font.Bold = true;
                    exRange.Value2 = lbltotalmoney.Text;
                    exSheet.Name = "PHIEUNHAP_"+tbHDid.Text;
                    exApp.Visible = true;
                    }
                }
            loaddetailform();
        }

        private void btnResetdetail_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                cbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                cbproductname.DataSource = shoesBLL.Instance.getShoesList();
                cbproductname.DisplayMember = "ProductName";
                cbproductname.ValueMember = "ProductName";
                tbproductid.Text = "";
                tbPrice.Text = "";
                lblsoluong.Text = "0";
                tbQuantity.Text = "";
            }
        }
        
        private void dgvNotedetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNotedetail.Rows.Count > 0)
            {
                index = e.RowIndex;
                if (index >= 0) 
                {
                    DataGridViewRow row = dgvNotedetail.Rows[index];
                    tbproductid.Text = row.Cells[1].Value.ToString();
                    cbproductname.Text = row.Cells[2].Value.ToString();
                    lblsoluong.Text = row.Cells[3].Value.ToString();
                    tbPrice.Text = row.Cells[4].Value.ToString();
                    tbQuantity.Text = row.Cells[5].Value.ToString();
                    quantity = Convert.ToInt32(row.Cells[5].Value.ToString());
                }
            }
        }

        private void dgvNote_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNote.Rows.Count > 0)
            {
                index = e.RowIndex;
                if (index >= 0)
                {
                    DataGridViewRow row = dgvNote.Rows[index];
                    tbHDid.Text = row.Cells[0].Value.ToString();
                    HDiDcheck = row.Cells[0].Value.ToString();
                    cbSupplierID.Text = row.Cells[1].Value.ToString();
                    supplieridcheck = row.Cells[1].Value.ToString();
                    dateTimePicker1.Text = row.Cells[2].Value.ToString();
                    datetimecheck = row.Cells[2].Value.ToString();
                    loaddetailform();
                }
            }
        }

        private void cbproductname_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbproductid.Text = adddetailBLL.Instance.getproductid(cbproductname.Text);
            lblsoluong.Text = adddetailBLL.Instance.getproductamount(cbproductname.Text).ToString();
        }

        private void buttonsearch_Click(object sender, EventArgs e)
        {
            if(tbsearch.Text != "")
            {
               dgvNote.DataSource = addBLL.Instance.search(tbsearch.Text);
            }
            else
            {
                MessageBox.Show("Cần nhập id phiếu nhập để tìm kiếm!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HDiDcheck != tbHDid.Text)
            {
                MessageBox.Show("Không được thay đổi Thông tin phiếu nhập!");
                tbHDid.Text = HDiDcheck;
                cbSupplierID.Text = supplieridcheck;
                dateTimePicker1.Text = datetimecheck;
            }
            else
            {
                adddetailBLL.Instance.updateShoes(tbproductid.Text,Convert.ToInt32(lblsoluong.Text) - quantity + Convert.ToInt32(tbQuantity.Text));
                adddetailBLL.Instance.updatenotedetail(tbHDid.Text,tbproductid.Text, Convert.ToInt32(lblsoluong.Text) - quantity + Convert.ToInt32(tbQuantity.Text),float.Parse(tbPrice.Text),Convert.ToInt32(tbQuantity.Text));
            }
            loaddetailform();
        }
    }
}
