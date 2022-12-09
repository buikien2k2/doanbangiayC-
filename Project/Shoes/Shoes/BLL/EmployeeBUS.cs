using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shoes.DAL;
using Shoes.DTO;


namespace Shoes.BLL
{
    internal class EmployeeBUS
    {
        private static EmployeeBUS instance;
        public static EmployeeBUS Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeBUS();
                return instance;
            }
            private set { EmployeeBUS.instance = value; }

        }
        public EmployeeBUS() { }
        
        public List<EmployeeDTO> LoadListEmployee()
        {
            return EmployeeDAO.Instance.LoadListEmployee1();
        }
        
        public int insertEmployee(string employeeID, string employeename, DateTime dateofbirth, int gender, DateTime datejoined, string phone)
        {
            return EmployeeDAO.Instance.insertEmployee(employeeID,employeename, dateofbirth,gender,datejoined,phone);
        }
        public int updateEmployee(string employeeID, string employeename, DateTime dateofbirth, int gender, DateTime datejoined, string phone)
        {
            return EmployeeDAO.Instance.updateEmployee(employeeID, employeename, dateofbirth, gender, datejoined, phone);
        }
        public int deleteEmployee(string employeeID)
        {
            return EmployeeDAO.Instance.deleteEmployee(employeeID);
        }
        public string autoGenerateEmployeeId()
        {
            return EmployeeDAO.Instance.autoGenerateEmployeeId();
        }
        public List<EmployeeDTO> search(string choose, string text)
        {
            return EmployeeDAO.Instance.search(choose, text);
        }
        public int getEmployeeCount()
        {
            return EmployeeDAO.Instance.getEmployeeCount();
        }
    }
}
