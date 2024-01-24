using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area_of_a_rectangle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Length;
            double Height;
            double Area;
            double Perimeter;

            Length = double.Parse(textBox1.Text);
            Height = double.Parse(textBox2.Text);
            Area = (Length * Height);
            Perimeter = (Length + Height) * 2;

            textBox3.Text = Area.ToString();
            textBox4.Text = Perimeter.ToString();


        }
    }
}
