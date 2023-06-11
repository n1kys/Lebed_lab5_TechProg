using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Windows.Markup;

namespace Lebed_lab5_TechProg
{
    public partial class Form1 : Form
    {
        private DiagrammForm df;
        public Form1()
        {
            InitializeComponent();
            df = new DiagrammForm();
        }

        private void infoAuthor_Click(object sender, EventArgs e)
        {
            Form2 author = new Form2();
            author.Show();
        }

        private void authorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private Chart GenerateChart(int sectionCount, PictureBox pictureBox)
        {
            Chart chart = new Chart();

            // �������� ����� � ���������� ������
            Series series = new Series();
            series.ChartType = SeriesChartType.Pie;

            Random random = new Random();
            for (int i = 0; i < sectionCount; i++)
            {
                double value = random.NextDouble() * 100;
                DataPoint dataPoint = new DataPoint();
                dataPoint.SetValueXY("", value);
                dataPoint.Label = value.ToString();
                series.Points.Add(dataPoint);
            }

            chart.Series.Add(series);
            chart.Legends.Add(new Legend());

            // �������� ������� ��������� � ��������� ��������
            ChartArea chartArea = new ChartArea();
            chartArea.Position.Width = 100;
            chartArea.Position.Height = 100;
            chartArea.InnerPlotPosition.Width = 100;
            chartArea.InnerPlotPosition.Height = 100;

            chart.ChartAreas.Add(chartArea);

            // ��������� ��������� � pictureBox
            Bitmap chartImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            chart.Size = new Size(pictureBox.Width, pictureBox.Height);
            chart.DrawToBitmap(chartImage, new Rectangle(0, 0, pictureBox.Width, pictureBox.Height));
            pictureBox.Image = chartImage;

            return chart;
        }







        private void fontChoice_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            // ����������� ����������� ���� ������ ������
            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                // ��������� ���������� ������
                Font selectedFont = fontDialog.Font;

                // ��������� ���������� ������ � ��������� ����
                fontTextBox.Text = selectedFont.Name;
            }
        }

        private void selectBackColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                Color selectedColor = colorDialog.Color;

                // ����������� ���������� ���� � ���� ���������� ����
                colotTextBox.BackColor = selectedColor;
            }
        }

        private void numericValueChanged(object sender, EventArgs e)
        {
            int cellCount = (int)numericUpDown1.Value;
            dataGridView1.RowCount = cellCount;

            for (int i = 0; i < cellCount; i++)
            {
                dataGridView1[0, i].Value = " ";
            }
        }

        private void GenerateHistogram(int sectionCount, PictureBox pictureBox, List<int> values)
        {
            // �������� ������� Bitmap ��� �������� ����������� ���������
            Bitmap chartImage = new Bitmap(pictureBox.Width, pictureBox.Height);

            // �������� ������� Graphics �� Bitmap
            using (Graphics graphics = Graphics.FromImage(chartImage))
            {
                // ������� ������� PictureBox
                graphics.Clear(Color.White);

                // ������ ������ � ������ ������� �������
                int columnWidth = pictureBox.Width / values.Count;
                int maxHeight = pictureBox.Height;

                // �������� ������� Random ��� ��������� ��������� ������
                Random random = new Random();

                // ��������� ������� ������� �� �����������
                for (int i = 0; i < values.Count; i++)
                {
                    int value = Convert.ToInt32(values[i]);

                    // ���������� ������ �������
                    int columnHeight = (int)(maxHeight * (value / 10.0)); // ��������� ��������������� �������� � ������ PictureBox

                    // ���������� ������� �������
                    int columnX = i * columnWidth;
                    int columnY = maxHeight - columnHeight;

                    // ��������� ���������� �����
                    Color columnColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

                    // ��������� �������
                    graphics.FillRectangle(new SolidBrush(columnColor), columnX, columnY, columnWidth, columnHeight);

                    // ��������� �������� ������ �������
                    string valueText = values[i].ToString();
                    SizeF textSize = graphics.MeasureString(valueText, Font);
                    float textX = columnX + (columnWidth - textSize.Width) / 2;
                    float textY = columnY + (columnHeight - textSize.Height) / 2;
                    graphics.DrawString(valueText, Font, Brushes.Black, textX, textY);
                }
            }

            // ��������� ����������� � PictureBox
            pictureBox.Image = chartImage;
        }

        private void RandomGeneration()
        {
            int valueCount = (int)numericUpDown1.Value;

            Random random = new Random();
            dataGridView1.Rows.Clear();

            for (int i = 0; i < valueCount; i++)
            {
                int randomValue = random.Next(1, 15);
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = randomValue;
            }
        }





        private void generateChart_Click(object sender, EventArgs e)
        {
            int sectionCount = (int)numericUpDown1.Value;
            List<int> values = new List<int>();
            if (sortCheck.Checked)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCell cell = row.Cells[0];
                    string value = cell.Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        int numericValue = Convert.ToInt32(value);
                        values.Add(numericValue);
                    }
                }
                values.Sort();
            }
            else
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    DataGridViewCell cell = row.Cells[0];
                    string value = cell.Value?.ToString();
                    if (!string.IsNullOrEmpty(value))
                    {
                        int numericValue = Convert.ToInt32(value);
                        values.Add(numericValue);
                    }
                }
            }



            if (radioButton1.Checked)
            {
                DiagrammForm df = new DiagrammForm();
                Color backColor = colotTextBox.BackColor;
                df.BackColor = backColor;
                Chart chart = GenerateChart(sectionCount, df.pictureBox1); // ��������� ��������� (��������������, ��� � ��� ���� ����� GenerateChart(), ������� ������� � ���������� ������ ���� Chart)

                // �������� ����������� ���������
                Bitmap chartImage = new Bitmap(df.pictureBox1.Width, df.pictureBox1.Height);
                using (Graphics graphics = Graphics.FromImage(chartImage))
                {
                    chart.DrawToBitmap(chartImage, new Rectangle(0, 0, df.pictureBox1.Width, df.pictureBox1.Height));
                }

                // ��������� ����������� � PictureBox
                df.pictureBox1.Image = chartImage;
                df.Show();
            }

            if (radioButton2.Checked)
            {
                DiagrammForm df = new DiagrammForm();
                Color backColor = colotTextBox.BackColor;
                df.BackColor = backColor;
                GenerateHistogram(sectionCount, df.pictureBox1, values);
                df.Show();
            }


        }

        private void randGeneration_Click(object sender, EventArgs e)
        {
            RandomGeneration();
        }
    }
}