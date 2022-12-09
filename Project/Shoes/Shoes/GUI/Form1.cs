using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;
using COMExcel = Microsoft.Office.Interop.Excel;
using System.Globalization;
using Shoes.BLL;
using Shoes.DTO;

namespace Shoes.GUI
{
    public partial class Form1 : Form
    {
        HoaDonBUS hdBus = new HoaDonBUS();
        DataTable tbchitiethoadon = new DataTable();
        public Form1()
        {
            InitializeComponent();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoestoreDataSet.shoes' table. You can move, or remove it, as needed.
            this.shoesTableAdapter.Fill(this.shoestoreDataSet.shoes);
            // TODO: This line of code loads data into the 'shoestoreDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shoestoreDataSet.customer);
            // TODO: This line of code loads data into the 'shoestoreDataSet.importnotedetail' table. You can move, or remove it, as needed.
            this.importnotedetailTableAdapter.Fill(this.shoestoreDataSet.importnotedetail);
            // TODO: This line of code loads data into the 'shoestoreDataSet.shoes' table. You can move, or remove it, as needed.
            this.shoesTableAdapter.Fill(this.shoestoreDataSet.shoes);
            // TODO: This line of code loads data into the 'shoestoreDataSet.receiptdetail' table. You can move, or remove it, as needed.
            this.receiptdetailTableAdapter.Fill(this.shoestoreDataSet.receiptdetail);
            // TODO: This line of code loads data into the 'shoestoreDataSet.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.shoestoreDataSet.employee);
            // TODO: This line of code loads data into the 'shoestoreDataSet.receipt' table. You can move, or remove it, as needed.
            this.receiptTableAdapter.Fill(this.shoestoreDataSet.receipt);
            // TODO: This line of code loads data into the 'shoestoreDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shoestoreDataSet.customer);
            filldatacomboReceiptID();
            ResetValues();
            btnXoaHoaDon.Enabled = false;
            if(txtMaHoaDon.Text == "")
            {
                btnInHoaDon.Enabled = false;
                btnReset.Enabled = true;
                btnThemSanPham.Enabled = false;
            }
        }
        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            //dateReceipt.Format = DateTimePickerFormat.Short;
            DateTime dt = DateTime.ParseExact(dateReceipt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string s = dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            resetdatagridview();
            if (cboMaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy chọn mã nhân viên!");
                cboMaNhanVien.Focus();
            }
            else if (cboMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn mã khách hàng");
                cboMaKhachHang.Focus();
            }
            else
            {
                txtMaHoaDon.Text = hdBus.CreateKey("HD", s);
                btnThemHoaDon.Enabled = false;
                btnInHoaDon.Enabled = false;
                btnThemSanPham.Enabled = true;
                btnXoaHoaDon.Enabled = true;
                btnReset.Enabled = true;
                HoaDonDTO hdmoi = new HoaDonDTO(txtMaHoaDon.Text, cboMaKhachHang.Text, cboMaNhanVien.Text, dt, 0);
                hdBus.InsertReceipt(hdmoi);
                filldatacomboReceiptID();
            }
            dateReceipt.Format = DateTimePickerFormat.Custom;
            dateReceipt.CustomFormat = "dd/MM/yyyy";
        }
        private void resetdatagridview()
        {
            DataTable tb = new DataTable();
            receiptdetailDataGridView.DataSource = tb;
        }
        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg, tonkho;
            if (txtSLTonKho.Text == "")
                tonkho = 0;
            else
                tonkho = Convert.ToDouble(txtSLTonKho.Text);

            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);

            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);

            if(sl > tonkho)
            {
                if(cboMaSanPham.Text == "")
                {
                    MessageBox.Show("Hãy chọn sản phẩm trước!");
                }
                else
                {
                    MessageBox.Show("Số lượng muốn mua vượt quá số lượng cho phép!");
                    txtSoLuong.Text = "";
                    txtSoLuong.Focus();
                }
            }
            else
            {
                tt = sl * dg;
                txtThanhTien.Text = tt.ToString();
            }
        }
        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSoLuong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSoLuong.Text);

            if (txtDonGia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDonGia.Text);
            tt = sl * dg;
            txtThanhTien.Text = tt.ToString();
        }
        private void filldatacomboReceiptID ()
        {
             DataTable tb = new DataTable();
             tb = hdBus.fillcboMadonhan();
             cboMaHoaDon.DataSource = tb;
             cboMaHoaDon.ValueMember = "receiptid";
             cboMaHoaDon.DisplayMember = "receiptid";
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            btnReset.Enabled = true;
            btnInHoaDon.Enabled = true;
            btnXoaHoaDon.Enabled = true;
            cboMaKhachHang.Enabled = true;
            cboMaNhanVien.Enabled = true;
            tbchitiethoadon = hdBus.loadDataGridView(cboMaHoaDon.Text);
            receiptdetailDataGridView.DataSource = tbchitiethoadon;
            receiptdetailDataGridView.AllowUserToAddRows = false;
            receiptdetailDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            txtMaHoaDon.Text = cboMaHoaDon.Text;
            DataTable tb = new DataTable();
            tb = hdBus.searchByReceiptID(cboMaHoaDon.Text);
            cboMaKhachHang.Text = tb.Rows[0].Field<string>("customerid");
            cboMaNhanVien.Text = tb.Rows[0].Field<string>("employeeid");
            btnThemHoaDon.Enabled = false;
            btnThemSanPham.Enabled = true;
            dateReceipt.Text = tb.Rows[0].Field<DateTime>("receiptdate").ToString();
            txtTongCong.Text = tb.Rows[0].Field<double>("totalmoney").ToString();
            hienthislsanphamtronghoadon();
        }
        private void hienthislsanphamtronghoadon()
        {
            DataTable hiensanpham = hdBus.loadDataGridView(txtMaHoaDon.Text);
            labelHienSLSP.Text = "Số lượng sản phẩm: " + hiensanpham.Rows.Count;
        }
        private void btnThemSanPham_Click(object sender, EventArgs e)
        {
            float tong;
            DataTable dt = new DataTable();
            
            cboMaKhachHang.Enabled = true;
            cboMaNhanVien.Enabled = true;
            dateReceipt.Enabled = true;
            if (txtTongCong.Text != "")
            {
               tong = float.Parse(txtTongCong.Text);
            }
            else
            {
                tong = 0;
            }
            if(cboMaSanPham.Text != "" && txtSoLuong.Text != "")
            {
                tong += Int32.Parse(txtSoLuong.Text) * float.Parse(txtDonGia.Text);
                txtTongCong.Text = tong.ToString();
                ChiTietHoaDonDTO hdmoi = new ChiTietHoaDonDTO(txtMaHoaDon.Text, cboMaSanPham.Text, txtTenSanPham.Text, Convert.ToInt32(txtSoLuong.Text), float.Parse(txtDonGia.Text), float.Parse(txtThanhTien.Text));
                if(hdBus.isduplicationProductid(hdmoi) == true)
                {
                    DataTable amount = new DataTable();
                    amount = hdBus.getAmount(txtMaHoaDon.Text, cboMaSanPham.Text);
                    int currentAmount = amount.Rows[0].Field<int>("productamount");
                    dt = hdBus.updateAmountProduct(hdmoi, Int32.Parse(txtSoLuong.Text), currentAmount);
                }
                else
                {
                    dt = hdBus.InsertReceiptDetail(hdmoi);
                }
                receiptdetailDataGridView.DataSource = dt;
                btnInHoaDon.Enabled = true;
                btnReset.Enabled = true;
                hdBus.UpdateReceiptTotalMoney(tong.ToString(), txtMaHoaDon.Text);
                int slTonKhoCu = Int32.Parse(txtSLTonKho.Text);
                int slSPduocmua = Int32.Parse(txtSoLuong.Text);
                int sltonkhomoi = slTonKhoCu - slSPduocmua;
                if (hdBus.updateSLHanTon(cboMaSanPham.Text, sltonkhomoi) == true)
                {
                    MessageBox.Show("Cập nhật số lượng hàng tồn thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật số lượng hàng tồn không thành công!");
                }
                cboMaSanPham.Text = "";
                txtSoLuong.Text = "";
                txtSLTonKho.Text = "0";
            }
            else if(cboMaSanPham.Text == "")
            {
                MessageBox.Show("Hãy chọn sản phẩm!");
                cboMaSanPham.Focus();
            }
            else
            {
                MessageBox.Show("Hãy điền số lượng!");
                txtSoLuong.Focus();
            }
            btnTimKiem.Enabled = true;
            btnXoaHoaDon.Enabled = true;
            hienthislsanphamtronghoadon();
        }
        private void ResetValues()
        {
            txtMaHoaDon.Text = "";
            dateReceipt.Text = DateTime.Now.ToShortDateString();
            cboMaNhanVien.Text = "";
            cboMaKhachHang.Text = "";
            txtTongCong.Text = "0";
            labelBangChu.Text = "Bằng chữ: ";
            cboMaSanPham.Text = "";
            txtSoLuong.Text = "";
            txtThanhTien.Text = "0";
            txtSLTonKho.Text = "0";
            labelHienSLSP.Text = "Số lượng sản phẩm: ";
            resetdatagridview();
        }
        private void txtTongCong_TextChanged(object sender, EventArgs e)
        {
            if(txtTongCong.Text == "" || txtTongCong.Text == "0")
            {
                labelBangChu.Text = "Bằng chữ: ";
            }
            else
            {
                double num = Double.Parse(txtTongCong.Text);
                labelBangChu.Text = "Bằng chữ: " + hdBus.NumberToText(num, true);
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetValues();
            resetdatagridview();
            dateReceipt.Enabled = true;
            cboMaNhanVien.Enabled = true;
            cboMaKhachHang.Enabled = true;
            btnThemHoaDon.Enabled = true;
            btnInHoaDon.Enabled = false;
            btnThemSanPham.Enabled = false;
            btnXoaHoaDon.Enabled = false;
            btnReset.Enabled = true;
            btnTimKiem.Enabled = true;
            cboMaNhanVien.Enabled = true;
            cboMaKhachHang.Enabled = true;
            btnSuaSanPham.Enabled = true;
        }
        private void btnXoaHoaDon_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(hdBus.DeleteReceiptDetail(txtMaHoaDon.Text))
                {
                    if(hdBus.DeleteReceipt(txtMaHoaDon.Text))
                    {
                        MessageBox.Show("Xóa hóa đơn thành công!");
                        resetdatagridview();
                        ResetValues();
                        filldatacomboReceiptID();
                        btnXoaHoaDon.Enabled = false;
                        btnThemHoaDon.Enabled = true;
                        btnThemSanPham.Enabled = false;
                        btnReset.Enabled = true;
                        btnInHoaDon.Enabled = false;
                        btnTimKiem.Enabled = true;
                        cboMaNhanVien.Enabled = true;
                        cboMaKhachHang.Enabled = true;
                    }
                }
            }
        }
        private void receiptdetailDataGridView_DoubleClick(object sender, EventArgs e)
        {
            
            string MaHangxoa;
            float ThanhTienxoa, tong, tongmoi;

            if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                //Xóa hàng và cập nhật lại số lượng hàng 
                MaHangxoa = receiptdetailDataGridView.CurrentRow.Cells[0].Value.ToString();
                int slspxoa = Int32.Parse(receiptdetailDataGridView.CurrentRow.Cells[2].Value.ToString());
                //SoLuongxoa = float.Parse(receiptdetailDataGridView.CurrentRow.Cells["productamount"].Value.ToString());
                ThanhTienxoa = float.Parse(receiptdetailDataGridView.CurrentRow.Cells[4].Value.ToString());
                tong = float.Parse(txtTongCong.Text);
                if (hdBus.DeleteOneRowReceiptDetail(txtMaHoaDon.Text, MaHangxoa))
                {
                    tongmoi = tong - ThanhTienxoa;
                    txtTongCong.Text = tongmoi.ToString();
                    hdBus.UpdateReceiptTotalMoney(tongmoi.ToString(), txtMaHoaDon.Text);
                    DataTable tb = hdBus.loadDataGridView(txtMaHoaDon.Text);
                    receiptdetailDataGridView.DataSource = tb;
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    DataTable a = new DataTable();
                    a = hdBus.getSLHanTon(MaHangxoa);
                    int slhanton = a.Rows[0].Field<int>("productamount");
                    int slhantonmoi = slhanton + slspxoa;
                    if(hdBus.updateSLHanTon(MaHangxoa, slhantonmoi))
                    {
                        MessageBox.Show("Cập nhật số lượng hàng tồn thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật số lượng hàng tồn không thành công!");
                    }
                    
                    cboMaSanPham.Text = "";
                    txtSoLuong.Text = "";
                    txtSLTonKho.Text = "0";
                    hienthislsanphamtronghoadon();
                }
            }
        }
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            int hang = 0, cot = 0;
            string gender;
            DataTable tblThongtinHD, tblThongtinHang;
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
            exRange.Range["C2:E2"].Value = "HÓA ĐƠN BÁN";
            // Biểu diễn thông tin chung của hóa đơn bán
            tblThongtinHD = hdBus.LayThongTinHD(txtMaHoaDon.Text);
            exRange.Range["B6:C9"].Font.Size = 12;
            exRange.Range["B6:B6"].Value = "Mã hóa đơn:";
            exRange.Range["C6:E6"].MergeCells = true;
            exRange.Range["C6:E6"].Value = tblThongtinHD.Rows[0][0].ToString();
            exRange.Range["B7:B7"].Value = "Khách hàng:";
            exRange.Range["C7:E7"].MergeCells = true;
            exRange.Range["C7:E7"].Value = tblThongtinHD.Rows[0][3].ToString();
            exRange.Range["B8:B8"].Value = "Giới tính:";
            exRange.Range["C8:E8"].MergeCells = true;
            if(tblThongtinHD.Rows[0][4].ToString().ToLower() == "true")
            {
                gender = "Nam";
            }
            else
            {
                gender = "Nữ";
            }
            exRange.Range["C8:E8"].Value = gender;
            exRange.Range["B9:B9"].Value = "Điện thoại:";
            exRange.Range["C9:E9"].MergeCells = true;
            exRange.Range["C9:E9"].Value = "'" + tblThongtinHD.Rows[0][5].ToString();
            //Lấy thông tin các mặt hàng
            
            tblThongtinHang = hdBus.loadDataGridView(txtMaHoaDon.Text);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A11:G11"].Font.Bold = true;
            exRange.Range["A11:G11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C11:G11"].ColumnWidth = 12;
            exRange.Range["A11:A11"].Value = "STT";
            exRange.Range["B11:B11"].Value = "Mã sản phẩm";
            exRange.Range["B11:B11"].ColumnWidth = 17;
            exRange.Range["C11:C11"].Value = "Tên sản phẩm";
            exRange.Range["C11:C11"].ColumnWidth = 66;
            exRange.Range["D11:D11"].Value = "Số lượng";
            exRange.Range["E11:E11"].Value = "Đơn giá";
            exRange.Range["F11:F11"].Value = "Thành tiền";
            exRange.Range["G11:G11"].Value = "Size";
            int numORow = tblThongtinHang.Rows.Count;
            int[] size = new int[numORow];
            DataTable a = new DataTable();
            for(int i = 0; i < tblThongtinHang.Rows.Count; i++)
            {
                a = hdBus.getSize(tblThongtinHang.Rows[i][0].ToString());
                //MessageBox.Show(a.Rows[0].Field<int>("size").ToString());
                size[i] = a.Rows[0].Field<int>("size");
            }
            for (hang = 0; hang < tblThongtinHang.Rows.Count; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 12
                exSheet.Cells[1][hang + 12] = hang + 1;
                for (cot = 0; cot <= tblThongtinHang.Columns.Count; cot++)
                //Điền thông tin hàng từ cột thứ 2, dòng 12
                {
                    if(cot < tblThongtinHang.Columns.Count)
                    {
                        exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString();
                    }
                    else
                    {
                        exSheet.Cells[cot + 2][hang + 12] = size[hang];
                    }
                    //if (cot == 3) exSheet.Cells[cot + 2][hang + 12] = tblThongtinHang.Rows[hang][cot].ToString() + "%";
                }
            }
            if(cot == 0)
            {
                //cot = 5;
                MessageBox.Show("Hãy mua sản phẩm trước!");
            }
            else
            {
                exRange = exSheet.Cells[cot][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = "Tổng tiền:";
                exRange = exSheet.Cells[cot + 1][hang + 14];
                exRange.Font.Bold = true;
                exRange.Value2 = tblThongtinHD.Rows[0][2].ToString();
                exRange = exSheet.Cells[1][hang + 15]; //Ô A1 
                exRange.Range["A1:G1"].MergeCells = true;
                exRange.Range["A1:G1"].Font.Bold = true;
                exRange.Range["A1:G1"].Font.Italic = true;
                exRange.Range["A1:G1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignRight;
                exRange.Range["A1:G1"].Value = labelBangChu.Text;
                exRange = exSheet.Cells[4][hang + 17]; //Ô A1 
                exRange.Range["A1:C1"].MergeCells = true;
                exRange.Range["A1:C1"].Font.Italic = true;
                exRange.Range["A1:C1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                DateTime d = Convert.ToDateTime(tblThongtinHD.Rows[0][1]);
                exRange.Range["A1:C1"].Value = "TP.HCM, ngày " + d.Day + " tháng " + d.Month + " năm " + d.Year;
                exRange.Range["A2:C2"].MergeCells = true;
                exRange.Range["A2:C2"].Font.Italic = true;
                exRange.Range["A2:C2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A2:C2"].Value = "Nhân viên bán hàng";
                exRange.Range["A6:C6"].MergeCells = true;
                exRange.Range["A6:C6"].Font.Italic = true;
                exRange.Range["A6:C6"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
                exRange.Range["A6:C6"].Value = tblThongtinHD.Rows[0][6];
                exSheet.Name = "Hóa đơn nhập";
                exApp.Visible = true;
            }
        }
        private void btnSuaSanPham_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chọn sản phẩm đã tồn tại!");
            if(cboMaSanPham.Text != "" && txtSoLuong.Text != "" && txtMaHoaDon.Text != "")
            {

                if (MessageBox.Show("Bạn chắc chắn muốn sửa sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        DataTable tb1 = hdBus.getmoney(txtMaHoaDon.Text, cboMaSanPham.Text);
                        //MessageBox.Show(tb1.Rows[0].Field<float>("money").ToString());
                        double thanhtientruockhidoi = tb1.Rows[0].Field<double>("money");
                        DataTable b = hdBus.getproductamount(txtMaHoaDon.Text, cboMaSanPham.Text);
                        int slspduocmuatruocdo = b.Rows[0].Field<int>("productamount");
                        ChiTietHoaDonDTO hd = new ChiTietHoaDonDTO(txtMaHoaDon.Text, cboMaSanPham.Text, txtTenSanPham.Text, Int32.Parse(txtSoLuong.Text), float.Parse(txtDonGia.Text), float.Parse(txtThanhTien.Text));
                        if (hdBus.UpdateReceiptDetail(hd) == true)
                        {
                            //tinh toan lai tong tien
                            float tongcongcu = float.Parse(txtTongCong.Text);
                            double tongcongmoi, chenhlech;
                            float thanhtienmoi = float.Parse(txtThanhTien.Text);
                            MessageBox.Show("Tổng hóa đơn trước khi chỉnh sửa: " + tongcongcu.ToString());
                            chenhlech = Math.Abs(thanhtientruockhidoi - thanhtienmoi);
                            tongcongmoi = tongcongcu - chenhlech;
                            MessageBox.Show("Tổng hóa đơn sau khi chỉnh sửa: " + tongcongmoi.ToString());
                            //resetdatagridview();
                            DataTable tb = new DataTable();
                            tb = hdBus.loadDataGridView(txtMaHoaDon.Text);
                            receiptdetailDataGridView.DataSource = tb;
                            //update tong tien cho receipt table
                            txtTongCong.Text = tongcongmoi.ToString();
                            hdBus.UpdateReceiptTotalMoney(txtTongCong.Text, txtMaHoaDon.Text);
                            //update sl han ton kho
                            //DataTable a = hdBus.getSLHanTon(cboMaSanPham.Text);
                            int slhantoncu = Int32.Parse(txtSLTonKho.Text) + slspduocmuatruocdo;
                            int slspduocmua = Int32.Parse(txtSoLuong.Text);
                            int slhantonmoi = slhantoncu - slspduocmua;
                            hdBus.updateSLHanTon(cboMaSanPham.Text, slhantonmoi);

                            cboMaSanPham.Text = "";
                            txtSoLuong.Text = "";
                            txtSLTonKho.Text = "0";
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Sản phẩm không tồn tại!");
                    }
                    
                }
            }
            else if(cboMaSanPham.Text == "")
            {              
                MessageBox.Show("Bạn chưa chọn sản phẩm!");
                cboMaSanPham.Focus();
            }
            else if(txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số lượng!");
                txtSoLuong.Focus();
            }
            else
            {
                MessageBox.Show("Hãy chọn mã hóa đơn trước!");
            }
        }
        private void btnSuaHoaDon_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.ParseExact(dateReceipt.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //string s = dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            if (cboMaNhanVien.Text!="" && cboMaKhachHang.Text!="" && txtMaHoaDon.Text != "")
            {
                HoaDonDTO hd = new HoaDonDTO(txtMaHoaDon.Text, cboMaKhachHang.Text, cboMaNhanVien.Text, dt, float.Parse(txtTongCong.Text));
                hdBus.UpdateReceipt(hd);
            }
            else if(cboMaNhanVien.Text == "")
            {
                MessageBox.Show("Hãy chọn mã khách hàng!");
                cboMaKhachHang.Focus();
            }
            else if(cboMaKhachHang.Text == "")
            {
                MessageBox.Show("Hãy chọn mã nhân viên!");
                cboMaNhanVien.Focus();
            }
            else
            {
                MessageBox.Show("Hãy chọn mã hóa đơn!");
                cboMaHoaDon.Focus();
            }
            dateReceipt.Format = DateTimePickerFormat.Custom;
            dateReceipt.CustomFormat = "dd/MM/yyyy";
        }
        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (Convert.ToInt32(e.KeyChar) == 8))
                e.Handled = false;
            else e.Handled = true;
        }

        private void cboMaHoaDon_DataSourceChanged(object sender, EventArgs e)
        {
            DataTable tb = new DataTable();
            tb = hdBus.fillcboMadonhan();
            int sl = tb.Rows.Count;
            labelSoluongHD.Text = "Số lượng hóa đơn: " + sl;
        }

        private void btnTKKhachHang_Click(object sender, EventArgs e)
        {
            TimKiemThongTinKH form = new TimKiemThongTinKH();
            form.Show();
        }
        private void cboMaSanPham_TextChanged(object sender, EventArgs e)
        {
            string b = cboMaSanPham.Text;
            if (b != "")
            {
                DataTable a = new DataTable();
                a = hdBus.getSLHanTon(b);
                string slhanton = a.Rows[0].Field<int>("productamount").ToString();
                txtSLTonKho.Text = slhanton;
            }
            else
            {
                txtSLTonKho.Text = "0";
                txtSize.Text = "";
            }
        }

        private void btnSearchSP_Click(object sender, EventArgs e)
        {
            TimSanPham newform = new TimSanPham();
            newform.Show();
        }

        private void cboMaKhachHang_Click(object sender, EventArgs e)
        {
            DataTable a = hdBus.getInforCustomer();
            cboMaKhachHang.DataSource = a;
            cboMaKhachHang.DisplayMember = "customerid";
            cboMaKhachHang.ValueMember = "customerid";
        }
        private void cboMaKhachHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMaKhachHang.Text != "")
            {
                DataTable b = hdBus.getInforCustomerByID(cboMaKhachHang.Text);
                txtTenKhachHang.Text = b.Rows[0].Field<string>("name");
                txtDienThoai.Text = b.Rows[0].Field<string>("phone");
                bool gender = b.Rows[0].Field<bool>("gender");
                if (gender)
                {
                    cboxGioiTinh.Checked = true;
                }
                else
                {
                    cboxGioiTinh.Checked = false;
                }
            }
        }
        private void Form1_Click(object sender, EventArgs e)
        {
            cboMaKhachHang.Text = TimKiemThongTinKH.idKHduocchon;
            cboMaSanPham.Text = TimSanPham.idDuocChon;
        }
    }
}
