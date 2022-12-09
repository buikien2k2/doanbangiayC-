using Shoes.BLL;
using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DAL
{
    internal class customerDAL
    {
        private static customerDAL instance;
        public static customerDAL Instance
        {
            get 
            { 
                if(instance == null) instance = new customerDAL();
                return instance; 
            }
            private set { instance = value; }
        }
        private customerDAL() { }

        public List<customerDTO> getCustomerList()
        {
            List<customerDTO> customerList = new List<customerDTO>();

            string query = "SELECT * FROM customer";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow Row in data.Rows)
            {
                customerDTO customer = new customerDTO(Row);
                customerList.Add(customer);
            }
            return customerList;
        }
        public int insertCustomer(string CustomerId,string CustomerName,int CustomerGender,string CustomerPhone)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO customer VALUES('" + CustomerId + "' , N'" + CustomerName + "' , " + CustomerGender + " , '" + CustomerPhone + "')");
        }
        public int updateCustomer(string CustomerId,string CustomerName,int CustomerGender,string CustomerPhone)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE customer SET Name = N'"+ CustomerName + "' , Gender = " + CustomerGender + " , Phone =  '" + CustomerPhone + "' WHERE CustomerID = '" + CustomerId + "' ");
        }
        public int deleteCustomer(string CustomerId)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM customer WHERE CustomerId ='" + CustomerId + "'");
        }
        
        
        
    }
}
