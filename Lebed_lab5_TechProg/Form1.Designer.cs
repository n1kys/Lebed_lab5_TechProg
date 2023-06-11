namespace Lebed_lab5_TechProg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            numericUpDown1 = new NumericUpDown();
            groupBox1 = new GroupBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            colotTextBox = new TextBox();
            fontTextBox = new TextBox();
            fontChoice = new Button();
            selectBackColor = new Button();
            sortCheck = new CheckBox();
            groupBox3 = new GroupBox();
            generateChart = new Button();
            randGeneration = new Button();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            authorToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(69, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Кругова";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 52);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(166, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "Вертикальна гістограмма";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(158, 33);
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericValueChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Location = new Point(12, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 85);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Тип діаграми";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 4;
            label1.Text = "Кількість значень";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(colotTextBox);
            groupBox2.Controls.Add(fontTextBox);
            groupBox2.Controls.Add(fontChoice);
            groupBox2.Controls.Add(selectBackColor);
            groupBox2.Location = new Point(12, 151);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(266, 82);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметри діаграми";
            // 
            // colotTextBox
            // 
            colotTextBox.Location = new Point(101, 23);
            colotTextBox.Name = "colotTextBox";
            colotTextBox.ReadOnly = true;
            colotTextBox.Size = new Size(153, 23);
            colotTextBox.TabIndex = 8;
            // 
            // fontTextBox
            // 
            fontTextBox.Location = new Point(101, 51);
            fontTextBox.Name = "fontTextBox";
            fontTextBox.ReadOnly = true;
            fontTextBox.Size = new Size(153, 23);
            fontTextBox.TabIndex = 8;
            // 
            // fontChoice
            // 
            fontChoice.Location = new Point(6, 51);
            fontChoice.Name = "fontChoice";
            fontChoice.Size = new Size(89, 23);
            fontChoice.TabIndex = 7;
            fontChoice.Text = "Шрифт";
            fontChoice.UseVisualStyleBackColor = true;
            fontChoice.Click += fontChoice_Click;
            // 
            // selectBackColor
            // 
            selectBackColor.Location = new Point(6, 22);
            selectBackColor.Name = "selectBackColor";
            selectBackColor.Size = new Size(89, 23);
            selectBackColor.TabIndex = 6;
            selectBackColor.Text = "Колір фону";
            selectBackColor.UseVisualStyleBackColor = true;
            selectBackColor.Click += selectBackColor_Click;
            // 
            // sortCheck
            // 
            sortCheck.AutoSize = true;
            sortCheck.Location = new Point(9, 22);
            sortCheck.Name = "sortCheck";
            sortCheck.Size = new Size(144, 19);
            sortCheck.TabIndex = 6;
            sortCheck.Text = "Виконати сортування";
            sortCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(generateChart);
            groupBox3.Controls.Add(sortCheck);
            groupBox3.Controls.Add(randGeneration);
            groupBox3.Location = new Point(12, 239);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(266, 85);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Дії";
            // 
            // generateChart
            // 
            generateChart.Location = new Point(160, 47);
            generateChart.Name = "generateChart";
            generateChart.Size = new Size(97, 26);
            generateChart.TabIndex = 1;
            generateChart.Text = "Згенерувати";
            generateChart.UseVisualStyleBackColor = true;
            generateChart.Click += generateChart_Click;
            // 
            // randGeneration
            // 
            randGeneration.Location = new Point(5, 47);
            randGeneration.Name = "randGeneration";
            randGeneration.Size = new Size(147, 26);
            randGeneration.TabIndex = 0;
            randGeneration.Text = "Випадкові значення";
            randGeneration.UseVisualStyleBackColor = true;
            randGeneration.Click += randGeneration_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(291, 31);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(187, 293);
            dataGridView1.TabIndex = 9;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { authorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(487, 24);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // authorToolStripMenuItem
            // 
            authorToolStripMenuItem.Name = "authorToolStripMenuItem";
            authorToolStripMenuItem.Size = new Size(92, 20);
            authorToolStripMenuItem.Text = "About Author";
            authorToolStripMenuItem.Click += authorToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 336);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Diagramm Assistant";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private NumericUpDown numericUpDown1;
        private GroupBox groupBox1;
        private Label label1;
        private GroupBox groupBox2;
        private TextBox colotTextBox;
        private TextBox fontTextBox;
        private Button fontChoice;
        private Button selectBackColor;
        private CheckBox sortCheck;
        private GroupBox groupBox3;
        private Button generateChart;
        private Button randGeneration;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem authorToolStripMenuItem;
    }
}