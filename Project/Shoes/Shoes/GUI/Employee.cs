using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.BLL;
using Shoes.DAL;
using System.IO;
using System.Reflection;
using System.Xml.Serialization;
using Shoes.GUI;
namespace Shoes.GUI
{
    public partial class Employee : Form
    {

        public Employee()
        {
            InitializeComponent();

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            Loadform(); 
            GetCellClick(0);
        }
        public void Loadform()
        {
            ListEmployee.DataSource = EmployeeBUS.Instance.LoadListEmployee();
            ListEmployee.Columns[0].HeaderText = "Mã NV";
            ListEmployee.Columns[0].Width = 65;
            ListEmployee.Columns[1].HeaderText = "Họ tên ";
            ListEmployee.Columns[1].Width = 150;
            ListEmployee.Columns[2].HeaderText = "Ngày sinh";
            ListEmployee.Columns[2].Width = 150;
            ListEmployee.Columns[3].HeaderText = "Giới tính";
            ListEmployee.Columns[3].Width = 49;
            ListEmployee.Columns[4].HeaderText = "Ngày tham gia";
            ListEmployee.Columns[4].Width = 150;
            ListEmployee.Columns[5].HeaderText = "Số điện thoại";
            ListEmployee.Columns[5].Width = 100;
            cbxchoose.SelectedIndex= 0;
            lblSum.Text = EmployeeBUS.Instance.getEmployeeCount().ToString();
            ListEmployee.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListEmployee.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListEmployee.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListEmployee.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListEmployee.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListEmployee.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;

            ListEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListEmployee.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListEmployee.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListEmployee.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListEmployee.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListEmployee.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        public void GetCellClick(int index)
        {
            index = ListEmployee.CurrentCell.RowIndex;
            if (index >= 0)
            {
                lblemployeeID.Text = ListEmployee.Rows[index].Cells[0].Value.ToString();
                txbemployeeName.Text = ListEmployee.Rows[index].Cells[1].Value.ToString();
                dtpemployeeDateofBirth.Text = ListEmployee.Rows[index].Cells[2].Value.ToString();
                if (Convert.ToInt32(ListEmployee.Rows[index].Cells[3].Value) == 1)
                {
                    txbemployeeGender.Text = "Nam";
                }
                else
                {
                    txbemployeeGender.Text = "Nữ";
                }
                dtpemployeeDatejoined.Text = ListEmployee.Rows[index].Cells[4].Value.ToString();
                txbemployeePhone.Text = ListEmployee.Rows[index].Cells[5].Value.ToString();

            }

        }

        private void ListEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ListEmployee.CurrentCell.RowIndex;
            GetCellClick(index);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {

            EmployeeDetail detail = new EmployeeDetail(lblemployeeID.Text, txbemployeeName.Text, txbemployeePhone.Text, txbemployeeGender.Text, lblQuyen.Text, dtpemployeeDateofBirth.Value, dtpemployeeDatejoined.Value, pbAvartar.Text);
            
            detail.formName = "Chi tiết nhân viên";
            detail.Show();
        }

        private void lblemployeeID_TextChanged(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> office = EmployeeDetailBUS.Instance.GetEmployeeDetailbyID(lblemployeeID.Text);
            foreach (EmployeeDetailDTO item in office)
            {
                lblQuyen.Text = item.Office;
                if (lblemployeeID.Text != null)
                    item.EmployeeID = lblemployeeID.Text;

                if (item.EmployeeImage == null)
                {
                    MessageBox.Show("item.EmployeeImage = null");
                    pbAvartar.Image = Shoes.Properties.Resources.avtdefault;
                    
                    pbAvartar.Refresh();
                }
                else
                {
                    pbAvartar.Refresh();
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                    string path = projectDirectory + "\\Shoes\\Resources\\" + item.EmployeeImage;
                    pbAvartar.Image = Image.FromFile(path);
                    pbAvartar.Text = path;


                }

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = EmployeeBUS.Instance.autoGenerateEmployeeId();
            lblemployeeID.Text = EmployeeBUS.Instance.autoGenerateEmployeeId();
            txbemployeeName.Text = "";
            txbemployeePhone.Text = "";
            txbemployeeGender.Text = "";
            lblQuyen.Text = "";
            dtpemployeeDateofBirth.Value = DateTime.Now;
            dtpemployeeDatejoined.Value = DateTime.Now;
            pbAvartar.Text = "";
            EmployeeDetail detail = new EmployeeDetail(lblemployeeID.Text, txbemployeeName.Text, txbemployeePhone.Text, txbemployeeGender.Text, lblQuyen.Text, dtpemployeeDateofBirth.Value, dtpemployeeDatejoined.Value, pbAvartar.Text);
            detail.formName = "Thêm nhân viên";
            detail.ShowDialog();
            Loadform();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            EmployeeDetail detail = new EmployeeDetail(lblemployeeID.Text, txbemployeeName.Text, txbemployeePhone.Text, txbemployeeGender.Text, lblQuyen.Text, dtpemployeeDateofBirth.Value, dtpemployeeDatejoined.Value, pbAvartar.Text);
            detail.formName = "Sửa thông tin";
            detail.Show();
            Loadform();
            
        }
        public string temp2;
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(lblemployeeID.Text == temp2)
                {
                    MessageBox.Show("Không thể xóa nhân viên đang đăng nhập", "Lỗi!!!");
                }
                else
                {
                    MessageBox.Show(temp2);
                    EmployeeBUS.Instance.deleteEmployee(lblemployeeID.Text);
                    ListEmployee.DataSource = EmployeeBUS.Instance.LoadListEmployee();
                }
                
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có muốn xóa tài khoản luôn không?", "Thông báo!!!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AccountBUS.Instance.deleteAccount(lblemployeeID.Text);
                    EmployeeBUS.Instance.deleteEmployee(lblemployeeID.Text);
                    ListEmployee.DataSource = EmployeeBUS.Instance.LoadListEmployee();
                }
                
            }
        }
        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            if(cbxchoose.Text == "ID")
            {
                string ID = "employeeID";
                ListEmployee.DataSource = EmployeeBUS.Instance.search(ID, tbxsearch.Text);
            }
            else if (cbxchoose.Text == "Họ Tên")
            {
                string name = "EmployeeName";
                ListEmployee.DataSource = EmployeeBUS.Instance.search(name, tbxsearch.Text);
            }
            else if (cbxchoose.Text == "Giới Tính")
            {
                int s = 0;
                string gender = "Gender";
                if(tbxsearch.Text == "Nam")
                {
                    s = 1;
                }
                else if(tbxsearch.Text == "Nữ")
                {
                    s = 0;
                }
                ListEmployee.DataSource = EmployeeBUS.Instance.search(gender, s.ToString());
            }
            else if (cbxchoose.Text == "Số điện thoại")
            {
                string sdt = "Phone";
                ListEmployee.DataSource = EmployeeBUS.Instance.search(sdt, tbxsearch.Text);
            }
            
        }

        private void ListEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListEmployee_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = ListEmployee.CurrentCell.RowIndex;
            GetCellClick(index);
        }
    }
}
            
        