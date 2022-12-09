using Shoes.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.GUI
{
    public partial class ThemKH : Form
    {
        HoaDonBUS hdbus = new HoaDonBUS();
        public ThemKH()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shoestoreDataSet);
        }

        private void ThemKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'shoestoreDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.shoestoreDataSet.customer);
            reset();
            DataTable a = hdbus.getInforCustomer();
            customerDataGridView.DataSource = a;
            labelSLKH.Text = "Số lượng khách hàng: " + a.Rows.Count;
        }
        private Boolean checkphone(string phone)
        {
            if (phone.Length == 10)
            {
                foreach (char c in phone)
                {
                    if (c < '0' || c > '9')
                        return false;
                }
                return true;
            }
            else
                return false;
        }
        private void btnThemKH_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text;
            if (!checkphone(phone))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!");
                txtPhone.Focus();
            }
            else
            {
                string s = DateTime.Now.ToString("dd/MM/yyyy");
                txtCustomerID.Text = hdbus.CreateKey("KH", s);
                string id = txtCustomerID.Text;
                string name = txtCustomerName.Text;
                int gender;
                if (checkGender.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 0;
                }
                if (id != "" && name != "" && phone != "")
                {
                    hdbus.insertKH(id, name, gender, phone);
                    DataTable a = hdbus.getInforCustomer();
                    customerDataGridView.DataSource = a;
                    labelSLKH.Text = "Số lượng khách hàng: " + a.Rows.Count;
                    reset();
                }
                else if (name == "")
                {
                    MessageBox.Show("Nhập tên khách hàng!");
                    txtCustomerName.Focus();
                }
                else
                {
                    MessageBox.Show("Nhập số điện thoại!");
                    txtPhone.Focus();
                }
            }
        }

        private void customerDataGridView_DoubleClick(object sender, EventArgs e)
        {
            string makh = customerDataGridView.CurrentRow.Cells[0].Value.ToString();
            if (makh != "")
            {
                if ((MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
                {

                    hdbus.deleteKH(makh);
                    DataTable a = hdbus.getInforCustomer();
                    customerDataGridView.DataSource = a;
                    labelSLKH.Text = "Số lượng khách hàng: " + a.Rows.Count;
                    reset();
                }
            }
        }
        private void reset()
        {
            txtCustomerID.Clear();
            txtCustomerName.Clear();
            txtPhone.Clear();
            checkGender.Checked = false;
        }
        private void btnEditInfor_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn có chắc chắn muốn chỉnh?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes))
            {
                string id = txtCustomerID.Text;
                string name = txtCustomerName.Text;
                int gender;
                if (checkGender.Checked == true)
                {
                    gender = 1;
                }
                else
                {
                    gender = 0;
                }
                string phone = txtPhone.Text;
                if(!checkphone(phone))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                    txtPhone.Focus();
                }
                else
                {
                    hdbus.updateKH(id, name, gender, phone);
                    DataTable a = hdbus.getInforCustomer();
                    customerDataGridView.DataSource = a;
                    reset();
                }
            }
        }

        private void customerDataGridView_Click(object sender, EventArgs e)
        {
            string makh = customerDataGridView.CurrentRow.Cells[0].Value.ToString();
            string name = customerDataGridView.CurrentRow.Cells[1].Value.ToString();
            string phone = customerDataGridView.CurrentRow.Cells[3].Value.ToString();
            bool gender;
            if (customerDataGridView.CurrentRow.Cells[2].Value.ToString() == "")
            {
                gender = false;
            }
            else
                gender = bool.Parse(customerDataGridView.CurrentRow.Cells[2].Value.ToString());
            txtCustomerID.Text = makh;
            txtCustomerName.Text = name;
            txtPhone.Text = phone;
            checkGender.Checked = gender;
        }
    }
}
