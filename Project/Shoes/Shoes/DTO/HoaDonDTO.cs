using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    public class HoaDonDTO
    {
        private string _receiptid;
        public string receiptid
        {
            get { return _receiptid; }
            set { _receiptid = value; }
        }
        private string _customerid;
        public string customerid
        {
            get { return _customerid; }
            set { _customerid = value; }
        }
        private string _employeeid;
        public string employeeid
        {
            get { return _employeeid; }
            set { _employeeid = value; }
        }
        private DateTime _receiptDate;
        public DateTime ReceiptDate
        {
            get { return _receiptDate; }
            set { _receiptDate = value; }
        }
        private float _totalmoney;
        public float totalmoney
        {
            get { return _totalmoney; }
            set { _totalmoney = value; }
        }
        public HoaDonDTO(string receiptid, string customerid, string employeeid, DateTime receiptDate, float totalmoney)
        {
            this._receiptid = receiptid;
            this._customerid = customerid;
            this._employeeid = employeeid;
            this._receiptDate = receiptDate;
            this._totalmoney = totalmoney;
        }
        public HoaDonDTO(DataRow row)
        {
            this._receiptid = row["receiptid"].ToString();
            this._customerid = row["customerid"].ToString();
            this._employeeid = row["employeeid"].ToString();
            this._receiptDate = (DateTime)row["receiptdate"];
            this._totalmoney = Convert.ToInt32(row["totalmoney"]);
        }
    }
}
