using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class customerDTO
    {
        private string customerId;
        private string customerName;
        private bool customerGender;
        private string customerPhone;
        public string CustomerId { get => customerId; set => customerId = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public bool CustomerGender { get => customerGender; set => customerGender = value; }
        public string CustomerPhone { get => customerPhone; set => customerPhone = value; }

        public customerDTO(string customerId, string customerName, bool customerGender, string customerPhone)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            CustomerGender = customerGender;
            CustomerPhone = customerPhone;
        }
        public customerDTO(DataRow row)
        {
            CustomerId = row["CustomerID"].ToString();
            CustomerName = row["Name"].ToString();
            CustomerGender = Convert.ToBoolean(row["Gender"]);
            CustomerPhone = row["Phone"].ToString();
        }
    }
}
