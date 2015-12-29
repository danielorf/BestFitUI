using System;
using System.Data;
using System.Windows.Forms;
using Transform3DBestFit;

namespace BestFitUI
{
    public partial class BestFitUI : Form
    {
        DataTable dt = new DataTable();
        double[,] actualsArray;
        double[,] nominalsArray;
        Transform3D transform;
        bool calculated = false;
        bool rotationUnitsInRadiansFlag = true;  //Radians if true, Degrees if false
        double xRotationValueinRadians;
        double yRotationValueinRadians;
        double zRotationValueinRadians;
        double rad2Deg = 180 / Math.PI;

        

        enum rotationUnits
        {
            Radians,
            Degrees
        }

        public BestFitUI()
        {
            InitializeComponent();            
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
            
            rotationUnitsButton.Enabled = false;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader csv = new System.IO.StreamReader(openFileDialog1.FileName);

                while (csv.Peek() > 0)
                {
                    string csvRow = csv.ReadLine();
                    string[] splitRow = csvRow.Split(',');
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

                actualsArray = new double[dt.Rows.Count, 3];
                nominalsArray = new double[dt.Rows.Count, 3];


                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    actualsArray[i, 0] = Convert.ToDouble(dt.Rows[i][0].ToString());
                    actualsArray[i, 1] = Convert.ToDouble(dt.Rows[i][1].ToString());
                    actualsArray[i, 2] = Convert.ToDouble(dt.Rows[i][2].ToString());

                    nominalsArray[i, 0] = Convert.ToDouble(dt.Rows[i][3].ToString());
                    nominalsArray[i, 1] = Convert.ToDouble(dt.Rows[i][4].ToString());
                    nominalsArray[i, 2] = Convert.ToDouble(dt.Rows[i][5].ToString());

                }
            }

            openFileButton.Enabled = false;
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            if (actualsArray == null)
            {
                MessageBox.Show("Open csv first");
            }
            else
            {
                try
                {
                    transform = new Transform3D(actualsArray, nominalsArray);
                                        
                    calculated = transform.CalcTransform(transform.actualsMatrix, transform.nominalsMatrix);
                                        
                    xTransLabel.Text = Math.Round(transform.Transform6DOFVector[0], 4).ToString();
                    yTransLabel.Text = Math.Round(transform.Transform6DOFVector[1], 4).ToString();
                    zTransLabel.Text = Math.Round(transform.Transform6DOFVector[2], 4).ToString();

                    xRotationValueinRadians = Math.Round(transform.Transform6DOFVector[5], 4);
                    yRotationValueinRadians = Math.Round(transform.Transform6DOFVector[4], 4);
                    zRotationValueinRadians = Math.Round(transform.Transform6DOFVector[3], 4);

                    //xRotationLabel.Text = xRotationValueinRadians.ToString();
                    //yRotationLabel.Text = yRotationValueinRadians.ToString();
                    //zRotationLabel.Text = zRotationValueinRadians.ToString();

                    //xRotationLabel.Text = Math.Round(transform.Transform6DOFVector[5], 4).ToString();
                    //yRotationLabel.Text = Math.Round(transform.Transform6DOFVector[4], 4).ToString();
                    //zRotationLabel.Text = Math.Round(transform.Transform6DOFVector[3], 4).ToString();

                    errorLabel.Text = Math.Round(transform.ErrorRMS, 4).ToString();
                    calcBoolLabel.Text = calculated.ToString();
                    drawRotationValues();


                }
                catch (Exception)
                {
                    throw;
                }
            }

            toolStripStatusLabel.Text = "Rotation units are currently shown in " + returnRotationUnitsButtonText();
            rotationUnitsButton.Enabled = true;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rotationUnitsButton_Click(object sender, EventArgs e)
        {
            rotationUnitsInRadiansFlag = !rotationUnitsInRadiansFlag;

            drawRotationValues();

            toolStripStatusLabel.Text = "Rotation units are currently shown in " + returnRotationUnitsButtonText();

        }

        private string returnRotationUnitsButtonText()
        {
            if (rotationUnitsInRadiansFlag)
            {
                rotationUnitsButton.Text = rotationUnits.Degrees.ToString();
                return rotationUnits.Radians.ToString();
            }
            else if (!rotationUnitsInRadiansFlag)
            {
                rotationUnitsButton.Text = rotationUnits.Radians.ToString();
                return rotationUnits.Degrees.ToString();
            }
            else
            {
                throw new NullReferenceException("rotationInRadiansFlag is null somehow...");
            }
        }

        private void drawRotationValues()
        {
            if (rotationUnitsInRadiansFlag)
            {
                xRotationLabel.Text = xRotationValueinRadians.ToString();
                yRotationLabel.Text = yRotationValueinRadians.ToString();
                zRotationLabel.Text = zRotationValueinRadians.ToString();
            }
            else if (!rotationUnitsInRadiansFlag)
            {
                xRotationLabel.Text = Math.Round((xRotationValueinRadians * rad2Deg), 4).ToString();
                yRotationLabel.Text = Math.Round((yRotationValueinRadians * rad2Deg), 4).ToString();
                zRotationLabel.Text = Math.Round((zRotationValueinRadians * rad2Deg), 4).ToString();
            }
            else
            {
                throw new NullReferenceException("rotationInRadiansFlag is null somehow...");
            }
        }
    }
}
