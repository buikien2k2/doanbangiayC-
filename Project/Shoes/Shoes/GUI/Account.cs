using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.BLL;
using Shoes.DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Shoes.GUI
{
    public partial class Account : Form
    {
        
        public Account()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AccountLoad();
        }
        public void AccountLoad()
        {
            ListAccount.DataSource = AccountBUS.Instance.GetAccounts();
            ListAccount.Columns[0].HeaderText = "Tên tài khoản";
            ListAccount.Columns[0].Width = 100;
            ListAccount.Columns[1].HeaderText = "Mật khẩu";
            ListAccount.Columns[1].Width = 80;
            ListAccount.Columns[2].HeaderText = "Ngày tạo";
            ListAccount.Columns[2].Width = 60;
            ListAccount.Columns[3].HeaderText = "Mã nhân viên";
            ListAccount.Columns[3].Width = 80;
            GetCellClick(0);
            BtnSave.Visible = false;
            ListAccount.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListAccount.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListAccount.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListAccount.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter;
            ListAccount.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListAccount.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListAccount.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ListAccount.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            cbxchoose.SelectedIndex = 0;
            lblSum.Text = AccountBUS.Instance.getAccountCount().ToString();
        }
        public void GetCellClick(int index)
        {
            index = ListAccount.CurrentCell.RowIndex;
            if (index >= 0)
            {
                txbUsername.Text = ListAccount.Rows[index].Cells[0].Value.ToString();
                txbPassword.Text = ListAccount.Rows[index].Cells[1].Value.ToString();
                dtpCreateDate.Text = ListAccount.Rows[index].Cells[2].Value.ToString();
          
                txbID.Text = ListAccount.Rows[index].Cells[3].Value.ToString();

            }

        }

        private void ListAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            BtnSave.Visible = false;
            int index = ListAccount.CurrentCell.RowIndex;
            
            GetCellClick(index);
        }
        public bool checkID()
        {
            List<AccountDTO> id = AccountBUS.Instance.GetAccounts();
            foreach (AccountDTO item in id)
            {
                if(item.EmployeeID != null)
                {
                    if (txbID.Text == item.EmployeeID)
                    {
                        MessageBox.Show("ID đã tồn tại", "Lỗi");
                        return false;
                    }

                    else
                        return true;
                }
                else
                {
                    MessageBox.Show("Chưa Có mã nhân viên", "Lỗi");
                    return false;
                }
                
            }
            return true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if (checkID()==false )
            {
                MessageBox.Show("ID đã tồn tại không thể sửa", "Lỗi");
            }
            else
            {
                try
                {
                    
                    
                    AccountBUS.Instance.updateAccount(txbID.Text, txbUsername.Text, txbPassword.Text, dtpCreateDate.Value);
                    //ListAccount.DataSource = AccountBUS.Instance.GetAccounts();
                    AccountLoad();
                    
                }
                catch
                {
                    MessageBox.Show("Lỗi không thể Sửa", "Lỗi");
                }
            }
                
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            AccountBUS.Instance.deleteAccount(txbID.Text);
            //ListAccount.DataSource = AccountBUS.Instance.GetAccounts();
            AccountLoad();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            BtnSave.Visible= true;
            txbUsername.Clear();
            txbUsername.Focus();
            txbPassword.Clear();
            dtpCreateDate.Value= DateTime.Now;
            txbID.Clear();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if(checkID() == true)
            {
                if(txbUsername.Text == "" && txbPassword.Text == "" && txbID.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập đủ thông tin!!", "Lỗi");
                }
                else if(txbUsername.Text == ""&& txbPassword.Text !="" && txbID.Text != "")
                {
                    MessageBox.Show("Thiếu username!!", "Lỗi");
                }
                else if (txbUsername.Text != "" && txbPassword.Text == "" && txbID.Text != "")
                {
                    MessageBox.Show("Thiếu password!!", "Lỗi");
                }
                else if (txbUsername.Text != "" && txbPassword.Text != "" && txbID.Text == "")
                {
                    MessageBox.Show("Thiếu ID!!", "Lỗi");
                }
                else
                {
                    try 
                    {
                        AccountBUS.Instance.insertAcount(txbID.Text, txbUsername.Text, txbPassword.Text, dtpCreateDate.Value);
                        //ListAccount.DataSource = AccountBUS.Instance.GetAccounts();
                        AccountLoad();
                        MessageBox.Show("Thêm Thành công!!","Thông Báo");
                        BtnSave.Visible = false;
                    }
                    catch
                    {
                        BtnSave.Visible = false;
                        MessageBox.Show("Lỗi không thể thêm!!", "Lỗi");
                    }

                    
                }
                
            }
            
                
            
        }

        private void tbxsearch_TextChanged(object sender, EventArgs e)
        {
            if(cbxchoose.Text == "Tên tài khoản")
            {
                string username = "Username";
                ListAccount.DataSource = AccountBUS.Instance.search(username,tbxsearch.Text);
            }
            else if(cbxchoose.Text == "ID")
            {
                string id = "employeeID";
                ListAccount.DataSource = AccountBUS.Instance.search(id, tbxsearch.Text);
                
            }
        }

        private void bunifuDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = ListAccount.CurrentCell.RowIndex;
            BtnSave.Visible = false;    
            GetCellClick(index);
        }
    }
}
