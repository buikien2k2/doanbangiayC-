using Shoes.DTO;
using Shoes.BLL;
using Shoes.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Xml.Serialization;

namespace Shoes.GUI
{
    public partial class EmployeeDetail : Form
    {
        private string employeeID;
        private string employeeName;
        private string employeePhone;
        private string employeeGender;
        private string Office;
        private DateTime DateOfBirth;
        private DateTime DateJoined;
        private string employeeImage;
        Employee employee = new Employee();
        string imgPath;
        public string formName { get; set; }
        public EmployeeDetail()
        {
            InitializeComponent();
        }
        public EmployeeDetail(string id, string name, string phone, string gender, string office, DateTime dob, DateTime dj, string image)
        {
            InitializeComponent();
            this.employeeID = id;
            this.employeeName = name;
            this.employeePhone = phone;
            this.employeeGender = gender;
            this.Office = office;
            this.DateOfBirth = dob;
            this.DateJoined = dj;
            this.employeeImage = image;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        
        private void EmployeeDetail_Load(object sender, EventArgs e)
        {
            lblformname.Text = formName;
            txbID.Text = employeeID;
            txbID.Enabled = false;
            txbName.Text = employeeName;
            txbPhone.Text = employeePhone;
            CbxGender.SelectedText = employeeGender;
            if(employeeGender == "")
            {
                CbxGender.SelectedIndex = 1;
            }
            cbxOffice.SelectedText = Office;
            if (Office == "")
            {
                cbxOffice.SelectedIndex = 0;
            }
            dtpbirth.Value = DateOfBirth;
            dtpjoined.Value = DateJoined;
            if (employeeImage != "") { pbAvartar.Image = Image.FromFile(employeeImage); }
            else
            {
                pbAvartar.Image = Shoes.Properties.Resources.avtdefault;
            }
            if(formName == "Chi tiết nhân viên")
            {
                txbName.Enabled = false;
                txbPhone.Enabled = false;
                CbxGender.Enabled = false;
                cbxOffice.Enabled = false;
                dtpbirth.Enabled = false;
                dtpjoined.Enabled = false;
                btnChange.Enabled = false;
                txbAddress.Enabled = false;
                txbGmail.Enabled = false;
            }
            List<HoaDonDTO> luongnv = EmployeeDetailBUS.Instance.Luongnv(txbID.Text);
            foreach (HoaDonDTO item in luongnv)
            {
                
                lblemployeePay.Text = Convert.ToString(3000000 + (0.1*item.totalmoney));
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files(*.jpg;*.jepg;*.png;*.bmp;)|*.jpg;*.jepg;*.png;*.bmp;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = dialog.FileName;
                pbAvartar.Image = new Bitmap(imgPath);
            }
            
        }

        private void txbID_TextChanged(object sender, EventArgs e)
        {
            List<EmployeeDetailDTO> office = Shoes.BLL.EmployeeDetailBUS.Instance.GetEmployeeDetailbyID(txbID.Text);
            List<AccountDTO> username = Shoes.BLL.AccountBUS.Instance.GetAccountbyID(txbID.Text);
            foreach (EmployeeDetailDTO item in office)
            {
                txbAddress.Text = item.EmployeeAddress;
                lblemployeePay.Text = item.EmployeePay.ToString();
                txbGmail.Text = item.Gmail;
                if(item.Status == false)
                {
                    lblStatus.Text = "Ngừng hoạt động";
                }
                else { lblStatus.Text = "Đang hoạt động"; }
            }
            foreach (AccountDTO item in username)
            {
                if (item.Username == null)
                {
                    lblUsername.Text = "Chưa có";
                }
                else { lblUsername.Text = item.Username; }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                List<String> listimg = new List<string>();
                string imgname;
                if (imgPath != null)
                {
                    String[] sd = imgPath.Split('\\');
                    imgname = sd[sd.Length - 1].ToString();
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                    String path = projectDirectory + "\\Shoes\\Resources\\" + imgname;
                    pbAvartar.Image.Save(path);
                    //if(formName == "Sửa thông tin")
                    //{
                    //    listimg.Add(path);

                    //    foreach (String item in listimg)
                    //    {
                    //        if (item == path)
                    //        {
                    //            path = "";
                    //        }
                    //        else
                    //        {
                    //            pbAvartar.Image.Save(path);
                    //            break;
                    //        }
                    //    }
                    //}
                    //else if(formName == "Thêm thông tin")
                    //{
                    //    pbAvartar.Image.Save(path);
                    //}


                }
                
                else
                    imgname = pbAvartar.Image.ToString();
                
                if (formName == "Sửa thông tin")
                {
                    if (dtpbirth.Value == DateTime.Today || dtpbirth.Value.Year >= dtpjoined.Value.Year)
                    {
                        MessageBox.Show("Vui Lòng chọn lại Ngày sinh", "Thông Báo!!");
                        
                    }
                    else
                    {
                        EmployeeBUS.Instance.updateEmployee(txbID.Text, txbName.Text, dtpbirth.Value, CbxGender.SelectedIndex, dtpjoined.Value, txbPhone.Text);
                        EmployeeDetailBUS.Instance.updateEmployee(txbID.Text, txbGmail.Text, txbAddress.Text, imgname.ToString(), 0, cbxOffice.Text, 0);
                        MessageBox.Show("Sửa Thành công", "Thông báo");
                        this.Close();
                    }

                }
                else if (formName == "Thêm nhân viên")
                {
                    if (dtpbirth.Value == DateTime.Today || dtpbirth.Value.Year >= dtpjoined.Value.Year)
                    {
                        MessageBox.Show("Vui Lòng chọn lại Ngày sinh", "Thông Báo!!");
                        
                    }
                    else
                    {
                        EmployeeBUS.Instance.insertEmployee(txbID.Text, txbName.Text, dtpbirth.Value, CbxGender.SelectedIndex, dtpjoined.Value, txbPhone.Text);
                        EmployeeDetailBUS.Instance.insertDetail(txbID.Text, txbGmail.Text, txbAddress.Text, imgname.ToString(), 0, cbxOffice.Text, 0);
                        MessageBox.Show("Thêm Thành công", "Thông báo");
                        this.Close();
                    }
                        
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Vui lòng điền đủ thông tin", "Thông báo!!");
            }
            
                
            
            
        }
    }
}
