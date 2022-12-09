using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BLL
{
    public class HoaDonBUS
    {
        HoaDonDAL a = new HoaDonDAL();
        ChiTietHoaDonDAL b = new ChiTietHoaDonDAL();
        KhachHangDAL c = new KhachHangDAL();
        SanPhamDAL d = new SanPhamDAL();
        public DataTable loadDataGridView(string mahoadon)
        {
            return b.loadDataGridView(mahoadon);
        }
        public Boolean isduplicationProductid(ChiTietHoaDonDTO hd)
        {
            return b.isduplicationProductid(hd);
        }
        public Boolean DeleteOneRowReceiptDetail(string mahoadon, string masanpham)
        {
            return b.DeleteOneRowReceiptDetail(mahoadon, masanpham);
        }
        public DataTable getAmount(string receiptid, string productid)
        {
            return b.getAmount(receiptid, productid);
        }
        public DataTable updateAmountProduct(ChiTietHoaDonDTO hd, int newAmount, int currentamount)
        {
            return b.updateAmountProduct(hd, newAmount, currentamount);
        }
        public DataTable getReceipt()
        {
            return a.getReceipt();
        }
        public DataTable fillcboMadonhan()
        {
            return a.fillcboMadonhan();
        }
        public Boolean UpdateReceipt(HoaDonDTO hd)
        {
            return a.UpdateReceipt(hd);
        }
        public Boolean UpdateReceiptTotalMoney(string totalmoney, string receiptid)
        {
            return a.UpdateReceiptTotalMoney(totalmoney, receiptid);
        }
        public Boolean InsertReceipt(HoaDonDTO hd)
        {
            return a.InsertReceipt(hd);
        }
        public Boolean DeleteReceipt(string mahoadon)
        {
            return a.DeleteReceipt(mahoadon);
        }
        public DataTable getReceiptDetail()
        {
            return b.getReceiptDetail();
        }
        public DataTable getSize(string masanpham)
        {
            return b.getSize(masanpham);
        }
        public DataTable InsertReceiptDetail(ChiTietHoaDonDTO hd)
        {
            return b.InsertReceiptDetail(hd);
        }
        public Boolean DeleteReceiptDetail(string mahoadon)
        {
            return b.DeleteReceiptDetail(mahoadon);
        }
        public Boolean UpdateReceiptDetail(ChiTietHoaDonDTO hd)
        {
            return b.UpdateReceiptDetail(hd);
        }
        public DataTable getmoney(string receiptid, string productid)
        {
            return b.getmoney(receiptid, productid);
        }
        public DataTable searchByReceiptID(string receiptid)
        {
            return a.searchByReceiptID(receiptid);
        }
        public DataTable LayThongTinHD(string mahoadon)
        {
            return a.LayThongTinHD(mahoadon);
        }
        public Boolean updateSLHanTon(string productid, int amount)
        {
            return b.updateSLHanTon(productid, amount);
        }
        public DataTable getSLHanTon(string productid)
        {
            return b.getSLHanTon(productid);
        }
        public DataTable getproductamount(string receiptid, string productid)
        {
            return b.getproductamount(receiptid, productid);
        }
        public DataTable getInforCustomerByID(string makh)
        {
            return c.getInforCustomerByID(makh);
        }
        public DataTable getInforCustomerByPhone(string phone)
        {
            return c.getInforCustomerByPhone(phone);
        }
        public DataTable getInforCustomer()
        {
            return c.getInforCustomer();
        }
        public DataTable getBySize(string size)
        {
            return d.getBySize(size);
        }
        public DataTable getByAmount()
        {
            return d.getByAmount();
        }
        public DataTable getByPrice(string price)
        {
            return d.getByPrice(price);
        }
        public DataTable getByType(string type)
        {
            return d.getByType(type);
        }
        public DataTable getByGender(Boolean gender)
        {
            return d.getByGender(gender);
        }
        public DataTable getByBrand(string brand)
        {
            return d.getByBrand(brand);
        }
        public DataTable getByName(string name)
        {
            return d.getByName(name);
        }
        public DataTable getByID(string id)
        {
            return d.getByID(id);
        }
        public DataTable getShoes()
        {
            return d.getShoes();
        }
        public Boolean insertKH(string id, string name, int gender, string phone)
        {
            return c.insertKH(id, name, gender, phone);
        }
        public Boolean updateKH(string id, string name, int gender, string phone)
        {
            return c.updateKH(id, name, gender, phone);
        }
        public Boolean deleteKH(string id)
        {
            return c.deleteKH(id);
        }
        public string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;

            // -12345678.3445435 => "-12345678"
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }


            int ones, tens, hundreds;

            int positionDigit = sNumber.Length;   // last -> first

            string result = " ";


            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                // 0:       ###
                // 1: nghìn ###,###
                // 2: triệu ###,###,###
                // 3: tỷ    ###,###,###,###
                int placeValue = 0;

                while (positionDigit > 0)
                {
                    // Check last 3 digits remain ### (hundreds tens ones)
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            //return result + (suffix ? " đồng chẵn" : "");
            return result + (suffix ? " VNĐ" : "");
        }
        //Chuyển đổi từ PM sang dạng 24h
        public string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public string CreateKey(string tiento, string date)
        {
            string key = tiento;
            string[] partsDay;
            //partsDay = DateTime.Now.ToShortDateString().Split('/');
            partsDay = date.Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
    }
}
