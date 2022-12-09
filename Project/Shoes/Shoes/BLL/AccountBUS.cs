using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoes.DAL;
using Shoes.DTO;
namespace Shoes.BLL
{
    internal class AccountBUS
    {
        private static AccountBUS instance;
        public static AccountBUS Instance
        {
            get
            {
                if (instance == null) instance = new AccountBUS();
                return instance;
            }
            private set { AccountBUS.instance = value; }

        }
        public AccountBUS() { }
        public List<AccountDTO> GetAccounts()
        {
            return AccountDAO.Instance.LoadListAccount();
        }
        public int insertAcount(string employeeID, string username, string password, DateTime createdate)
        {
            return AccountDAO.Instance.insertAcount(employeeID, username, password, createdate);
        }
        public int updateAccount(string employeeID, string username, string password, DateTime createdate)
        {
            return AccountDAO.Instance.updateAccount(employeeID, username, password,createdate);
        }
        public int deleteAccount(string employeeID)
        {
            return AccountDAO.Instance.deleteACount(employeeID);
        }
        public List<AccountDTO> GetAccountbyID(string employeeID)
        {
            return AccountDAO.Instance.GetAccountbyID(employeeID);
        }
        public List<AccountDTO> search(string choose, string text)
        {
            return AccountDAO.Instance.search(choose, text);
        }
        public int getAccountCount()
        {
            return AccountDAO.Instance.getAccountCount();
        }
        
    }
}
