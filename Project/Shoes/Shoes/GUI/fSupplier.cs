using Shoes.BLL;
using Shoes.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes.GUI
{
    public partial class fSupplier : Form
    {
        private bool dtgv_status = true;
        public fSupplier()
        {
            InitializeComponent();
        }

        private void fSupplier_Load(object sender, EventArgs e)
        {
            loadForm();
        }

        private void loadForm()
        {
            lb_supCount.Text = supplierBLL.Instance.getSupCount().ToString();
            /*if (dtgv_supplier.Rows.Count == 0)
            {
                dtgv_supplier.Rows.Clear();
            }*/
            
            dtgv_supplier.DataSource = supplierBLL.Instance.getSupplierList();
            dtgv_supplier.Columns[0].HeaderText = "ID";
            dtgv_supplier.Columns[1].HeaderText = "Tên nhà cung cấp";
            dtgv_supplier.Columns[2].HeaderText = "Địa chỉ";
            dtgv_supplier.Columns[3].HeaderText = "Số điện thoại";
        }

        private void dtgv_supplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && dtgv_status == true)
            {
                DataGridViewRow dgvRow = dtgv_supplier.Rows[e.RowIndex];
                string id = dgvRow.Cells[0].Value.ToString();
                string name = dgvRow.Cells[1].Value.ToString();
                string address = dgvRow.Cells[2].Value.ToString();
                string phone = dgvRow.Cells[3].Value.ToString();
                supplierDTO sup = new supplierDTO(id, name, address, phone);

                supplierSubform supSubform = new supplierSubform(sup);
                supSubform.formName = "Sửa thông tin nhà cung cấp";
                supSubform.ShowDialog();
                loadForm();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            supplierSubform supSubform = new supplierSubform();
            supSubform.formName = "Thêm mới nhà cung cấp";
            supSubform.ShowDialog();
            loadForm();
        }

        private void fSupplier_Activated(object sender, EventArgs e)
        {
            
        }

        private void txb_search_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtgv_supplier.DataSource = supplierBLL.Instance.search(txb_search.Text);
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            dtgv_supplier.DataSource = supplierBLL.Instance.search(txb_search.Text);
        }

        private void importExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Excel Files Only | *.xlsx; *.xls";
                ofd.Title = "Choose the file";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application xlapp;
                    Microsoft.Office.Interop.Excel.Workbook xlworkbook;
                    Microsoft.Office.Interop.Excel.Worksheet xlworksheet;
                    Microsoft.Office.Interop.Excel.Range xlrange;
                    try
                    {
                        xlapp = new Microsoft.Office.Interop.Excel.Application();
                        xlworkbook = xlapp.Workbooks.Open(ofd.FileName);
                        xlworksheet = xlworkbook.Worksheets["Sheet1"];
                        xlrange = xlworksheet.UsedRange;
                        List<supplierDTO> supList = new List<supplierDTO>();
                        for (int xlrow = 2; xlrow <= xlrange.Rows.Count; xlrow++)
                        {
                            dtgv_supplier.Columns[0].HeaderText = "ID";
                            dtgv_supplier.Columns[1].HeaderText = "Tên nhà cung cấp";
                            dtgv_supplier.Columns[2].HeaderText = "Địa chỉ";
                            dtgv_supplier.Columns[3].HeaderText = "Số điện thoại";
                            supplierDTO sup = new supplierDTO((xlrow - 1).ToString(), xlrange.Cells[xlrow, 1].Text, xlrange.Cells[xlrow, 2].Text, xlrange.Cells[xlrow, 3].Text);
                            //dtgv_supplier.Rows.Add((xlrow - 1).ToString() , xlrange.Cells[xlrow, 1], xlrange.Cells[xlrow, 2], xlrange.Cells[xlrow, 3]);
                            supList.Add(sup);
                        }
                        dtgv_supplier.DataSource = supList;
                        xlworkbook.Close();
                        xlapp.Quit();
                        turnOnExcel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnCancelExcel_Click(object sender, EventArgs e)
        {
            turnOffExcel();
        }

        private void btnSaveExcel_Click(object sender, EventArgs e)
        {
            for (int rows = 0; rows < dtgv_supplier.Rows.Count; rows++)
            {
                supplierBLL.Instance.insertSupplier(dtgv_supplier.Rows[rows].Cells[1].Value.ToString(), dtgv_supplier.Rows[rows].Cells[2].Value.ToString(), dtgv_supplier.Rows[rows].Cells[3].Value.ToString());
            }
            MessageBox.Show("SAVED", "Thông báo!!");
            turnOffExcel();
        }

        private void turnOnExcel()
        {
            btnSaveExcel.Visible = true;
            btnAddSup.Visible = false;
            btnCancelExcel.Visible = true;
            dtgv_status = false;
        }

        private void turnOffExcel()
        {
            btnSaveExcel.Visible = false;
            btnAddSup.Visible = true;
            btnCancelExcel.Visible = false;
            dtgv_status = true;
            loadForm();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
           if (dtgv_supplier.Rows.Count > 0)
           {
                Microsoft.Office.Interop.Excel.Application xlapp = new Microsoft.Office.Interop.Excel.Application();
                xlapp.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dtgv_supplier.Columns.Count + 1; i++)
                {
                    xlapp.Cells[1, i] = dtgv_supplier.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < dtgv_supplier.Rows.Count; i++)
                {
                    for (int j = 0; j < dtgv_supplier.Columns.Count; j++)
                    {
                        xlapp.Cells[i + 2, j + 1] = dtgv_supplier.Rows[i].Cells[j].Value.ToString();
                    }
                }
                xlapp.Columns.AutoFit();
                xlapp.Visible = true;
           }

        }
    } 
}
