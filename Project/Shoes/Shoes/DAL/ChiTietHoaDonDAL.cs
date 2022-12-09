using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.DAL
{
    public class ChiTietHoaDonDAL : DBConnection
    {
        DataTable dt = new DataTable();
        public DataTable loadDataGridView(string mahoadon)
        {
            checkConnection();
            string query = "select productid, productname, productamount, productprice, money from receiptdetail where receiptid = '" + mahoadon + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public DataTable getSize(string masanpham)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select size from shoes where productid = '" + masanpham + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(tb);
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public DataTable getSLHanTon(string productid)
        {
            try
            {
                checkConnection();
                string query = "select productamount from shoes where productid = '" + productid + "'";
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
        public Boolean updateSLHanTon(string productid, int amount)
        {
            try
            {
                checkConnection();
                /*
                DataTable a = getSLHanTon(productid);
                int slTonKhoCu = a.Rows[0].Field<int>("productamount");
                int slTonKhoMoi = slTonKhoCu - amount;
                */
                string query = "update shoes set productamount = @amount where productid = @id";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@amount", amount);
                cm.Parameters.AddWithValue("@id", productid);
                cm.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getmoney(string receiptid, string productid)
        {
            try
            {
                checkConnection();
                string query = "select money from receiptdetail where receiptid = '" + receiptid + "' and productid = '" + productid + "'";
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
        public DataTable getproductamount(string receiptid, string productid)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select productamount from receiptdetail where receiptid = '" + receiptid + "' and productid = '" + productid + "'";
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
        public DataTable getReceiptDetail()
        {
            try
            {
                checkConnection();
                string query = "select * from receiptdetail";
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

        public DataTable InsertReceiptDetail(ChiTietHoaDonDTO hd)
        {
            try
            {
                checkConnection();
                string query = "insert into receiptdetail(receiptid, productid, productname, productamount, productprice, money) values" +
                    "(@receiptid, @productid, @name, @amount, @price, @money)";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@productid", hd.productid);
                cm.Parameters.AddWithValue("@name", hd.productname);
                cm.Parameters.AddWithValue("@amount", hd.productamount);
                cm.Parameters.AddWithValue("@price", hd.productprice);
                cm.Parameters.AddWithValue("@money", hd.money);
                cm.ExecuteNonQuery();
                DataTable tb = new DataTable();
                tb = loadDataGridView(hd.receiptid);
                MessageBox.Show("Thêm sản phẩm thành công!");
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
        public Boolean DeleteOneRowReceiptDetail(string mahoadon, string masanpham)
        {
            try
            {
                checkConnection();
                string query = "delete receiptdetail where receiptid = '" + mahoadon + "' and productid = '" + masanpham + "'";
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
        public Boolean DeleteReceiptDetail(string mahoadon)
        {
            try
            {
                checkConnection();
                string query = "delete receiptdetail where receiptid = '" + mahoadon + "'";
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
        public Boolean UpdateReceiptDetail(ChiTietHoaDonDTO hd)
        {
            try
            {
                checkConnection();
                string query = "update receiptdetail set ProductAmount = @sl, money = @money " +
                    "where receiptid = @receiptid and productid = @proid";
                SqlCommand cm = new SqlCommand(query, con);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@proid", hd.productid);
                cm.Parameters.AddWithValue("@sl", hd.productamount);
                cm.Parameters.AddWithValue("@money", hd.money);
                cm.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Chỉnh sửa sản phẩm thành công!");
                return true;
            }
            catch
            {
                MessageBox.Show("Chỉnh sửa sản phẩm không thành công!");
                return false;
            }
        }
        public DataTable getAmount(string receiptid, string productid)
        {
            checkConnection();
            string query = "select productamount from receiptdetail where receiptid = '" +
               receiptid + "' and productid = '" + productid + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            return tb;
        }
        public Boolean isduplicationProductid(ChiTietHoaDonDTO hd)
        {
            checkConnection();
            string query = "select productid from receiptdetail where receiptid = '" + hd.receiptid + "' and productid = '" + hd.productid + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable tb = new DataTable();
            da.Fill(tb);
            con.Close();
            if (tb.Rows.Count > 0)
            {

                MessageBox.Show("Sản phẩm này đã tồn tại!");
                return true;
            }
            else
            {
                return false;
            }

        }
        public DataTable updateAmountProduct(ChiTietHoaDonDTO hd, int newAmount, int currentamount)
        {
            try
            {
                checkConnection();
                int tong = newAmount + currentamount;
                string amount = tong.ToString();
                MessageBox.Show("Số lượng sản phẩm thêm vô: " + newAmount.ToString());
                MessageBox.Show("Số lượng sản phẩm trước đó: " + currentamount.ToString());
                MessageBox.Show("Số lượng sản phẩm sau khi thêm: " + tong.ToString());
                string query1 = "update receiptdetail set productamount = " + amount + "where receiptid = @receiptid and productid = @productid";
                SqlCommand cm = new SqlCommand(query1, con);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@productid", hd.productid);
                cm.ExecuteNonQuery();

                string query2 = "update receiptdetail set money = @price * @amount where receiptid = @receiptid and productid = @productid";
                cm = new SqlCommand(query2, con);
                cm.Parameters.AddWithValue("@price", hd.productprice);
                cm.Parameters.AddWithValue("@amount", amount);
                cm.Parameters.AddWithValue("@receiptid", hd.receiptid);
                cm.Parameters.AddWithValue("@productid", hd.productid);
                cm.ExecuteNonQuery();
                DataTable tb = new DataTable();
                tb = loadDataGridView(hd.receiptid);
                MessageBox.Show("Cập nhật sản phẩm thành công!");
                con.Close();
                return tb;
            }
            catch
            {
                return null;
            }
        }
    }
}
