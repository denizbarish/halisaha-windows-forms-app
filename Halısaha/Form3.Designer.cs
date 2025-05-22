namespace halısaha
{
    partial class Form3
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
            label1 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label5 = new Label();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.LightGoldenrodYellow;
            label1.Location = new Point(191, 10);
            label1.Name = "label1";
            label1.Size = new Size(404, 25);
            label1.TabIndex = 2;
            label1.Text = "HALI SAHA REZERVASYON SİSTEMİ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(0, 64, 0);
            label3.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.White;
            label3.Location = new Point(239, 130);
            label3.Name = "label3";
            label3.Size = new Size(91, 16);
            label3.TabIndex = 4;
            label3.Text = "Tarih Seçiniz:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(239, 150);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(239, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(0, 64, 0);
            label2.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = Color.White;
            label2.Location = new Point(239, 210);
            label2.Name = "label2";
            label2.Size = new Size(84, 16);
            label2.TabIndex = 7;
            label2.Text = "Saat Seçiniz:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(0, 64, 0);
            label4.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(542, 130);
            label4.Name = "label4";
            label4.Size = new Size(87, 16);
            label4.TabIndex = 8;
            label4.Text = "Saha Seçiniz:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(542, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(200, 23);
            comboBox2.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(0, 64, 0);
            label5.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.ForeColor = Color.White;
            label5.Location = new Point(542, 210);
            label5.Name = "label5";
            label5.Size = new Size(153, 16);
            label5.TabIndex = 10;
            label5.Text = "Halı saha doluluk oranı:";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(542, 229);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 23);
            progressBar1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.LightGoldenrodYellow;
            button1.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.FromArgb(0, 64, 0);
            button1.Location = new Point(422, 286);
            button1.Name = "button1";
            button1.Size = new Size(135, 36);
            button1.TabIndex = 12;
            button1.Text = "Takım Oluştur";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGoldenrodYellow;
            button2.Font = new Font("Century Schoolbook", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.FromArgb(0, 64, 0);
            button2.Location = new Point(401, 341);
            button2.Name = "button2";
            button2.Size = new Size(180, 39);
            button2.TabIndex = 13;
            button2.Text = "Rezervasyon Oluştur";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGoldenrodYellow;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 428);
            panel1.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 64, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, -1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 50);
            panel2.TabIndex = 15;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bg__3_;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(136, 46);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(708, 395);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(844, 440);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(comboBox2);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label4;
        private ComboBox comboBox2;
        private Label label5;
        private ProgressBar progressBar1;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
    }
}