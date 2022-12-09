using Shoes.DAL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoes.BLL
{
    internal class EmployeeDetailBUS
    {
        private static EmployeeDetailBUS instance;
        public static EmployeeDetailBUS Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDetailBUS();
                return instance;
            }
            private set { EmployeeDetailBUS.instance = value; }
        }
        public EmployeeDetailBUS() { }
        public List<EmployeeDetailDTO> GetEmployeeDetailbyID(string employeeID)
        {
            return EmployeeDetailDAO.Instance.GetEmployeeDetailbyID(employeeID);
        }
        public int insertDetail(string employeeID, string Gmail, string EmployeeAddress, string EmployeeImage, int EmployeePay, string Office, int Status)
        {
            return EmployeeDetailDAO.Instance.insertEmployee(employeeID,Gmail,EmployeeAddress,EmployeeImage,EmployeePay,Office,Status);
        }
        public int updateEmployee(string employeeID, string Gmail, string EmployeeAddress, string EmployeeImage, int EmployeePay, string Office, int Status)
        {
            return EmployeeDetailDAO.Instance.updateEmployee(employeeID, Gmail, EmployeeAddress, EmployeeImage, EmployeePay, Office, Status);
        }
        public int deleteEmployee(string employeeID)
        {
            return EmployeeDetailDAO.Instance.deleteEmployee(employeeID);
        }
        public List<EmployeeDetailDTO> getOffice(string username)
        {
            return EmployeeDetailDAO.Instance.getOffice(username);
        }
        public List<HoaDonDTO> Luongnv(string employeeID)
        {
            return EmployeeDetailDAO.Instance.Luongnv(employeeID);
        }
    }
}
