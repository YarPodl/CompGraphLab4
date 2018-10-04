namespace CompGraphLab4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar2 = new System.Windows.Forms.TrackBar();
            this.trackBar3 = new System.Windows.Forms.TrackBar();
            this.trackBar4 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBar5 = new System.Windows.Forms.TrackBar();
            this.trackBar6 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.trackBar7 = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.trackBar8 = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.trackBar9 = new System.Windows.Forms.TrackBar();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(8, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 547);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            this.pictureBox1.Resize += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar1.Location = new System.Drawing.Point(9, 566);
            this.trackBar1.Maximum = 16;
            this.trackBar1.Minimum = 4;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 10;
            this.trackBar1.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Масштаб";
            // 
            // trackBar2
            // 
            this.trackBar2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar2.LargeChange = 90;
            this.trackBar2.Location = new System.Drawing.Point(110, 566);
            this.trackBar2.Maximum = 180;
            this.trackBar2.Minimum = -180;
            this.trackBar2.Name = "trackBar2";
            this.trackBar2.Size = new System.Drawing.Size(104, 45);
            this.trackBar2.SmallChange = 15;
            this.trackBar2.TabIndex = 3;
            this.trackBar2.TickFrequency = 30;
            this.trackBar2.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // trackBar3
            // 
            this.trackBar3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar3.LargeChange = 90;
            this.trackBar3.Location = new System.Drawing.Point(220, 566);
            this.trackBar3.Maximum = 180;
            this.trackBar3.Minimum = -180;
            this.trackBar3.Name = "trackBar3";
            this.trackBar3.RightToLeftLayout = true;
            this.trackBar3.Size = new System.Drawing.Size(104, 45);
            this.trackBar3.SmallChange = 15;
            this.trackBar3.TabIndex = 4;
            this.trackBar3.TickFrequency = 30;
            this.trackBar3.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // trackBar4
            // 
            this.trackBar4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar4.LargeChange = 90;
            this.trackBar4.Location = new System.Drawing.Point(330, 566);
            this.trackBar4.Maximum = 180;
            this.trackBar4.Minimum = -180;
            this.trackBar4.Name = "trackBar4";
            this.trackBar4.Size = new System.Drawing.Size(104, 45);
            this.trackBar4.SmallChange = 15;
            this.trackBar4.TabIndex = 5;
            this.trackBar4.TickFrequency = 30;
            this.trackBar4.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 550);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поворот по оси X";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Поворот по оси Y";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Поворот по оси Z";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(566, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Перемещение по оси Y";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 550);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Перемещение по оси X";
            // 
            // trackBar5
            // 
            this.trackBar5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar5.Location = new System.Drawing.Point(440, 566);
            this.trackBar5.Minimum = -10;
            this.trackBar5.Name = "trackBar5";
            this.trackBar5.RightToLeftLayout = true;
            this.trackBar5.Size = new System.Drawing.Size(104, 45);
            this.trackBar5.TabIndex = 10;
            this.trackBar5.TickFrequency = 2;
            this.trackBar5.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // trackBar6
            // 
            this.trackBar6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar6.Location = new System.Drawing.Point(579, 566);
            this.trackBar6.Minimum = -10;
            this.trackBar6.Name = "trackBar6";
            this.trackBar6.Size = new System.Drawing.Size(104, 45);
            this.trackBar6.TabIndex = 9;
            this.trackBar6.TickFrequency = 2;
            this.trackBar6.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Перемещение по оси Z";
            // 
            // trackBar7
            // 
            this.trackBar7.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar7.Location = new System.Drawing.Point(710, 566);
            this.trackBar7.Minimum = -10;
            this.trackBar7.Name = "trackBar7";
            this.trackBar7.Size = new System.Drawing.Size(104, 45);
            this.trackBar7.TabIndex = 13;
            this.trackBar7.TickFrequency = 2;
            this.trackBar7.Scroll += new System.EventHandler(this.pictureBox1_Resize);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(724, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Угол альфа";
            // 
            // trackBar8
            // 
            this.trackBar8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar8.Location = new System.Drawing.Point(710, 66);
            this.trackBar8.Maximum = 180;
            this.trackBar8.Minimum = -180;
            this.trackBar8.Name = "trackBar8";
            this.trackBar8.Size = new System.Drawing.Size(98, 45);
            this.trackBar8.SmallChange = 15;
            this.trackBar8.TabIndex = 15;
            this.trackBar8.TickFrequency = 30;
            this.trackBar8.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(724, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Проекции";
            // 
            // trackBar9
            // 
            this.trackBar9.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.trackBar9.Location = new System.Drawing.Point(710, 136);
            this.trackBar9.Maximum = 125;
            this.trackBar9.Minimum = 25;
            this.trackBar9.Name = "trackBar9";
            this.trackBar9.Size = new System.Drawing.Size(98, 45);
            this.trackBar9.SmallChange = 25;
            this.trackBar9.TabIndex = 18;
            this.trackBar9.TickFrequency = 25;
            this.trackBar9.Value = 75;
            this.trackBar9.Scroll += new System.EventHandler(this.trackBar8_Scroll);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Коэффециент сжатия";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(710, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 36);
            this.button1.TabIndex = 20;
            this.button1.Text = "Вернуть на исходные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.trackBar9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBar8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.trackBar7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBar5);
            this.Controls.Add(this.trackBar6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar4);
            this.Controls.Add(this.trackBar3);
            this.Controls.Add(this.trackBar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Разработка прил с исп комп графики №4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar2;
        private System.Windows.Forms.TrackBar trackBar3;
        private System.Windows.Forms.TrackBar trackBar4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBar5;
        private System.Windows.Forms.TrackBar trackBar6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar trackBar7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar trackBar8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar trackBar9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

