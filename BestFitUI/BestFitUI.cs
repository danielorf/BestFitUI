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
        double[,] actualsArray;
        double[,] nominalsArray;


        public BestFitUI()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(row);
        }

        private void BestFitUI_Load(object sender, EventArgs e)
        {
            dt.Columns.Add("Xactual", System.Type.GetType("System.String"));
            dt.Columns.Add("Yactual", System.Type.GetType("System.String"));
            dt.Columns.Add("Zactual", System.Type.GetType("System.String"));
            dt.Columns.Add("Xnom", System.Type.GetType("System.String"));
            dt.Columns.Add("Ynom", System.Type.GetType("System.String"));
            dt.Columns.Add("Znom", System.Type.GetType("System.String"));
            

            dataGridView1.DataSource = dt;
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
                    //dataGridView1.Rows.Add(splitRow);
                    DataRow dr = dt.NewRow();
                    dr["Xactual"] = splitRow[0];
                    dr["Yactual"] = splitRow[1];
                    dr["Zactual"] = splitRow[2];
                    dr["Xnom"] = splitRow[3];
                    dr["Ynom"] = splitRow[4];
                    dr["Znom"] = splitRow[5];

                    dt.Rows.Add(dr);

                }
                csv.Dispose();
                csv.Close();

                dataGridView1.DataSource = dt;
                
                actualsArray = new double[3, dt.Rows.Count];
                nominalsArray = new double[3, dt.Rows.Count];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    actualsArray[0, i] = Convert.ToDouble(dt.Rows[i][0].ToString());
                    actualsArray[1, i] = Convert.ToDouble(dt.Rows[i][1].ToString());
                    actualsArray[2, i] = Convert.ToDouble(dt.Rows[i][2].ToString());
                    
                    nominalsArray[0, i] = Convert.ToDouble(dt.Rows[i][3].ToString());
                    nominalsArray[1, i] = Convert.ToDouble(dt.Rows[i][4].ToString());
                    nominalsArray[2, i] = Convert.ToDouble(dt.Rows[i][5].ToString());
                    
                }
                

            }
        }
        
    }
}
