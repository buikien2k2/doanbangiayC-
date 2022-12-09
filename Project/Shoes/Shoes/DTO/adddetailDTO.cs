using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class adddetailDTO
    {
        public string notedetailId;
        public string productId;
        public string productName;
        public int productAmount;
        public float importPrice;
        public int importQuantity;

        public string NotedetailId { get => notedetailId; set => notedetailId = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int ProductAmount { get => productAmount; set => productAmount = value; }
        public float ImportPrice { get => importPrice; set => importPrice = value; }
        public int ImportQuantity { get => importQuantity; set => importQuantity = value; }

        public adddetailDTO(string notedetailId, string productId, string productName, int productAmount, int importPrice, int importQuantity)
        {
            NotedetailId = notedetailId;
            ProductId = productId;
            ProductName = productName;
            ProductAmount = productAmount;
            ImportPrice = importPrice;
            ImportQuantity = importQuantity;
        }

        public adddetailDTO(DataRow row)
        {
            NotedetailId = row["ImportNoteID"].ToString();
            ProductId = row["ProductID"].ToString();
            ProductName = row["ProductName"].ToString();
            ProductAmount = Convert.ToInt32(row["ProductAmount"]);
            ImportPrice = (float)Convert.ToDouble(row["ImportPrice"].ToString());
            ImportQuantity = Convert.ToInt32(row["ImportQuantity"]);
        }
        
    }
}
