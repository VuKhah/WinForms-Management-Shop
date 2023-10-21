using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Management_Shop
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void Save_bt_Click(object sender, EventArgs e)
        {
            Element a = new Element();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xlsx;*.xls";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                using (ExcelPackage package = new ExcelPackage(new System.IO.FileInfo(filePath)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;

                    DataTable dt = new DataTable();

                    // Đọc tên cột từ file Excel và thêm vào DataTable
                    for (int col = 1; col <= columnCount; col++)
                    {
                        string columnName = worksheet.Cells[1, col].Text;
                        dt.Columns.Add(columnName);
                    }

                    // Đọc dữ liệu từ file Excel và thêm vào DataTable
                    for (int row = 2; row <= rowCount; row++)
                    {
                        DataRow newRow = dt.NewRow();
                        for (int col = 1; col <= columnCount; col++)
                        {
                            newRow[col - 1] = worksheet.Cells[row, col].Text;
                        }
                        dt.Rows.Add(newRow);
                    }

                    // Gán DataTable vào DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
        }
    }
}
