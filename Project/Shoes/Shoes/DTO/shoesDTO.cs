using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class shoesDTO
    {
        private string productId;
        private string productName;
        private string productType;
        private int productAmount;
        private bool typeGender;
        private string img;
        private int size;
        private float productPrice;
        private string brand;

        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductType { get => productType; set => productType = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        public bool TypeGender { get => typeGender; set => typeGender = value; }
        public string Img { get => img; set => img = value; }
        public int Size { get => size; set => size = value; }
        public float ProductPrice { get => productPrice; set => productPrice = value; }
        public string Brand { get => brand; set => brand = value; }

        public shoesDTO(string productId, string productName, string productType, int productAmount, bool typeGender, string img, int size, float productPrice, string brand)
        {
            ProductId = productId;
            ProductName = productName;
            ProductType = productType;
            ProductAmount = productAmount;
            TypeGender = typeGender;
            Img = img;
            Size = size;
            ProductPrice = productPrice;
            Brand = brand;
        }



        public shoesDTO(DataRow row)
        {
            ProductId = row["ProductId"].ToString();
            ProductName = row["ProductName"].ToString();
            ProductType = row["ProductType"].ToString();
            ProductAmount = (int)row["ProductAmount"];
            TypeGender = Convert.ToBoolean(row["TypeGender"]);
            Img = row["Img"].ToString();
            Size = (int)row["Size"];
            ProductPrice = (float)Convert.ToDouble(row["ProductPrice"].ToString());
            Brand = row["Brand"].ToString();
        }
    }
}
