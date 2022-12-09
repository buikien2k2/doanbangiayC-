using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.DTO
{
    internal class EmployeeDetailDTO
    {
        private string employeeID;
        private string gmail;
        private string employeeAddress;
        private string employeeImage;
        private int employeePay;
        private string office;
        private bool status;

        public EmployeeDetailDTO(string employeeID, string gmail, string employeeAddress, string employeeImage, int employeePay, string office, bool status)
        {
            this.employeeID = employeeID;
            this.gmail = gmail;
            this.employeeAddress = employeeAddress;
            this.employeeImage = employeeImage;
            this.employeePay = employeePay;
            this.office = office;
            this.status = status;
        }

        public string EmployeeID { get => employeeID; set => employeeID = value; }
        public string Gmail { get => gmail; set => gmail = value; }
        public string EmployeeAddress { get => employeeAddress; set => employeeAddress = value; }
        public string EmployeeImage { get => employeeImage; set => employeeImage = value; }
        public int EmployeePay { get => employeePay; set => employeePay = value; }
        public string Office { get => office; set => office = value; }
        public bool Status { get => status; set => status = value; }

        public EmployeeDetailDTO(DataRow row)
        {
            this.employeeID = row["employeeID"].ToString();
            this.gmail = row["Gmail"].ToString();
            this.employeeAddress = row["employeeAddress"].ToString();
            this.employeeImage = row["employeeImage"].ToString();
            this.employeePay = (int)row["employeePay"];
            this.office = row["office"].ToString();
            this.status = (bool)row["status"];
        }
    }
}
