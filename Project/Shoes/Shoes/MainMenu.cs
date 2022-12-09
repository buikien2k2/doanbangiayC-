using Shoes.BLL;
using Shoes.DTO;
using Shoes.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Shoes
{
    
    public partial class MainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private string office;
        public MainMenu()
        {
            InitializeComponent();
            random = new Random();
            btnCloseForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);

        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseForm.Visible = false;
        }
       

        private void btnMinisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaxsize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelLogo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelBtn_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void btnProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.fProduct(), sender);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Form1(), sender);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Form_ADD(), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.Form_CUSTOMER(), sender);
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            OpenChildForm(new GUI.TKChart(), sender);
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new GUI.fSupplier(), sender);
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new GUI.Employee(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new GUI.Account(), sender);   
        }

        private void MainMenu_Activated(object sender, EventArgs e)
        {
            if (activeForm != null && activeForm.Name == "fProduct")
            {
                btnProduct.PerformClick();
            }
        }

        public string temp;
        public string temp1;
        public void loadavt()
        {
            txbOffice.Visible = true;
            txbOffice.Enabled = false;
            List<EmployeeDetailDTO> office = EmployeeDetailBUS.Instance.GetEmployeeDetailbyID(temp1);
            foreach (EmployeeDetailDTO item in office)
            {

                pbxavt.Refresh();
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Shoes\\Resources\\" + item.EmployeeImage;
                pbxavt.Image = Image.FromFile(path);
                pbxavt.Text = path;
            }
            txbID.Visible = false;
            txbID.Text = temp1;
            txbOffice.Text = temp;
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {

            loadavt();
            
            if (txbOffice.Text == "Nhân Viên bán hàng")
            {
                btnAccount.Visible = false;
                btnAdd.Visible = false;
                btnEmployee.Visible = false;
                btnRevenue.Visible = false;
                btnSupplier.Visible = false;
                btnOrder.PerformClick();
            }
            else if (txbOffice.Text == "Nhân Viên nhập kho")
            {
                btnEmployee.Visible = false;
                btnRevenue.Visible = false;
                btnAccount.Visible = false;
                btnOrder.Visible = false;
                btnCustomer.Visible = false;
                btnAdd.PerformClick();
            }
            else if (txbOffice.Text == "Quản lý")
            {
                
                btnOrder.Visible = false;
                btnAdd.Visible = false;
                
                btnEmployee.PerformClick();
            }
            else if (txbOffice.Text == "Tạp vụ")
            {
                btnOrder.Visible = false;
                btnAccount.Visible = false;
                btnCustomer.Visible = false;
                btnAdd.Visible = false;
                btnEmployee.Visible = false;
                btnRevenue.Visible = false;
                btnSupplier.Visible = false;
            }
            else if (txbOffice.Text == "Admin")
            {
                btnOrder.Visible = true;
                btnProduct.Visible = true;
                btnCustomer.Visible = true;
                btnRevenue.Visible = true;
                btnSupplier.Visible = true;
                btnAccount.Visible = true;
                btnAdd.Visible = true;
                btnEmployee.Visible = true;
                btnProduct.PerformClick();
            }
            else
            {
                MessageBox.Show("Chức Vụ chưa rõ!!!", "Thông Báo");
                Application.Exit();
            }

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
            
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_TextChanged(object sender, EventArgs e)
        {
            loadavt();
        }
    }

}