using Shoes.BLL;
using Shoes.DAL;
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

namespace Shoes.GUI
{
    public partial class fProduct : Form
    {
        public fProduct()
        {
            InitializeComponent();
        }

        public fProduct(int a)
        {

        }


        private void GenerateDynamicUserControl()
        {
            if (flPanel != null)
            {
                flPanel.Controls.Clear();
            }
            
            List<shoesDTO> shoesList = shoesBLL.Instance.getShoesList();
            int productQuantity = shoesList.Count;

            productItem[] productItemViewList = new productItem[productQuantity];

            for (int i = 0; i < productItemViewList.Length; i++)
            {
                productItemViewList[i] = new productItem(shoesList[i]);

                flPanel.Controls.Add(productItemViewList[i]);
                productItemViewList[i].Click += new System.EventHandler(this.userControlClick);
            }
        }

        private void userControlClick(object sender, EventArgs e)
        {
            productItem obj = (productItem)sender;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();

            lb_typeCount.Text = shoesBLL.Instance.getTypeCount().ToString();
            lb_productCount.Text = shoesBLL.Instance.getProductCount().ToString();
            lb_brandCount.Text = shoesBLL.Instance.getBrandCount().ToString();
            LoadComboBox();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            productSubform ps = new productSubform();
            ps.formName = "Thêm mới 1 sản phẩm";
            ps.ShowDialog();
            GenerateDynamicUserControl();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void fProduct_Activated(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
            lb_typeCount.Text = shoesBLL.Instance.getTypeCount().ToString();
            lb_productCount.Text = shoesBLL.Instance.getProductCount().ToString();
            lb_brandCount.Text = shoesBLL.Instance.getBrandCount().ToString();
            LoadComboBox();
        }

        private void search()
        {
            string type = cb_type.Text;
            string brand = cb_brand.Text;
            string genderFromCb = cb_gender.Text;
            string name = txb_search.Text;
            string gender = cb_gender.Text;

            List<shoesDTO> searchList = new List<shoesDTO>();
            searchList = shoesBLL.Instance.search(type, brand, gender, name);

            flPanel.Controls.Clear();
            int productQuantity = searchList.Count;

            productItem[] productItemViewList = new productItem[productQuantity];

            for (int i = 0; i < productItemViewList.Length; i++)
            {
                productItemViewList[i] = new productItem(searchList[i]);

                flPanel.Controls.Add(productItemViewList[i]);
                productItemViewList[i].Click += new System.EventHandler(this.userControlClick);
            }
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cb_brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            search();
        }

        private void LoadComboBox()
        {
            cb_type.SelectedIndexChanged -= new EventHandler(cb_type_SelectedIndexChanged);
            cb_brand.SelectedIndexChanged -= new EventHandler(cb_brand_SelectedIndexChanged);


            cb_type.DataSource = shoesBLL.Instance.getListType();
            cb_brand.DataSource = shoesBLL.Instance.getListBrand();


            cb_type.SelectedIndexChanged += new EventHandler(cb_type_SelectedIndexChanged);
            cb_brand.SelectedIndexChanged += new EventHandler(cb_brand_SelectedIndexChanged);
        }

        private void txb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search();
            }
        }
    }
}
