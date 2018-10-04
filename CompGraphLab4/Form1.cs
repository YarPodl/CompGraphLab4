using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompGraphLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        Castle castle = new Castle();
        
        /// <summary>
        /// Отрисовка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            castle.Draw(
                e.Graphics, 
                trackBar1.Value, 
                trackBar2.Value, 
                trackBar3.Value, 
                trackBar4.Value,
                trackBar5.Value,
                trackBar6.Value,
                trackBar7.Value,
                trackBar8.Value,
                trackBar9.Value
                );
        }

        /// <summary>
        /// Перерисовка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void trackBar8_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trackBar1.Value = (trackBar1.Maximum + trackBar1.Minimum) / 2;
            trackBar2.Value = (trackBar2.Maximum + trackBar2.Minimum) / 2;
            trackBar3.Value = (trackBar3.Maximum + trackBar3.Minimum) / 2;
            trackBar4.Value = (trackBar4.Maximum + trackBar4.Minimum) / 2;
            trackBar5.Value = (trackBar5.Maximum + trackBar5.Minimum) / 2;
            trackBar6.Value = (trackBar6.Maximum + trackBar6.Minimum) / 2;
            trackBar7.Value = (trackBar7.Maximum + trackBar7.Minimum) / 2;
            trackBar8.Value = (trackBar8.Maximum + trackBar8.Minimum) / 2;
            trackBar9.Value = (trackBar9.Maximum + trackBar9.Minimum) / 2;
            pictureBox1.Refresh();
        }
    }
}
