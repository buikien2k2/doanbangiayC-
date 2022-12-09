using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DataTable = System.Data.DataTable;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shoes.DAL
{
    public class KhachHangDAL : DBConnection
    {
        public DataTable getInforCustomerByID(string makh)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from customer where customerid like '%" + makh + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public DataTable getInforCustomerByPhone(string phone)
        {
            try
            {
                DataTable tb = new DataTable();
                checkConnection();
                string query = "select * from customer where phone like '%" + phone + "%'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public DataTable getInforCustomer()
        {
            try
            {
                DataTable tb = new DataTable();
                checkConnection();
                string query = "select * from customer";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public Boolean insertKH(string id, string name, int gender, string phone)
        {
            try
            {
                checkConnection();
                string query = "insert into customer values (@id, @name, @gender, @phone)";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@id", id);
                cm.Parameters.AddWithValue("@name", name);
                cm.Parameters.AddWithValue("@gender", gender);
                cm.Parameters.AddWithValue("@phone", phone);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Thêm khách hàng thành công!");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean updateKH(string id, string name, int gender, string phone)
        {
            try
            {
                checkConnection();
                string query = "update customer set name = @name, gender = @gender, phone = @phone where customerid = @id";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@id", id);
                cm.Parameters.AddWithValue("@name", name);
                cm.Parameters.AddWithValue("@gender", gender);
                cm.Parameters.AddWithValue("@phone", phone);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Chỉnh sửa thông tin thành công!");
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Boolean deleteKH(string id)
        {
            try
            {
                checkConnection();
                string query = "delete from customer where customerid = @id";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@id", id);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Xóa thành công!");
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
