namespace Lebed_lab5_TechProg
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            gmail = new Button();
            gitHub = new Button();
            telegram = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 170);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 12);
            label1.Name = "label1";
            label1.Size = new Size(194, 25);
            label1.TabIndex = 1;
            label1.Text = "Студент групи 525В";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(195, 37);
            label2.Name = "label2";
            label2.Size = new Size(136, 25);
            label2.TabIndex = 2;
            label2.Text = "Лебідь Нікіта";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(193, 94);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 3;
            label3.Text = "Follow my links:";
            // 
            // gmail
            // 
            gmail.BackgroundImage = (Image)resources.GetObject("gmail.BackgroundImage");
            gmail.BackgroundImageLayout = ImageLayout.Stretch;
            gmail.Location = new Point(193, 128);
            gmail.Name = "gmail";
            gmail.Size = new Size(65, 54);
            gmail.TabIndex = 4;
            gmail.UseVisualStyleBackColor = true;
            gmail.Click += gmail_Click;
            // 
            // gitHub
            // 
            gitHub.BackgroundImage = (Image)resources.GetObject("gitHub.BackgroundImage");
            gitHub.BackgroundImageLayout = ImageLayout.Stretch;
            gitHub.Location = new Point(264, 128);
            gitHub.Name = "gitHub";
            gitHub.Size = new Size(65, 54);
            gitHub.TabIndex = 5;
            gitHub.UseVisualStyleBackColor = true;
            gitHub.Click += gitHub_Click;
            // 
            // telegram
            // 
            telegram.BackgroundImage = (Image)resources.GetObject("telegram.BackgroundImage");
            telegram.BackgroundImageLayout = ImageLayout.Stretch;
            telegram.Location = new Point(335, 128);
            telegram.Name = "telegram";
            telegram.Size = new Size(64, 54);
            telegram.TabIndex = 6;
            telegram.UseVisualStyleBackColor = true;
            telegram.Click += telegram_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 194);
            Controls.Add(telegram);
            Controls.Add(gitHub);
            Controls.Add(gmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Info about author";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button gmail;
        private Button gitHub;
        private Button telegram;
    }
}