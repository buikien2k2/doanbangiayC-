using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shoes.BLL;
using Shoes.DTO;

namespace Shoes.DAL
{
    
    internal class AccountDAO
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get
            {
                if (instance == null) instance = new AccountDAO();
                return instance;
            }
            private set { AccountDAO.instance = value; }

        }
        private AccountDAO() { }
        public List<AccountDTO> LoadListAccount()
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string query = "Select * from account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                list.Add(new AccountDTO(row));
            }
            return list;
        }
        public int insertAcount(string employeeID, string username, string password, DateTime createdate)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO account VALUES('" + username + "' , '" + password + "' , '" + createdate + "' , '" + employeeID + "' ) ");
        }
        public int updateAccount(string employeeID, string username, string password, DateTime createdate)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE account SET Username = '" + username + "' ,Password = '"
                    + password + "' , Createdate = '" + createdate + "' WHERE  EmployeeID = '" + employeeID + "'");
        }

        public int deleteACount(string employeeID)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM account WHERE EmployeeID = '" + employeeID + "'");
        }
        public string autoGenerateEmployeeId()
        {
            int max = 0;
            List<AccountDTO> accList = LoadListAccount();
            for (int i = 0; i < accList.Count; i++)
            {
                AccountDTO acc = accList[i];
                int theNumber = Int32.Parse(acc.EmployeeID.Split(new string[] { "NV" }, StringSplitOptions.None)[1]);
                if (theNumber > max)
                {
                    max = theNumber;
                }
            }

            return "NV00" + (max + 1);
        }
        public List<AccountDTO> GetAccountbyID(string employeeID)
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string query = "Select * from account,employee where " +
                "employee.employeeID = account.employeeID and employee.employeeID = '" + employeeID + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                AccountDTO result = new AccountDTO(item);
                list.Add(result);
            }
            return list;
        }
        public List<AccountDTO> search(string choose, string text)
        {
            List<AccountDTO> list = new List<AccountDTO>();
            string query = "Select * from account where " + choose + " like '%" + text + "%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new AccountDTO(item));
            }
            return list;
        }
        public int getAccountCount()
        {
            int count;
            string query = "SELECT * FROM account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            count = data.Rows.Count;
            return count;
        }
        
    }
}
