using System;
using Shoes.DTO;
using Shoes.DAL;
using Shoes.BLL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Shoes.GUI
{
    public partial class productItem : UserControl
    {


        public productItem(shoesDTO shoes)
        {
            InitializeComponent();
            
            lb_productName.Text = shoes.ProductName;

            string price = shoes.ProductPrice.ToString();
            lb_price.Text = "Giá: " + string.Format("{0:#,000}", Convert.ToDecimal(price)) + "đ"; ;

            lb_amount.Text = "Số lượng: " + shoes.ProductAmount.ToString();
            lb_size.Text = "Size: " + shoes.Size.ToString();

            if (shoes.Img != "" && shoes.Img != "NULL")
            {
                //imgBtn.Image = Image.FromFile(shoes.Img);
                string workingDirectory = Environment.CurrentDirectory;
                string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.FullName;
                string path = projectDirectory + "\\Shoes\\IMG\\" + shoes.Img;
                imgBtn.Image = Image.FromFile(path);
            }
            imgBtn.Tag = shoes;
        }

        private void product_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLight;
        }

        private void product_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = SystemColors.ControlLightLight;
        }

        private void imgBtn_Click(object sender, EventArgs e)
        {
            shoesDTO shoes = (shoesDTO) imgBtn.Tag;
            productSubform ps = new productSubform(shoes);
            ps.formName = "Sửa thông tin sản phẩm";
            ps.ShowDialog();
        }
    }
}
