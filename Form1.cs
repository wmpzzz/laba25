using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime dateNow = DateTime.Now;
            int DB = dateNow.Year - dateTimePicker1.Value.Year;
            if (dateNow.Month < dateTimePicker1.Value.Month ||
                (dateNow.Month == dateTimePicker1.Value.Month && dateNow.Day < dateTimePicker1.Value.Day)) DB--;
            label2.Text = "Вам " + DB + " лет";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value + " рублей";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal per = Math.Round(2 * (numericUpDown1.Value + numericUpDown2.Value), 2);
            decimal plosh = Math.Round(numericUpDown1.Value * numericUpDown2.Value, 2);
            label7.Text = "Площадь равна "+ plosh + " метрам";
            label8.Text = "Периметр равен "+ per + " метрам";
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            decimal per = Math.Round(2 * (numericUpDown1.Value + numericUpDown2.Value),2);
            decimal plosh = Math.Round(numericUpDown1.Value * numericUpDown2.Value, 2);
            label7.Text = "Площадь равна " + plosh + " метрам";
            label8.Text = "Периметр равен " + per + " метрам";
        }
    }
}
