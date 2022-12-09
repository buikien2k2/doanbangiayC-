using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.DAL;
using Shoes.DTO;

namespace Shoes.BLL
{
    internal class customerBLL
    {
        private static customerBLL instance;
        public static customerBLL Instance
        {
            get
            {
                if(instance == null) instance = new customerBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private customerBLL() { }

        public List<customerDTO> getcustomerlist()
        {
            List<customerDTO> list = new List<customerDTO>();
            list = customerDAL.Instance.getCustomerList();
            return list;
        }
        public int insertcustomer(string id,string name,string gender,string phone)
        {
            return customerDAL.Instance.insertCustomer(id,name,generateGendertoBIT(gender),phone);
        }
        public int updatecustomer(string id, string name, string gender, string phone)
        {
            return customerDAL.Instance.updateCustomer(id,name,generateGendertoBIT(gender),phone);   
           
        }
        public int deletecustomer(string id)
        {
            return customerDAL.Instance.deleteCustomer(id);
        }

        public int checkId(string id)
        {
            if (id.StartsWith("KH")) { return 1; }
            else { return 0; }
        }
        public int idchecklist(string id)
        {
            int flag = 0;
            List<customerDTO> listcheckid = getcustomerlist();
            for (int i = 0; i < listcheckid.Count; i++)
            {
                if (listcheckid[i].CustomerId == id)
                {
                    flag = 1;
                    break;
                }
            }
            if (flag == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int checkGender(string gender)
        {
            if (gender != "")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string generateGenderfromBIT(int a)
        {
            string gender = "";
            if (a == 1)
            {
                gender = "Nam";
            }
            if (a == 0)
            {
                gender = "Nữ";
            }
            return gender;
        }
        public int generateGendertoBIT(string gender)
        {
            int genderNum = 0;
            if (gender != null)
            {
                if (gender == "Nữ")
                {
                    genderNum = 0;
                }
                else
                {
                    genderNum = 1;
                }
            }
            else { }

            return genderNum;

        }
        public int checkPhonenum(string phone)
        {
            if (phone.Length == 10)
            {
                if (phone.StartsWith("0"))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return -1;
            }
        }
        public List<customerDTO> getmalelist()
        {
            List<customerDTO> listmale = new List<customerDTO>();
            List<customerDTO> list = getcustomerlist();
            for (int i = 0; i < list.Count; i++)
            {
                if ("Nam" == generateGenderfromBIT(Convert.ToInt32(list[i].CustomerGender)))
                {
                    listmale.Add(list[i]);
                }
            }
            return listmale;
        }
        public List<customerDTO> getfemalelist()
        {
            List<customerDTO> listfemale = new List<customerDTO>();
            List<customerDTO> list = getcustomerlist();
            for (int i = 0; i < list.Count; i++)
            {
                if ("Nữ" == generateGenderfromBIT(Convert.ToInt32(list[i].CustomerGender)))
                {
                    listfemale.Add(list[i]);
                }
            }
            return listfemale;
        }
        public string getnumcustomer()
        {
            int Count = 0;
            List<customerDTO> list = getcustomerlist();
            Count = list.Count;
            return Count.ToString();
        }
        public string getnummale()
        {
            int count = 0;
            List<customerDTO> list = getcustomerlist();
            for (int i = 0; i < list.Count; i++)
            {
                if ("Nam" == generateGenderfromBIT(Convert.ToInt32(list[i].CustomerGender)))
                {
                    count++;
                }
            }
            return count.ToString();

        }
        public string getnumfemale()
        {
            int count = 0;
            List<customerDTO> list = getcustomerlist();
            for (int i = 0; i < list.Count; i++)
            {
                if ("Nữ" == generateGenderfromBIT(Convert.ToInt32(list[i].CustomerGender)))
                {
                    count++;
                }
            }
            return count.ToString();

        }
        public List<customerDTO> searchid(string id)
        {
            List<customerDTO> list = getcustomerlist();
            List<customerDTO> result = new List<customerDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                if (id == list[i].CustomerId)
                {
                    result.Add(list[i]);
                    break;
                }
            }
            return result;
        }
        public List<customerDTO> searchname(string name)
        {
            List<customerDTO> list = getcustomerlist();
            List<customerDTO> result = new List<customerDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                if (name == list[i].CustomerName)
                {
                    result.Add(list[i]);
                    break;
                }
            }
            return result;
        }
        public List<customerDTO> searchphone(string phone)
        {
            List<customerDTO> list = getcustomerlist();
            List<customerDTO> result = new List<customerDTO>();
            for (int i = 0; i < list.Count; i++)
            {
                if (phone == list[i].CustomerPhone)
                {
                    result.Add(list[i]);
                    break;
                }
            }
            return result;
        }
        public void checkupdate(string id,string name,string gender,string phone)
        {
            if (checkGender(gender) == 1)
            {
                if (checkPhonenum(phone) == 1)
                {
                    updatecustomer(id, name, gender, phone);
                }
                else
                {
                    MessageBox.Show("Số điện thoại không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn giới tính!");
            }
        }
        public int checkinsert(string id,string name,string gender,string phone)
        {
            int flag = 0;
            if (checkId(id) == 1)
            {
                if (idchecklist(id) == 1)
                {
                    if (checkId(id) == 1)
                    {
                        if (checkPhonenum(phone) == 1)
                        {
                            insertcustomer(id,name,gender,phone);
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không hợp lệ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hãy chọn giới tính!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã khách hàng đã có, hãy nhập lại mã khách hàng khác!");
                    flag = 1;
                }
            }
            else
            {
                MessageBox.Show("ID khách hàng không hợp lệ!");
                flag = 1;
            }
            return flag;
        }
    }
}
