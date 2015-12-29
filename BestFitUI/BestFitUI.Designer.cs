namespace BestFitUI
{
    partial class BestFitUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileButton = new System.Windows.Forms.Button();
            this.calcButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.xTransLabel = new System.Windows.Forms.Label();
            this.yTransLabel = new System.Windows.Forms.Label();
            this.zTransLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.xRotationLabel = new System.Windows.Forms.Label();
            this.calcBoolLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.yRotationLabel = new System.Windows.Forms.Label();
            this.errorLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.zRotationLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.rotationUnitsButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 43.05556F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.94444F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.statusStrip, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.69231F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.30769F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(648, 556);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.openFileButton);
            this.flowLayoutPanel1.Controls.Add(this.calcButton);
            this.flowLayoutPanel1.Controls.Add(this.closeButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 523);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(273, 30);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(3, 3);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(75, 23);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open File";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(84, 3);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(102, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate Best Fit";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(192, 3);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(642, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.xTransLabel, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.yTransLabel, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.zTransLabel, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label4, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label13, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.xRotationLabel, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.calcBoolLabel, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.label14, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.yRotationLabel, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.errorLabel, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.label15, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.zRotationLabel, 5, 2);
            this.tableLayoutPanel2.Controls.Add(this.label18, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.rotationUnitsButton, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(642, 86);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(210, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xtrans: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ytrans: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(210, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ztrans: ";
            // 
            // xTransLabel
            // 
            this.xTransLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xTransLabel.AutoSize = true;
            this.xTransLabel.Location = new System.Drawing.Point(259, 7);
            this.xTransLabel.Name = "xTransLabel";
            this.xTransLabel.Size = new System.Drawing.Size(10, 13);
            this.xTransLabel.TabIndex = 6;
            this.xTransLabel.Text = "-";
            // 
            // yTransLabel
            // 
            this.yTransLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yTransLabel.AutoSize = true;
            this.yTransLabel.Location = new System.Drawing.Point(259, 35);
            this.yTransLabel.Name = "yTransLabel";
            this.yTransLabel.Size = new System.Drawing.Size(10, 13);
            this.yTransLabel.TabIndex = 7;
            this.yTransLabel.Text = "-";
            // 
            // zTransLabel
            // 
            this.zTransLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zTransLabel.AutoSize = true;
            this.zTransLabel.Location = new System.Drawing.Point(259, 64);
            this.zTransLabel.Name = "zTransLabel";
            this.zTransLabel.Size = new System.Drawing.Size(10, 13);
            this.zTransLabel.TabIndex = 8;
            this.zTransLabel.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Xrotation: ";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Transform Calculated?";
            // 
            // xRotationLabel
            // 
            this.xRotationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.xRotationLabel.AutoSize = true;
            this.xRotationLabel.Location = new System.Drawing.Point(387, 7);
            this.xRotationLabel.Name = "xRotationLabel";
            this.xRotationLabel.Size = new System.Drawing.Size(10, 13);
            this.xRotationLabel.TabIndex = 9;
            this.xRotationLabel.Text = "-";
            // 
            // calcBoolLabel
            // 
            this.calcBoolLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.calcBoolLabel.AutoSize = true;
            this.calcBoolLabel.Location = new System.Drawing.Point(131, 7);
            this.calcBoolLabel.Name = "calcBoolLabel";
            this.calcBoolLabel.Size = new System.Drawing.Size(10, 13);
            this.calcBoolLabel.TabIndex = 15;
            this.calcBoolLabel.Text = "-";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yrotation: ";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Error RMS";
            // 
            // yRotationLabel
            // 
            this.yRotationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.yRotationLabel.AutoSize = true;
            this.yRotationLabel.Location = new System.Drawing.Point(387, 35);
            this.yRotationLabel.Name = "yRotationLabel";
            this.yRotationLabel.Size = new System.Drawing.Size(10, 13);
            this.yRotationLabel.TabIndex = 10;
            this.yRotationLabel.Text = "-";
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Location = new System.Drawing.Point(131, 35);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(10, 13);
            this.errorLabel.TabIndex = 16;
            this.errorLabel.Text = "-";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zrotation: ";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(96, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "TBD";
            // 
            // zRotationLabel
            // 
            this.zRotationLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.zRotationLabel.AutoSize = true;
            this.zRotationLabel.Location = new System.Drawing.Point(387, 64);
            this.zRotationLabel.Name = "zRotationLabel";
            this.zRotationLabel.Size = new System.Drawing.Size(10, 13);
            this.zRotationLabel.TabIndex = 11;
            this.zRotationLabel.Text = "-";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(131, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(10, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "-";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"CSV Files (*.csv)|*.csv|All Files (*.*)|*.*\"";
            // 
            // rotationUnitsButton
            // 
            this.rotationUnitsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rotationUnitsButton.Location = new System.Drawing.Point(451, 3);
            this.rotationUnitsButton.Name = "rotationUnitsButton";
            this.rotationUnitsButton.Size = new System.Drawing.Size(188, 22);
            this.rotationUnitsButton.TabIndex = 18;
            this.rotationUnitsButton.Text = "-";
            this.rotationUnitsButton.UseVisualStyleBackColor = true;
            this.rotationUnitsButton.Click += new System.EventHandler(this.rotationUnitsButton_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(279, 520);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(369, 36);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(0, 31);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(176, 31);
            this.toolStripStatusLabel1.Text = "Select .csv file containing points";
            // 
            // BestFitUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "BestFitUI";
            this.Text = "Transform Calculator";
            this.Load += new System.EventHandler(this.BestFitUI_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label xTransLabel;
        private System.Windows.Forms.Label yTransLabel;
        private System.Windows.Forms.Label zTransLabel;
        private System.Windows.Forms.Label xRotationLabel;
        private System.Windows.Forms.Label yRotationLabel;
        private System.Windows.Forms.Label zRotationLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label calcBoolLabel;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button rotationUnitsButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

