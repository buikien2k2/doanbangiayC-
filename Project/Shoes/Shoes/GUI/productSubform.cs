using Shoes.BLL;
using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.GUI
{
    public partial class productSubform : Form
    {
        private string appPath { get; set; }

        public string formName { get; set; }
        private string imgPath { get; set; }
        public productSubform()
        {
            InitializeComponent();

            cbType.DataSource = shoesBLL.Instance.getListType();
            cbBrand.DataSource = shoesBLL.Instance.getListBrand();
            cbGender.SelectedIndex = cbGender.FindStringExact("Nam");
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            appPath = projectDirectory + "\\Shoes\\IMG\\";
        }

        public productSubform(shoesDTO shoes)
        {
            InitializeComponent();

            //img
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
            appPath = projectDirectory + "\\Shoes\\IMG\\";

            if (shoes.Img != null && shoes.Img != "'NULL'" && shoes.Img != "NULL" && shoes.Img != "")
            {
                img.Image = Image.FromFile(appPath + shoes.Img);
            }
            //name
            txtName.Text = shoes.ProductName;
            //type
            cbType.DataSource = shoesBLL.Instance.getListType();
            cbType.SelectedIndex = cbType.FindStringExact(shoes.ProductType);
            //brand
            cbBrand.DataSource= shoesBLL.Instance.getListBrand();
            cbBrand.SelectedIndex = cbBrand.FindStringExact(shoes.Brand);
            //size
            nmUDSize.Value = shoes.Size;
            //amount
            nmUDAmount.Value = shoes.ProductAmount;
            //price
            txtPrice.Text = shoes.ProductPrice.ToString();
            //typegender
            if (shoes.TypeGender)
            {
                cbGender.SelectedIndex = cbGender.FindStringExact("Nam");
            }
            else
            {
                cbGender.SelectedIndex = cbGender.FindStringExact("Nữ");
            }

            //tag
            deleteBtn.Tag = shoes.ProductId;
            btnSave.Tag = shoes;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = cbType.Text;

            int gender;
            if (cbGender.Text == "Nam")
            {
                gender = 1;
            }
            else
            {
                gender = 0;
            }

            string imgPath;
            int size = (int)nmUDSize.Value;
            float price = 0;
            string brand = cbBrand.Text;
            int amount = (int)nmUDAmount.Value;
            shoesDTO s = btnSave.Tag as shoesDTO;
            if (name == "" || type == "" || txtPrice.Text == "" || cbGender.Text == "" || brand == "")
            {
                MessageBox.Show("Nhập đầy đủ vào!!", "Thông báo");
                return;
            }
            else
            {
                int i = 0;
                bool isPriceNumeric = int.TryParse(txtPrice.Text, out i); //i now = 108  
                if (!isPriceNumeric)
                {
                    MessageBox.Show("Giá tiền phải là số!!", "Thông báo");
                    return;
                }
                else
                {
                    price = (float)Convert.ToDouble(txtPrice.Text);
                }
            }

            if (formName == "Sửa thông tin sản phẩm")
            {
                imgPath = "'" + s.Img + "'";
                if (img != null && s.Img != (img.Tag as string) && img.Tag != null)
                {
                    imgPath = "'" + img.Tag as string + "'";
                }

                string id = s.ProductId;

                int result = shoesBLL.Instance.updateShoes(id, name, type, gender, imgPath, size, price, brand, amount);
                if (result == 0)
                {
                    MessageBox.Show("Something Wrong! Heehe!", "Thông báo!!");
                }
                else
                {
                    MessageBox.Show("Sửa thành công!!", "Thông báo!!");
                }
                this.Close();
            }
            else
            {
                imgPath = "NULL";
                if (img != null)
                {
                    imgPath = "'" + img.Tag as string + "'";
                }

                int result = shoesBLL.Instance.insertShoes(name, type, gender, imgPath, size, price, brand, amount);
                
                if (result == 0)
                {
                    MessageBox.Show("Something Wrong!", "Thông báo!!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo!!");
                    resetForm();
                }
            }
        }

        

        private void img_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";

            /*string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Imgs\";
            if (Directory.Exists(appPath) == false)                                              // <---
            {                                                                                    // <---
                Directory.CreateDirectory(appPath);                                              // <---
            }*/                                                                                    // <---

            if (opFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string iName = opFile.SafeFileName;  
                    string filepath = opFile.FileName;  
                    imgPath = appPath + iName;          //path của hình ảnh nằm trong bin/debug/Imgs/img-filename
                    if (!File.Exists(imgPath))
                    {
                        File.Copy(filepath, imgPath);
                    }
                    img.Image = new Bitmap(opFile.OpenFile());
                    img.Tag = iName;
                    
                }
                catch (Exception exp)
                {
                    MessageBox.Show("Unable to open file. The file: " + exp.Message);
                }
            }
            else
            {
                opFile.Dispose();
            }
        }

        private void productSubform_Load(object sender, EventArgs e)
        {
            lb_formName.Text = formName;
            if (formName == "Sửa thông tin sản phẩm")
            {
                deleteBtn.Visible = true;
            }
            else
            {
                deleteBtn.Visible = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm này?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string id = deleteBtn.Tag as string;
                int result = shoesBLL.Instance.deleteShoes(id);
                if (result == 0)
                {
                    MessageBox.Show("Something Wrong!!", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Đã xóa!!", "Thông báo");
                }
                this.Close();
            }
        }

        private void resetForm()
        {
            img.Image = Image.FromFile(appPath + "default.jpg");
            img.Tag = "NULL";
            txtName.Text = "";
            cbType.DataSource = shoesBLL.Instance.getListType();
            cbBrand.Text = "";
            nmUDSize.Value = 0;
            nmUDAmount.Value = 0;
            cbGender.SelectedIndex = cbGender.FindStringExact("Nam");
            txtPrice.Text = "";
        }

        private void lb_formName_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
    }
}
