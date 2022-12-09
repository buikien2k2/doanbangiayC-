using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    internal class AccountDTO
    {
        private string username;
        private string password;
        private DateTime createDate;
        private string employeeID;

        public AccountDTO(string username, string password, DateTime createDate, string employeeID)
        {
            this.username = username;
            this.password = password;
            this.createDate = createDate;
            this.employeeID = employeeID;
        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public DateTime CreateDate { get => createDate; set => createDate = value; }
        public string EmployeeID { get => employeeID; set => employeeID = value; }

        public AccountDTO(DataRow row)
        {
            this.username = row["username"].ToString();
            this.password = row["password"].ToString();
            this.createDate = (DateTime)row["createDate"];
            this.employeeID = row["employeeID"].ToString();
        }
    }
}
