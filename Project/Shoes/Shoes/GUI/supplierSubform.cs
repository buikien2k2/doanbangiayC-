using Shoes.BLL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Shoes.GUI
{
    public partial class supplierSubform : Form
    {
        public string formName { get; set; }

        public supplierSubform()
        {
            InitializeComponent();
        }

        public supplierSubform(supplierDTO sup)
        {
            InitializeComponent();

            lb_supId.Text = sup.SupplierID;
            txb_supplier.Text = sup.SupplierName;
            txb_address.Text = sup.SupplierAdress;
            txb_phone.Text = sup.Phone;
        }

        private void supplierSubform_Load(object sender, EventArgs e)
        {
            lb_header.Text = formName;
            if (formName == "Sửa thông tin nhà cung cấp")
            {
                deleteBtn.Visible = true;
            }
            else
            {
                deleteBtn.Visible = false;
                lb_idTitle.Visible = false;
                lb_supId.Visible = false;
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txb_supplier.Text;
            string address = txb_address.Text;
            string phone = txb_phone.Text;

            if (name == "" || address == "" || phone == "")
            {
                MessageBox.Show("Nhập đầy đủ vào!!", "Thông báo");
            }

            if (formName == "Sửa thông tin nhà cung cấp")
            {
                string id = lb_supId.Text;

                int result = supplierBLL.Instance.updateSupplier(id, name, address, phone);
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
                int result = supplierBLL.Instance.insertSupplier(name, address, phone);
                if (result == 0)
                {
                    MessageBox.Show("Something Wrong! Heehe!", "Thông báo!!");
                }
                else
                {
                    MessageBox.Show("Thêm thành công!!", "Thông báo!!");
                    resetForm();
                }
            }
        }

        private void resetForm()
        {
            txb_supplier.Text = "";
            txb_address.Text = "";
            txb_phone.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Xóa Nhà cung cấp này?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string id = lb_supId.Text;
                int result = supplierBLL.Instance.deleteSupplier(id);
                if (result == 0)
                {
                    MessageBox.Show("Something Wrong! Heehe!", "Thông báo!!");
                }
                else
                {
                    MessageBox.Show("Xóa thành công!!", "Thông báo!!");
                    this.Close();
                }
            }    
                
        }

        private void lb_header_MouseDown(object sender, MouseEventArgs e)
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
