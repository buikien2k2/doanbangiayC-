using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    internal class EmployeeDTO
    {
        private string employeeID;
        private string employeename;
        private DateTime dateofbirth;
        private bool gender;
        private DateTime datejoined;
        private string phone;

        public EmployeeDTO(string employeeID, string employeename, DateTime dateofbirth, bool gender, DateTime datejoined, string phone)
        {
            this.employeeID = employeeID;
            this.employeename = employeename;
            this.dateofbirth = dateofbirth;
            this.gender = gender;
            this.datejoined = datejoined;
            this.phone = phone;
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Emloyeename { get => employeename; set => employeename = value; }
        public DateTime Dateofbirth { get => dateofbirth; set => dateofbirth = value; }
        public bool Gender { get => gender; set => gender = value; }
        public DateTime Datejoined { get => datejoined; set => datejoined = value; }
        public string Phone { get => phone; set => phone = value; }

        public EmployeeDTO(DataRow row)
        {
            this.employeeID = row["employeeID"].ToString();
            this.employeename = row["employeename"].ToString();
            this.dateofbirth = (DateTime)row["dateofbirth"];
            this.gender = (bool)row["gender"];
            this.datejoined = (DateTime)row["datejoined"];
            this.phone = row["phone"].ToString();
        }
    }
}
