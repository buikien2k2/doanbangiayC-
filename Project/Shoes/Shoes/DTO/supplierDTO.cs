//using Bunifu.Licensing.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class supplierDTO
    {
        private string supplierID;
        private string supplierName;
        private string supplierAdress;
        private string phone;

        public supplierDTO(string supplierID, string supplierName, string supplierAdress, string phone)
        {
            this.SupplierID = supplierID;
            this.SupplierName = supplierName;
            this.SupplierAdress = supplierAdress;
            this.Phone = phone;
        }

        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string SupplierAdress { get => supplierAdress; set => supplierAdress = value; }
        public string Phone { get => phone; set => phone = value; }

        public supplierDTO(DataRow row)
        {
            SupplierID = row["SupplierID"].ToString();
            SupplierName = row["SupplierName"].ToString();
            SupplierAdress = row["SupplierAdress"].ToString();
            Phone = row["Phone"].ToString();
        }
    }
}
