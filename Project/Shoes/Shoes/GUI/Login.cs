using Shoes.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.DTO;
namespace Shoes.GUI
{
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
        }

        private void btnClosed_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label8.Visible = false;
            textBox1.BackColor= Color.White;    
            panel3.BackColor= Color.White;
            textBox2.BackColor= SystemColors.Control;
            panel4.BackColor= SystemColors.Control;
            textBox1.Clear();
            textBox1.Focus();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            label7.Visible = false;
            label8.Visible = false;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox2.Clear();
            textBox2.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (checkLogin(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Đăng nhập thành công!!!", "Thông báo");
                List<EmployeeDetailDTO> permiss = new List<EmployeeDetailDTO>();
                permiss = Shoes.BLL.EmployeeDetailBUS.Instance.getOffice(textBox1.Text);
                foreach(EmployeeDetailDTO item in permiss)
                {
                    MainMenu menu = new MainMenu();
                    menu.temp = item.Office;
                    menu.temp1= item.EmployeeID;
                    menu.Show();
                }
                this.Hide();
            }
            else
            {
                label7.Visible = true;
                label8.Visible = true;
            }
                
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }
        bool checkLogin(string username, string password)
        {
            
            List<AccountDTO> accounts = Shoes.BLL.AccountBUS.Instance.GetAccounts();
            for(int i = 0; i< accounts.Count; i++)
            {
                if (username == accounts[i].Username && password == accounts[i].Password)
                {
                    
                    return true;
                    
                }
                
            }
            return false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Pls call 078605087 or send email: kienai2k2@gmail.com to support", "Thông Báo");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
