using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DataTable = System.Data.DataTable;

namespace Shoes.DAL
{
    public class SanPhamDAL : DBConnection
    {
        public DataTable getShoes()
        {
            try
            {
                checkConnection();
                DataTable dt = new DataTable();
                string query = "select * from shoes";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return null;
            }
        }
        public DataTable getByID (string id)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where productid like '%" + id + "%'";
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
        public DataTable getByName(string name)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where productname like '%"+name+"%'";
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
        public DataTable getByBrand(string brand)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where brand like '%" + brand + "%'";
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
        public DataTable getByGender(Boolean gender)
        {
            try
            {
                checkConnection();
                int g;
                DataTable tb = new DataTable();
                if (gender)
                    g = 1;
                else
                    g = 0;
                string query = "select * from shoes where typegender = " + g;
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
        public DataTable getByType(string type)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where productType like '%" + type + "%'";
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
        public DataTable getByPrice(string price)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where productprice <= " + price + "";
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
        public DataTable getByAmount()
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where productamount > 0";
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
        public DataTable getBySize(string size)
        {
            try
            {
                checkConnection();
                DataTable tb = new DataTable();
                string query = "select * from shoes where size = " + size + "";
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
    }
}
