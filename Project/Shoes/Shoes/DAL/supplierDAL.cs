using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DAL
{
    internal class supplierDAL
    {
        private static supplierDAL instance;
        public static supplierDAL Instance
        {
            get
            {
                if (instance == null) instance = new supplierDAL();
                return instance;
            }
            private set { instance = value; }
        }

        private supplierDAL() { }

        public List<supplierDTO> getSupplierList()
        {
            List<supplierDTO> supplierList = new List<supplierDTO>();

            string query = "SELECT * FROM supplier ORDER BY SupplierID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                supplierDTO sup = new supplierDTO(item);
                supplierList.Add(sup);
            }


            return supplierList;
        }

        public int insertSupplier(string name, string address, string phone)
        {
            string query = "INSERT INTO supplier VALUES('"+ autoGenerateSupplierId() + "' , N'"  + name + "' , N'" + address + "' , '" + phone + "' )";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int updateSupplier(string id, string name, string address, string phone)
        {
            string query = "UPDATE supplier SET SupplierName = N'" + name + "' , SupplierAdress = N'" + address + "' , Phone = '" + phone + "' WHERE SupplierID = '" + id + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int deleteSupplier(string id)
        {
            string query = "DELETE FROM supplier WHERE SupplierID = '" + id + "' ";
            return DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int getSupCount()
        {
            string query = "SELECT * FROM supplier";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data.Rows.Count;
        }

        public string autoGenerateSupplierId()
        {
            int max = 0;
            List<supplierDTO> supList = getSupplierList();
            for (int i = 0; i < supList.Count; i++)
            {
                supplierDTO sup = supList[i];
                int theNumber = Int32.Parse(sup.SupplierID.Split(new string[] { "NCC" }, StringSplitOptions.None)[1]);
                if ( theNumber > max)
                {
                    max = theNumber;
                }
            }

            return "NCC" + (max + 1);
        }
    }
}
