using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.BLL
{
    internal class addBLL
    {
        private static addBLL instance;
        public static addBLL Instance
        {
            get
            {
                if (instance == null) instance = new addBLL();
                return instance;
            }
            private set { instance = value; }
        }
        private addBLL() { }

        public List<addDTO> getaddlist()
        {
            List<addDTO> list = new List<addDTO>();
            list = addDAL.Instance.getaddList();
            return list;
        }
        public List<string> getsupplierid()
        {
            return addDAL.Instance.getsupplierid();
        }
        public void updateadd(string NoteId, string supplierId, string date)
        {
            if (checkSupplierid(supplierId) == 1)
            {
                if (checkdatetime(date) == 1)
                {
                    addDAL.Instance.updateadd(NoteId, supplierId, date);
                }
                else
                {
                    MessageBox.Show("Ngày giờ không vượt quá thời gian hiện tại!");
                }
            }
            else
            {
                MessageBox.Show("Mã nhà cung cấp không hợp lệ!");
            }
        }
        public int deleteadd(string date)
        {
            return addDAL.Instance.deleteadd(date);
        }
        public void checkinsertadd(string NoteId,string supplierId,string date)
        {
            if(checkNoteid(NoteId) == 1)
            {
                if(checkNoteidfromlist(NoteId) == 1)
                {
                    if (checkdatetime(date) == 1)
                    {
                        if (checkSupplierid(supplierId) == 1) {
                            if(checklistsupplier(supplierId)==1)
                            {
                                addDAL.Instance.insertadd(NoteId, supplierId, date);
                            }
                            else
                            {
                                addDAL.Instance.insertSupplier(supplierId, null, null, null);
                                addDAL.Instance.insertadd(NoteId, supplierId, date);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Mã nhà cung cấp không hợp lệ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ngày giờ không vượt quá thời gian hiện tại!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập hiện đã có!");
                }
            }
            else
            {
                MessageBox.Show("Mã đơn hàng không hợp lệ!");
            }
        }
        public int checkNoteid(string noteid)
        {
            if (noteid.StartsWith("NID"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int checklistsupplier(string supplierid)
        {
            List<string> list = addDAL.Instance.getsupplierid();
            int flag = 0;
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Equals(supplierid))
                {
                    flag = 1;
                    break;
                }
            }
            return flag;
        }
        public int checkdatetime(string date)
        {
            DateTime day = Convert.ToDateTime(date);
            if(day <= DateTime.UtcNow)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int checkNoteidfromlist(string noteid)
        {
            List<addDTO> list = getaddlist();
            int flag = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].NoteId == noteid)
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
        public int checkSupplierid(string Supplierid)
        {
            if (Supplierid.StartsWith("NCC0"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public string getnumnote()
        {
            List<addDTO> list = getaddlist();
            return list.Count.ToString();
        }
        public string getnumsupplier()
        {
            return addDAL.Instance.getnumsupplierid();
        }
        public List<addDTO> search(string noteid)
        {
            List<addDTO> list = getaddlist();
            List<addDTO> listsearch = new List<addDTO>();

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].NoteId == noteid)
                {
                    listsearch.Add(list[i]);
                    break;
                }
            }
           return listsearch;
        }
    }
}
