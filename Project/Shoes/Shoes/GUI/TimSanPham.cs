using Shoes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.GUI
{
    public partial class TimSanPham : Form
    {
        HoaDonBUS hdbus = new HoaDonBUS();
        public static string idDuocChon { get; set; }
        public TimSanPham()
        {
            InitializeComponent();
        }

        private void TimSanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoestoreDataSet.shoes' table. You can move, or remove it, as needed.
            this.shoesTableAdapter.Fill(this.shoestoreDataSet.shoes);

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DataTable a = new DataTable();
            string phuongthuc = cboPhuongThuc.Text.ToLower();
            string ndTimKiem = txtNoiDung.Text;
            if(phuongthuc != "" && ndTimKiem!="")
            {
                if (phuongthuc == "mã sản phẩm")
                {
                    a = hdbus.getByID(ndTimKiem);
                }
                else if (phuongthuc == "tên sản phẩm")
                {
                    a = hdbus.getByName(ndTimKiem);
                }
                else if (phuongthuc == "loại giày")
                {
                    a = hdbus.getByType(ndTimKiem);
                }
                else if (phuongthuc == "giới tính")
                {
                    //a = hdbus.getByGender(ndTimKiem);
                    string nd = ndTimKiem.ToLower();
                    if (ndTimKiem == "1" || nd == "true" || nd == "nam" || nd == "male")
                    {
                        a = hdbus.getByGender(true);
                    }
                    else if (ndTimKiem == "0" || nd == "false" || nd == "nu" || nd == "nữ" || nd == "female")
                    {
                        a = hdbus.getByGender(false);
                    }
                    else
                    {
                        MessageBox.Show("Nội dung tìm kiếm phải là nam/nữ (1/0)!");
                    }
                }
                else if (phuongthuc == "size")
                {
                    a = hdbus.getBySize(ndTimKiem);
                }
                else if (phuongthuc == "brand")
                {
                    a = hdbus.getByBrand(ndTimKiem);
                }
                else //gia ban
                {
                    a = hdbus.getByPrice(ndTimKiem);
                }
                shoesDataGridView.DataSource = a;
                labelSLSP.Text = "Số lượng sản phẩm: " + a.Rows.Count.ToString();
            }
        }

        private void checkConHang_CheckedChanged(object sender, EventArgs e)
        {
            if(((byte)checkConHang.CheckState) == 1)
            {
                MessageBox.Show("Các sản phẩm còn hàng!");
                DataTable a = new DataTable();
                a = hdbus.getByAmount();
            }
        }
        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {
            if(txtNoiDung.Text == "")
            {
                DataTable a = hdbus.getShoes();
                shoesDataGridView.DataSource = a;
            }
        }

        private void shoesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn chắc chắn muốn chọn sản phẩm này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                idDuocChon = shoesDataGridView.CurrentRow.Cells[0].Value.ToString();
                
                MessageBox.Show("Đã chọn sản phẩm " + idDuocChon);
                this.Close();
            }
        }
    }
}
