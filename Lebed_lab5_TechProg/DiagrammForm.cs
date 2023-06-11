using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Lebed_lab5_TechProg
{
    public partial class DiagrammForm : Form
    {

        private int picMargin = 3;
        public DiagrammForm()
        {
            InitializeComponent();
        }

        private void DiagrammForm_Load(object sender, EventArgs e)
        {

        }

        private void saveDiagramm(object sender, EventArgs e)
        {
            // Открываем диалоговое окно для выбора пути и имени файла
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG Image|*.jpg";
            saveDialog.Title = "Save Chart Image";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                // Получаем путь и имя файла из диалогового окна
                string filePath = saveDialog.FileName;

                // Сохраняем изображение диаграммы
                Bitmap chartImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                using (Graphics graphics = Graphics.FromImage(chartImage))
                {
                    pictureBox1.DrawToBitmap(chartImage, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                }

                ImageFormat imageFormat = ImageFormat.Jpeg;

                // Сохраняем изображение по указанному пути и формату
                chartImage.Save(filePath, imageFormat);
            }
        }

        private void RedrawChart()
        {
            // Проверяем, есть ли диаграмма в пикчербоксе
            if (pictureBox1.Image != null && pictureBox1.Image is Bitmap)
            {
                // Создаем новое изображение с размерами пикчербокса
                Bitmap chartImage = new Bitmap(pictureBox1.Width, pictureBox1.Height);

                // Рисуем диаграмму на новом изображении
                using (Graphics graphics = Graphics.FromImage(chartImage))
                {
                    graphics.DrawImage(pictureBox1.Image, 0, 0, pictureBox1.Width, pictureBox1.Height);
                }

                // Устанавливаем новое изображение в пикчербокс
                pictureBox1.Image = chartImage;
            }
        }

        private void UpdatePictureBoxSize()
        {
            // Вычитаем отступы из размеров формы для пикчербокса
            int pictureBoxWidth = this.ClientSize.Width - 2 * picMargin;
            int pictureBoxHeight = this.ClientSize.Height - 2 * picMargin - menuStrip1.Height;

            // Ограничиваем размеры пикчербокса с минимальными значениями
            pictureBoxWidth = Math.Max(pictureBoxWidth, 650);
            pictureBoxHeight = Math.Max(pictureBoxHeight, 350);

            // Устанавливаем размеры и позицию пикчербокса с отступами
            pictureBox1.Width = pictureBoxWidth;
            pictureBox1.Height = pictureBoxHeight;
            pictureBox1.Location = new Point(picMargin, menuStrip1.Height + picMargin);

            // Перерисовываем диаграмму
            RedrawChart();
        }

        private void resizeWindow(object sender, EventArgs e)
        {
            UpdatePictureBoxSize();
        }
    }
}
