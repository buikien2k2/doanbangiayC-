using Shoes.BLL;
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
    internal class supplierBLL
    {
        private static supplierBLL instance;
        public static supplierBLL Instance
        {
            get
            {
                if (instance == null) instance = new supplierBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private supplierBLL() { }

        public List<supplierDTO> getSupplierList()
        {
            return supplierDAL.Instance.getSupplierList();
        }

        public int insertSupplier(string name, string address, string phone)
        {
            return supplierDAL.Instance.insertSupplier(name, address, phone);
        }

        public int updateSupplier(string id, string name, string address, string phone)
        {
            return supplierDAL.Instance.updateSupplier(id, name, address, phone);
        }

        public int deleteSupplier(string id)
        {
            return supplierDAL.Instance.deleteSupplier(id);
        }

        public int getSupCount()
        {
            return supplierDAL.Instance.getSupCount();
        }

        public string autoGenerateSupplierId()
        {
            return supplierDAL.Instance.autoGenerateSupplierId();
        }

        public List<supplierDTO> search(string name)
        {
            List<supplierDTO> list = new List<supplierDTO>();
            list = supplierDAL.Instance.getSupplierList();

            if (name != "")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (!RemoveUnicode(list[i].SupplierName.ToUpper()).Contains(RemoveUnicode(name.ToUpper())))
                    {
                        list.Remove(list[i]);
                    }
                }
            }

            return list;
        }

        public static string RemoveUnicode(string text)
        {
            string[] arr1 = new string[] { "á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",
    "đ",
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",
    "í","ì","ỉ","ĩ","ị",
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",
    "ý","ỳ","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] { "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",
    "d",
    "e","e","e","e","e","e","e","e","e","e","e",
    "i","i","i","i","i",
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",
    "u","u","u","u","u","u","u","u","u","u","u",
    "y","y","y","y","y",};
            for (int i = 0; i < arr1.Length; i++)
            {
                text = text.Replace(arr1[i], arr2[i]);
                text = text.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());
            }
            return text;
        }
    }
}
