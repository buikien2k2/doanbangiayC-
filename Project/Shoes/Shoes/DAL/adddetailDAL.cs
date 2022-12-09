using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DAL
{
    internal class adddetailDAL
    {
        private static adddetailDAL instance;
        public static adddetailDAL Instance
        {
            get
            {
                if(instance == null) instance = new adddetailDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private adddetailDAL() { }

        public List<adddetailDTO> getNotedetailList()
        {
            List<adddetailDTO> list = new List<adddetailDTO>();
            string query = "SELECT * FROM importnotedetail";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                adddetailDTO notedetail = new adddetailDTO(item);
                list.Add(notedetail);
            }

            return list;
        }
        public DataTable getNotedetailListid(string id)
        {
            DataTable list = new DataTable();
            string query = "SELECT ProductID,ProductName,ImportPrice,ImportQuantity, (ImportPrice * ImportQuantity) AS ToMoney FROM importnotedetail WHERE ImportNoteID ='"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public List<string> getid()
        {
            List<string> list = new List<string>();
            string query = "SELECT ProductID FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                list.Add(item["ProductID"].ToString());
            }
            return list;
        }
        public int getnumproductid(string id)
        {
            int num = 0;
            string query = "SELECT DISTINCT ProductID FROM importnotedetail WHERE ImportNoteID = '"+id+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in data.Rows)
            {
                num++;
            }
            return num;
        }
        public string getProductid(string name)
        {
            string query = "SELECT ProductID FROM shoes WHERE ProductName =N'" + name + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            string id = "";
            foreach(DataRow item in Data.Rows)
            {
                id = item["ProductID"].ToString();
            }
            return id;
        }
        public int getProductAmount(string name)
        {
            string query = "SELECT ProductAmount FROM shoes WHERE ProductName =N'" + name + "'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            int num = 0;
            foreach (DataRow item in Data.Rows)
            {
                num += Convert.ToInt32(item["ProductAmount"].ToString());
            }
            return num;
        }
        public int getProductSUMPRICE(string id)
        {
            string query = "SELECT ImportPrice,ImportQuantity FROM importnotedetail WHERE ImportNoteID='"+id+"'";
            DataTable Data = DataProvider.Instance.ExecuteQuery(query);
            int num = 0;
            foreach (DataRow item in Data.Rows)
            {
                num += Convert.ToInt32(item["ImportPrice"].ToString()) * Convert.ToInt32(item["ImportQuantity"].ToString());
            }
            return num;
        }
        public int insertnotedetail(string notedetailid,string productid,string productname,int productamount,float importprice,int importquantity)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO importnotedetail VALUES('"+notedetailid+"','"+productid+"', N'"+productname+"',"+productamount+","+importprice+","+importquantity+")");
        }
        public int updatenotedetail(string id,string productid,int productamount,float productprice,int quantity)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE importnotedetail SET ProductAmount="+productamount+", ImportPrice="+productprice+", ImportQuantity="+quantity+" WHERE ProductID ='"+productid+"' AND ImportNoteID = '"+id+"'");
        }
        public int deletenotedetail(string notedetailid,string productid)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM importnotedetail WHERE ImportNoteID ='"+notedetailid+"' AND ProductID ='"+productid+"'");
        }
        public int updateShoes(string id,int amount)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE shoes SET ProductAmount = " + amount + " WHERE ProductID = '" + id + "' ");
        }
        public int insertShoes(string id,string name, string type, int typeGender, string img, int size, float price, string brand, int amount)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO shoes VALUES('" + id + "' , N'" + name + "' , N'" + type + "' , " + typeGender + " , '" + img + "' , " + size + " , " + price + " , '" + brand + "' , " + amount + " ) ");
        }
    }   
}
