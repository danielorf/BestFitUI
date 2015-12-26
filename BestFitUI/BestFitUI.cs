using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitUI
{
    public partial class BestFitUI : Form
    {
        //string tablename = "pointTable";
        DataTable dt = new DataTable();
        string[] row = new string[] { "a", "b", "c", "d", "e", "f" };
        string testVal;

        public BestFitUI()
        {
            InitializeComponent();
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(row);
        }

        private void BestFitUI_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "X1";
            dataGridView1.Columns[1].Name = "Y1";
            dataGridView1.Columns[2].Name = "Z1";
            dataGridView1.Columns[3].Name = "X2";
            dataGridView1.Columns[4].Name = "Y2";
            dataGridView1.Columns[5].Name = "Z2";



            /*
            dt.Columns.Add("Xnom", System.Type.GetType("System.String"));
            dt.Columns.Add("Ynom", System.Type.GetType("System.String"));
            dt.Columns.Add("Znom", System.Type.GetType("System.String"));
            dt.Columns.Add("Xactual", System.Type.GetType("System.String"));
            dt.Columns.Add("Yactual", System.Type.GetType("System.String"));
            dt.Columns.Add("Zactual", System.Type.GetType("System.String"));

            dataGridView1.DataSource = dt;*/
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader csv = new System.IO.StreamReader(openFileDialog1.FileName);

                while (csv.Peek() > 0)
                {
                    string csvRow = csv.ReadLine();
                    string[] splitRow = csvRow.Split(',');
                    testVal = splitRow[0];
                    dataGridView1.Rows.Add(splitRow);
                }
                csv.Dispose();
                csv.Close();
            }
        }
    }
}
