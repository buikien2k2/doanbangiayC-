using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using Shoes.DAL;

namespace Shoes.GUI
{
    public partial class TKChart : Form
    {

        //chỉ cần sửa connectionString trong app-config
        SqlConnection con = new SqlConnection("Data Source=LAPTOP-C7NSF4A1\\ACERKIENAI;Initial Catalog=shoestore;Integrated Security=True");

        public TKChart()
        {
            InitializeComponent();
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            if (comboBox1.SelectedIndex >= 0)
            {
                if (comboBox3.SelectedIndex >= 0)
                {
                    int i = Convert.ToInt32(comboBox3.SelectedItem.ToString());
                    if(i ==1)
                    {
                        chart1.Series["Total"].Points.Clear();

                        string qry = "select distinct Format(ReceiptDate,'MMMM'),SUM(TotalMoney),ReceiptDate\r\nfrom receipt\r\nwhere ReceiptDate>='" + comboBox1.SelectedItem.ToString() + "/01/01' and ReceiptDate<='" + comboBox1.SelectedItem.ToString() + "/03/31'\r\ngroup by ReceiptDate order by ReceiptDate";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            chart1.Series["Total"].Points.AddXY(reader.GetString(0), reader.GetDouble(1));

                        }


                    }
                    else if (i == 2)
                    {
                        chart1.Series["Total"].Points.Clear();
                        string qry = "select distinct Format(ReceiptDate,'MMMM'),SUM(TotalMoney),ReceiptDate\r\nfrom receipt\r\nwhere ReceiptDate>='" + comboBox1.SelectedItem.ToString() + "/04/01' and ReceiptDate<='" + comboBox1.SelectedItem.ToString() + "/06/30'\r\ngroup by ReceiptDate order by ReceiptDate";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            chart1.Series["Total"].Points.AddXY(reader.GetString(0), reader.GetDouble(1));

                        }
                    }
                    else if (i == 3)
                    {
                        chart1.Series["Total"].Points.Clear();
                        string qry = "select distinct Format(ReceiptDate,'MMMM'),SUM(TotalMoney),ReceiptDate\r\nfrom receipt\r\nwhere ReceiptDate>='" + comboBox1.SelectedItem.ToString() + "/07/01' and ReceiptDate<='" + comboBox1.SelectedItem.ToString() + "/09/30'\r\ngroup by ReceiptDate order by ReceiptDate";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            chart1.Series["Total"].Points.AddXY(reader.GetString(0), reader.GetDouble(1));

                        }
                    }
                    else if (i == 4)
                    {
                        chart1.Series["Total"].Points.Clear();
                        string qry = "select distinct Format(ReceiptDate,'MMMM'),SUM(TotalMoney),ReceiptDate\r\nfrom receipt\r\nwhere ReceiptDate>='" + comboBox1.SelectedItem.ToString() + "/10/01' and ReceiptDate<='" + comboBox1.SelectedItem.ToString() + "/12/31'\r\ngroup by ReceiptDate order by ReceiptDate";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            chart1.Series["Total"].Points.AddXY(reader.GetString(0), reader.GetDouble(1));

                        }
                    }
                }
                else
                {
                    chart1.Series["Total"].Points.Clear();
                    string qry = "select distinct Format(ReceiptDate,'MMMM'),SUM(TotalMoney),ReceiptDate\r\nfrom receipt\r\nwhere ReceiptDate>='" + comboBox1.SelectedItem.ToString()+"/01/01' and ReceiptDate<='" + comboBox1.SelectedItem.ToString() + "/12/31'\r\ngroup by ReceiptDate order by ReceiptDate";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        chart1.Series["Total"].Points.AddXY(reader.GetString(0), reader.GetDouble(1));

                    }
                }
            }

            con.Close();

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem.Equals("Pie"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }
            if (comboBox2.SelectedItem.Equals("Column"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }
            if (comboBox2.SelectedItem.Equals("Area"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            }
            if (comboBox2.SelectedItem.Equals("Doughnut"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            }
            if (comboBox2.SelectedItem.Equals("Pyramid"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pyramid;
            }
            if (comboBox2.SelectedItem.Equals("Line"))
            {
                chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

        }



        private void TKChart_Load(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;


            comboBox7.SelectedIndex = 0;
            comboBox6.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series["Total"].Points.Clear();
            string year = dateTimePicker1.Value.Year.ToString();
            string month= dateTimePicker1.Value.Month.ToString();
            string day = dateTimePicker1.Value.Day.ToString();
            string time = year + "-" + month + "-" + day;

           if (con.State == ConnectionState.Closed)
            {
              con.Open();

            }
            string qry = "select distinct ReceiptDate,EmployeeName,SUM(TotalMoney)\r\nfrom receipt,employee\r\nwhere ReceiptDate ='"+time+"' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by EmployeeName,ReceiptDate";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while(reader.Read())
            {
              chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

            }

             con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                chart1.Series["Total"].Points.Clear();

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();

                }
                if (comboBox7.SelectedItem.ToString().IndexOf("NONE") >= 0)
                {
                    string qry = "select distinct receiptdetail.ProductID,receiptdetail.ProductName,SUM(receiptdetail.ProductAmount) as  AMOUNT\r\nfrom receipt,receiptdetail\r\nwhere receipt.ReceiptID=receiptdetail.ReceiptID and ReceiptDate>='" + comboBox6.SelectedItem.ToString() + "/01/01' and ReceiptDate<='" + comboBox6.SelectedItem.ToString() + "/12/31'\r\ngroup by receiptdetail.ProductID,receiptdetail.ProductName";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

                    }
                }
                else
                {

                    int getmonth = Convert.ToInt32(comboBox7.SelectedItem.ToString());
                    int getYear = Convert.ToInt32(comboBox6.SelectedItem.ToString());
                    if (getmonth == 1 || getmonth == 3 || getmonth == 5 || getmonth == 7 || getmonth == 8 || getmonth == 10 || getmonth == 12)
                    {
                        string qry = "select distinct receiptdetail.ProductID,receiptdetail.ProductName,SUM(receiptdetail.ProductAmount) as  AMOUNT\r\nfrom receipt,receiptdetail\r\nwhere receipt.ReceiptID=receiptdetail.ReceiptID and ReceiptDate>='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/01' and ReceiptDate<='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/31'\r\ngroup by receiptdetail.ProductID,receiptdetail.ProductName";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

                        }
                    }
                    else if (getmonth == 4 || getmonth == 6 || getmonth == 9 || getmonth == 11)
                    {
                        string qry = "select distinct receiptdetail.ProductID,receiptdetail.ProductName,SUM(receiptdetail.ProductAmount) as  AMOUNT\r\nfrom receipt,receiptdetail\r\nwhere receipt.ReceiptID=receiptdetail.ReceiptID and ReceiptDate>='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/01' and ReceiptDate<='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/30'\r\ngroup by receiptdetail.ProductID,receiptdetail.ProductName";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

                        }
                    }
                    else if (getmonth == 2)
                    {
                        if (getYear % 4 == 0)
                        {
                            string qry = "select distinct receiptdetail.ProductID,receiptdetail.ProductName,SUM(receiptdetail.ProductAmount) as  AMOUNT\r\nfrom receipt,receiptdetail\r\nwhere receipt.ReceiptID=receiptdetail.ReceiptID and ReceiptDate>='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/01' and ReceiptDate<='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/29'\r\ngroup by receiptdetail.ProductID,receiptdetail.ProductName";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                                chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

                            }
                        }
                        else
                        {
                            string qry = "select distinct receiptdetail.ProductID,receiptdetail.ProductName,SUM(receiptdetail.ProductAmount) as  AMOUNT\r\nfrom receipt,receiptdetail\r\nwhere receipt.ReceiptID=receiptdetail.ReceiptID and ReceiptDate>='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/01' and ReceiptDate<='" + comboBox6.SelectedItem.ToString() + "/" + comboBox7.SelectedItem.ToString() + "/28'\r\ngroup by receiptdetail.ProductID,receiptdetail.ProductName";
                            SqlCommand cmd = new SqlCommand(qry, con);
                            SqlDataReader reader = cmd.ExecuteReader();
                            while (reader.Read())
                            {

                                chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

                            }

                        }
                    }
                }

                con.Close();
            
        }

        private void TKChart_Shown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 2;
            this.button1_Click(null,null);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            chart1.Series["Total"].Points.Clear();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            if (comboBox4.SelectedItem.ToString().IndexOf("NONE") >= 0)
            {
                int getcom5 = Convert.ToInt32(comboBox5.SelectedItem.ToString());
                string qry = "select  distinct receipt.EmployeeID,employee.EmployeeName,SUM(receipt.TotalMoney) as TONGDOANHTHU\r\nfrom receiptdetail,receipt,employee\r\nWHERE  ReceiptDate >='" + getcom5 + "/01/01' and ReceiptDate<='" + getcom5 + "/12/31' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by receipt.EmployeeID,employee.EmployeeName\r\norder by SUM(receipt.TotalMoney) DESC";
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

                }

            }
            else
            {
                int getcom4 = Convert.ToInt32(comboBox4.SelectedItem.ToString());
                int getcom5 = Convert.ToInt32(comboBox5.SelectedItem.ToString());
                if (getcom4 == 1 || getcom4 == 3 || getcom4 == 5 || getcom4 == 7 || getcom4 == 8 || getcom4 == 10 || getcom4 == 12)
                {
                    string qry = "select  distinct receipt.EmployeeID,employee.EmployeeName,SUM(receipt.TotalMoney) as TONGDOANHTHU\r\nfrom receiptdetail,receipt,employee\r\nWHERE  ReceiptDate >='" + getcom5 + "/" + getcom4 + "/01' and ReceiptDate<='" + getcom5 + "/" + getcom4 + "/30' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by receipt.EmployeeID,employee.EmployeeName\r\norder by SUM(receipt.TotalMoney) DESC";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

                    }
                }
                else if (getcom4 == 4 || getcom4 == 6 || getcom4 == 9 || getcom4 == 11)
                {
                    string qry = "select  distinct receipt.EmployeeID,employee.EmployeeName,SUM(receipt.TotalMoney) as TONGDOANHTHU\r\nfrom receiptdetail,receipt,employee\r\nWHERE  ReceiptDate >='" + getcom5 + "/" + getcom4 + "/01' and ReceiptDate<='" + getcom5 + "/" + getcom4 + "/30' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by receipt.EmployeeID,employee.EmployeeName\r\norder by SUM(receipt.TotalMoney) DESC";
                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {

                        chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

                    }
                }
                else if (getcom4 == 2)
                {
                    if (getcom5 % 4 == 0)
                    {
                        string qry = "select  distinct receipt.EmployeeID,employee.EmployeeName,SUM(receipt.TotalMoney) as TONGDOANHTHU\r\nfrom receiptdetail,receipt,employee\r\nWHERE  ReceiptDate >='" + getcom5 + "/" + getcom4 + "/01' and ReceiptDate<='" + getcom5 + "/" + getcom4 + "/29' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by receipt.EmployeeID,employee.EmployeeName\r\norder by SUM(receipt.TotalMoney) DESC";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

                        }
                    }
                    else
                    {
                        string qry = "select  distinct receipt.EmployeeID,employee.EmployeeName,SUM(receipt.TotalMoney) as TONGDOANHTHU\r\nfrom receiptdetail,receipt,employee\r\nWHERE  ReceiptDate >='" + getcom5 + "/" + getcom4 + "/01' and ReceiptDate<='" + getcom5 + "/" + getcom4 + "/28' and employee.EmployeeID=receipt.EmployeeID\r\ngroup by receipt.EmployeeID,employee.EmployeeName\r\norder by SUM(receipt.TotalMoney) DESC";
                        SqlCommand cmd = new SqlCommand(qry, con);
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {

                            chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetDouble(2));

                        }

                    }
                }
            }

            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            chart1.Series["Total"].Points.Clear();

            if (con.State == ConnectionState.Closed)
            {
                con.Open();

            }
            string qry = "select distinct TOP(3)receiptdetail.ProductID,shoes.ProductName,SUM(receiptdetail.ProductAmount)\r\nfrom receiptdetail,shoes\r\nWHERE receiptdetail.ProductID=shoes.ProductID\r\ngroup by receiptdetail.ProductID,shoes.ProductName";
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                chart1.Series["Total"].Points.AddXY(reader.GetString(1), reader.GetInt32(2));

            }

            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            subreport f = new subreport();
            f.Show();

        }
    }
}
