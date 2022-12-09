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
    internal class shoesBLL
    {
        private static shoesBLL instance;
        public static shoesBLL Instance
        {
            get
            {
                if (instance == null) instance = new shoesBLL();
                return instance;
            }
            private set { instance = value; }
        }

        private shoesBLL() { }

        public List<shoesDTO> getShoesList()
        {
            List<shoesDTO> list = new List<shoesDTO>();

            list = shoesDAL.Instance.getShoesList();

            return list;
        }

        public int insertShoes(string name, string type, int typeGender, string img, int size, float price, string brand, int amount)
        {
            return shoesDAL.Instance.insertShoes(name, type, typeGender, img, size, price, brand, amount);
        }

        public int updateShoes(string id, string name, string type, int typeGender, string img, int size, float price, string brand, int amount)
        {
            return shoesDAL.Instance.updateShoes(id, name, type, typeGender, img, size, price, brand, amount);
        }

        public int deleteShoes(string id)
        {
            return shoesDAL.Instance.deleteShoes(id);
        }

        public int getTypeCount()
        {
            return shoesDAL.Instance.getTypeCount();
        }

        public int getProductCount()
        {
            return shoesDAL.Instance.getProductCount();
        }

        public int getBrandCount()
        {
            return shoesDAL.Instance.getBrandCount();
        }

        public List<string> getListType()
        {
            return shoesDAL.Instance.getListType();
        }

        public List<string> getListBrand()
        {
            return shoesDAL.Instance.getListBrand();
        }

        public string autoGenerateProductId()
        {
            return shoesDAL.Instance.autoGenerateProductId();
        }

        public List<shoesDTO> search(string type, string brand, string gender, string name)
        {
            //return shoesDAL.Instance.search(type, brand, gender, name);
            List<shoesDTO> list = new List<shoesDTO>();
            list = shoesDAL.Instance.getShoesList();

            if (type != "")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].ProductType != type)
                    {
                        list.Remove(list[i]);
                    }
                }
            }

            if (brand != "")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].Brand != brand)
                    {
                        list.Remove(list[i]);
                    }
                }
            }

            if (name != "")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (!RemoveUnicode(list[i].ProductName.ToUpper()).Contains(RemoveUnicode(name.ToUpper())))
                    {
                        list.Remove(list[i]);
                    }    
                    /*if (!list[i].ProductName.Contains(name))
                    {
                        list.Remove(list[i]);
                    }*/
                }
            }

            if (gender == "Nam")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].TypeGender != true)
                    {
                        list.Remove(list[i]);
                    }
                }
            }

            if (gender == "Nữ")
            {
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (list[i].TypeGender != false)
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
