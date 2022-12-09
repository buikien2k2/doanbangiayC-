using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shoes.DAL
{
    internal class EmployeeDetailDAO
    {
        private static EmployeeDetailDAO instance;
        public static EmployeeDetailDAO Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDetailDAO();
                return instance;
            }
            private set { EmployeeDetailDAO.instance = value; }
        }
        public EmployeeDetailDAO()
        {
        }
        public List<EmployeeDetailDTO> GetEmployeeDetailbyID(string employeeID)
        {
            List<EmployeeDetailDTO> list = new List<EmployeeDetailDTO>();
            string query = "Select * from employeedetail,employee where " +
                "employee.employeeID = employeedetail.employeeID and employee.employeeID = '" + employeeID + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                EmployeeDetailDTO result = new EmployeeDetailDTO(item);
                list.Add(result);
            }
            return list;
        }
        public int insertEmployee(string employeeID, string Gmail, string EmployeeAddress, string EmployeeImage, int EmployeePay, string Office, int Status)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO employeedetail VALUES('" + employeeID + "' , '" + Gmail + "' , N'" + EmployeeAddress + "' ,N'" + EmployeeImage + "' , '" + EmployeePay + "' , N'" + Office + "', " + Status + ")");
        }
        public int updateEmployee(string employeeID, string Gmail, string EmployeeAddress, string EmployeeImage, int EmployeePay, string Office, int Status)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE employeedetail SET Gmail = '" + Gmail + "' , EmployeeAddress = N'"
                    + EmployeeAddress + "' , EmployeeImage = N'" + EmployeeImage + "' , EmployeePay = " + EmployeePay + " , Office = N'" + Office + "' , Status = " + Status + " WHERE employeeID = '" + employeeID + "' ");
        }

        public int deleteEmployee(string employeeID)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM employeedetail WHERE employeeID = '" + employeeID + "'");
        }
        public List<EmployeeDetailDTO> getOffice(string username)
        {
            List<EmployeeDetailDTO> list = new List<EmployeeDetailDTO>();
            string query = "Select * from account, employeedetail where account.EmployeeID = employeedetail.EmployeeID and account.Username = '" + username + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new EmployeeDetailDTO(item));
            }
            return list;
        }
        public List<HoaDonDTO> Luongnv(string employeeID)
        {
            List<HoaDonDTO> list = new List<HoaDonDTO>();
            string query = "Select * from employeedetail, receipt where employeedetail.employeeID= receipt.employeeID and employeedetail.employeeID = '"+employeeID+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new HoaDonDTO(item));
            }
            return list;
        }
    }
}
