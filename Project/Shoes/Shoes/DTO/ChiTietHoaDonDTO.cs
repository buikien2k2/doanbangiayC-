using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class ChiTietHoaDonDTO
    {
        private string _receiptid;
        public string receiptid
        {
            get { return _receiptid; }
            set { _receiptid = value; }
        }
        private string _productid;
        public string productid
        {
            get { return _productid; }
            set { _productid = value; }
        }
        private string _productname;
        public string productname
        {
            get { return _productname; }
            set { _productname = value; }
        }
        private int _productamount;
        public int productamount
        {
            get { return _productamount; }
            set { _productamount = value; }
        }
        private float _productprice;
        public float productprice
        {
            get { return _productprice; }
            set { _productprice = value; }
        }
        private float _money;
        public float money
        {
            get { return _money; }
            set { _money = value; }
        }

        public ChiTietHoaDonDTO(string receiptid, string productid, string productname, int productamount, float productprice, float money)
        {
            this._receiptid = receiptid;
            this._productid = productid;
            this._productname = productname;
            this._productamount = productamount;
            this._productprice = productprice;
            this._money = money;
        }
    }
}
