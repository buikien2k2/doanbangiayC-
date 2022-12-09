using System.Data;
using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.BLL
{
    internal class adddetailBLL
    {
        private static adddetailBLL instance;
        public static adddetailBLL Instance
        {
            get
            {
                if (instance == null) instance = new adddetailBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private adddetailBLL() { }

        public List<adddetailDTO> getadddetaillist(string ID)
        {
            List<adddetailDTO> list = new List<adddetailDTO>();
            List<adddetailDTO> list0 = adddetailDAL.Instance.getNotedetailList();
            foreach (adddetailDTO item in list0)
            {
                if (ID == item.NotedetailId)
                {
                    list.Add(item);
                }
            }
            return list;
        }
        public DataTable getdetailfromnoteid(string id)
        {
            return adddetailDAL.Instance.getNotedetailListid(id);
        }
        public List<string> getid()
        {
            return adddetailDAL.Instance.getid();
        }
        public int insertdetail(string noteid, string productid, string productname, int productamount, float productprice, int quantity)
        {
            return adddetailDAL.Instance.insertnotedetail(noteid, productid, productname, productamount, productprice, quantity);
        }
        public int deletedetail(string noteid, string productid)
        {
            return adddetailDAL.Instance.deletenotedetail(noteid, productid);
        }
        public int updateShoes(string productid,int amount)
        {
            return adddetailDAL.Instance.updateShoes(productid, amount);
        }
        public int updatenotedetail(string id, string productid, int productamount, float productprice, int quantity)
        {
            return adddetailDAL.Instance.updatenotedetail(id,productid,productamount,productprice,quantity);
        }
        public string getproductid(string productname)
        {
            return adddetailDAL.Instance.getProductid(productname);
        }
        public int getproductamount(string productname)
        {
            return adddetailDAL.Instance.getProductAmount(productname);
        }
        public int getproductidcount(string id)
        {
            return adddetailDAL.Instance.getnumproductid(id);
        }
        public int gettotalhd(string id)
        {
            return adddetailDAL.Instance.getProductSUMPRICE(id);
        }
        public int checknotedetailid(string notedetailid)
        {
            if (notedetailid.StartsWith("NID"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int checkprice(float price)
        {
            int key = 0;
            if (price > 0) key = 1;
            return key;
        }
        public void checkinsert(string id, string productid, string name, int amount, float price, int quantity,int size)
        {
            List<string> list = getid();
            int Key = 0;
            foreach (string item in list)
            {
                if (item.ToString() == productid)
                {
                    Key = 1;
                    break;
                }
                else
                {
                    Key = 0;
                }
            }
            if (Key == 0)
            {
                if (checkprice(price) == 1)
                {
                    adddetailDAL.Instance.insertShoes(productid, name, null, 0, null, size, price, null, quantity);
                    adddetailDAL.Instance.insertnotedetail(id, productid, name, quantity, price, quantity);
                }
                else
                {
                    MessageBox.Show("Gía nhập phải lớn hơn 0");
                }
            }
            if (Key == 1)
            {
                int Keyid = 0;
                List<adddetailDTO> listid = getadddetaillist(id);
                foreach (adddetailDTO item in listid)
                {
                    if (productid == item.productId)
                    {
                        Keyid = 1;
                        break;
                    }
                    else
                    {
                        Keyid = 0;
                    }
                }
                if (Keyid == 1)
                {
                    MessageBox.Show("Sản phẩm đã có trong chi tiết phiếu nhập");
                }
                if (Keyid == 0)
                {
                    adddetailDAL.Instance.insertnotedetail(id, productid, name, amount + quantity, price, quantity);
                    adddetailDAL.Instance.updateShoes(productid, amount + quantity);
                }

            }
       
        }
    }
}
