using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.DAL
{
    public class HoaDonDAL : DBConnection
    {
        DataTable dt = new DataTable();
        public HoaDonDAL()
        {
            dt = getReceipt();
            //dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };
        }
        public DataTable getReceipt()
        {
            try
            {
                checkConnection();
                string query = "select * from receipt";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public DataTable searchByReceiptID(string receiptid)
        {
            try
            {
                checkConnection();
                string query = "select * from receipt where receiptid = '" + receiptid + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public DataTable fillcboMadonhan()
        {
            try
            {
                checkConnection();
                string query = "select receiptid from receipt";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public Boolean InsertReceipt(HoaDonDTO hd)
        {
            try
            {
                checkConnection();
                string query = "INSERT INTO receipt(ReceiptID, CustomerID, EmployeeID, ReceiptDate, TotalMoney) VALUES" +
                    "(@receiptid, @customerid, @employeeid, @date, @total)";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@customerid", hd.customerid);
                cm.Parameters.AddWithValue("@employeeid", hd.employeeid);
                cm.Parameters.AddWithValue("@date", hd.ReceiptDate);
                cm.Parameters.AddWithValue("@total", hd.totalmoney);
                cm.ExecuteNonQuery();
                MessageBox.Show("Thêm hóa đơn thành công!");
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean DeleteReceipt(string mahoadon)
        {
            try
            {
                checkConnection();
                string query = "delete receipt where receiptid = '" + mahoadon + "'";
                SqlCommand cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean UpdateReceipt(HoaDonDTO hd)
        {
            try
            {
                checkConnection();
                string query = "update receipt set receiptdate = @date, customerid = @cusid, employeeid = @emid, totalmoney = @total " +
                    "where receiptid = @receiptid";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@date", hd.ReceiptDate);
                cm.Parameters.AddWithValue("@cusid", hd.customerid);
                cm.Parameters.AddWithValue("@emid", hd.employeeid);
                cm.Parameters.AddWithValue("@total", hd.totalmoney);
                cm.ExecuteNonQuery();
                MessageBox.Show("Chỉnh sửa hóa đơn thành công!");
                con.Close();
                return true;
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa hóa đơn không thành công!");
                return false;
            }
        }
        public DataTable LayThongTinHD(string mahoadon)
        {
            try
            {
                checkConnection();
                string query = "select a.receiptid, a.receiptdate, a.totalmoney, b.name, b.gender, b.phone, c.employeename " +
                    "FROM receipt AS a, customer AS b, employee AS c " +
                    "WHERE a.receiptid = N'" + mahoadon + "' AND" +
                " a.customerid = b.customerid AND" +
                            " a.employeeid = c.employeeid";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable tb = new DataTable();
                da.Fill(tb);
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public Boolean UpdateReceiptTotalMoney(string totalmoney, string receiptid)
        {
            try
            {
                checkConnection();
                string query = "UPDATE receipt SET totalmoney = " + totalmoney + " where receiptid = '" + receiptid + "'";
                SqlCommand cm = new SqlCommand(query, con);
                cm.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
