using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weight_and_Height_index
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double height, weight;

            height=Double.Parse(textBox1.Text);
            weight = Double.Parse(textBox2.Text);

            double result=weight/(height*height);   

            textBox3.Text=result.ToString();

        }
    }
}
