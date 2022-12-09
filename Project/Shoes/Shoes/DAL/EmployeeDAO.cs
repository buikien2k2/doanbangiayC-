using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoes.DTO;

namespace Shoes.DAL
{
    internal class EmployeeDAO
    {
        private static EmployeeDAO instance;

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAO();
                return instance;
            }
            private set { EmployeeDAO.instance = value; }
        }
        private EmployeeDAO() { }

        
        public List<EmployeeDTO> LoadListEmployee1()
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "Select * from employee ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new EmployeeDTO(item));
                //Employee employee = new Employee();
                //list.Add(employee);
            }
            return list;
        }

        
        public int insertEmployee(string employeeID,string employeename, DateTime dateofbirth, int gender, DateTime datejoined, string phone)
        {
            return DataProvider.Instance.ExecuteNonQuery("INSERT INTO employee VALUES('" + employeeID + "' , N'" + employeename + "' , '" + dateofbirth + "' , " + gender + " , '" + datejoined + "' , " + phone + " ) ");
        }
        public int updateEmployee(string employeeID, string employeename, DateTime dateofbirth, int gender, DateTime datejoined, string phone)
        {
            return DataProvider.Instance.ExecuteNonQuery("UPDATE employee SET EmployeeName = N'" + employeename + "' , DateOfBirth = '"
                    + dateofbirth + "' , Gender = " + gender + " , DateJoined = '" + datejoined + "' , Phone = " + phone + " WHERE employeeID = '" + employeeID + "' ");
        }

        public int deleteEmployee(string employeeID)
        {
            return DataProvider.Instance.ExecuteNonQuery("DELETE FROM employee WHERE employeeID = '" + employeeID + "'");
        }
        public string autoGenerateEmployeeId()
        {
            int max = 0;
            List<EmployeeDTO> empList = LoadListEmployee1();
            for (int i = 0; i < empList.Count; i++)
            {
                EmployeeDTO emp = empList[i];
                int theNumber = Int32.Parse(emp.EmployeeID.Split(new string[] { "NV" }, StringSplitOptions.None)[1]);
                if (theNumber > max)
                {
                    max = theNumber;
                }
            }

            return "NV00" + (max + 1);
        }
        public List<EmployeeDTO> search(string choose, string text)
        {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "Select * from employee where "+choose+" like '%"+text+"%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                list.Add(new EmployeeDTO(item));
            }
            return list;
        }
        public int getEmployeeCount()
        {
            int count;
            string query = "SELECT * FROM employee";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            count = data.Rows.Count;
            return count;
        }
    }   
}
