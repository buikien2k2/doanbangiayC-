using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Shoes.DTO;
namespace Shoes.DAL
{
    internal class shoesDAL
    {
        private static shoesDAL instance;
        public static shoesDAL Instance
        {
            get
            {
                if (instance == null) instance = new shoesDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private shoesDAL() { }

        public List<shoesDTO> getShoesList()
        {
            List<shoesDTO> list = new List<shoesDTO>();

            string query = "SELECT * FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                shoesDTO shoes = new shoesDTO(item);
                list.Add(shoes);
            }

            return list;
        }

        public int insertShoes(string name, string type, int typeGender, string img, int size, float price, string brand, int amount)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO shoes VALUES('" + autoGenerateProductId() + "' , N'" + name + "' , N'" + type +"' , " + typeGender + " , " + img + " , " + size + " , " + price + " , '" + brand + "' , " + amount + " ) ");
        }

        public int updateShoes(string id, string name, string type, int typeGender, string img, int size, float price, string brand, int amount)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE shoes SET ProductName = N'" + name + "' , ProductType = N'"
                    + type + "' , TypeGender = " + typeGender + " , Img = " + img + " , Size = " + size + " , ProductPrice = " + price + " , Brand = N'"
                    + brand + "' , ProductAmount = " + amount + " WHERE ProductID = '" + id + "' ");
        }

        public int deleteShoes(string id)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM shoes WHERE ProductID = '" + id + "'");
        }

        public string autoGenerateProductId()
        {
            int max = 0;
            List<shoesDTO> sList = getShoesList();
            for (int i = 0; i < sList.Count; i++)
            {
                shoesDTO s = sList[i];
                int theNumber = Int32.Parse(s.ProductId.Split(new string[] { "SP" }, StringSplitOptions.None)[1]);
                if (theNumber > max)
                {
                    max = theNumber;
                }
            }

            return "SP" + (max + 1);
        }

        public int getTypeCount()
        {
            int count;

            string query = "SELECT DISTINCT ProductType FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            count = data.Rows.Count;

            return count;
        }

        public int getProductCount()
        {
            int count;

            string query = "SELECT ProductType FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            count = data.Rows.Count;

            return count;
        }

        public int getBrandCount()
        {
            int count;

            string query = "SELECT DISTINCT brand FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            count = data.Rows.Count;

            return count;
        }

        public List<string> getListType()
        {
            List<string> list = new List<string>();
            list.Add("");
            string query = "SELECT DISTINCT ProductType FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string type = item["ProductType"].ToString();
                list.Add(type);
            }
            return list;
        }

        public List<string> getListBrand()
        {
            List<string> list = new List<string>();
            list.Add("");
            string query = "SELECT DISTINCT Brand FROM shoes";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                string brand = item["Brand"].ToString();
                list.Add(brand);
            }
            return list;
        }
    }
}
