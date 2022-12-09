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

namespace Shoes.GUI
{
    public partial class TimKiemThongTinKH : Form
    {
        public static string idKHduocchon { get; set; }
        HoaDonBUS hdbus = new HoaDonBUS();
        public TimKiemThongTinKH()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoestoreDataSet);

        }

        private void TimKiemThongTinKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoestoreDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shoestoreDataSet.customer);
            customerDataGridView.AllowUserToAddRows = false;
            customerDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string phuongthuctim = cboLuaChon.Text;
            string noidung = txtThongTinTimKiem.Text;
            DataTable tb = new DataTable();
            if (phuongthuctim.ToLower() == "")
            {
                MessageBox.Show("Chọn phương thức tìm kiếm!");
            }
            else if(phuongthuctim.ToLower() == "mã khách hàng")
            {
                tb = hdbus.getInforCustomerByID(noidung);
                customerDataGridView.DataSource = tb;
            }
            else
            {
                tb = hdbus.getInforCustomerByPhone(noidung);
                customerDataGridView.DataSource = tb;
            }
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("Khách hàng không tồn tại!");
                btnThemKH.Enabled = true;
            }
            else
                btnThemKH.Enabled = true;
        }

        private void txtThongTinTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtThongTinTimKiem.Text == "")
            {
                DataTable tb = hdbus.getInforCustomer();
                customerDataGridView.DataSource = tb;
            }
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ThemKH newform = new ThemKH();
            newform.Show();
        }

        private void TimKiemThongTinKH_Click(object sender, EventArgs e)
        {
            DataTable a = hdbus.getInforCustomer();
            customerDataGridView.DataSource = a;
        }

        private void customerDataGridView_DoubleClick(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn muốn chọn mã khách hàng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                idKHduocchon = customerDataGridView.CurrentRow.Cells[0].Value.ToString();
                MessageBox.Show("Đã chọn khách hàng " + idKHduocchon);
                this.Close();
            }
        }
    }
}
