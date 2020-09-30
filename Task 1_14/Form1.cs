using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_1_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text.Replace(".", ","));
            if(Math.Abs(x) > 1){
                label11.Text = "ВЫ ВВЕЛИ ЗНАЧЕНИЕ |x|>1";
                return; 
            }
            int n = int.Parse(comboBox1.Text);
            double E = double.Parse(textBox2.Text.Replace(".", ","));
            double lastElem = 0; 
            double myLog = MyMath.MyLn(x, n, ref lastElem); 
            textBox6.Text = Convert.ToString(Math.Log(1 + x));
            textBox3.Text = Convert.ToString(myLog);
            textBox4.Text = Convert.ToString((Math.Abs(Math.Log(1 + x) - myLog)));
            if (Math.Log(1 + x) - myLog > Math.Abs(lastElem)) textBox5.Text = "Погрешность больше модуля последнего слогаемого";
            else textBox5.Text = "Погрешность меньше модуля последнего слогаемого";
            int N = 0;   
            textBox7.Text = Convert.ToString(MyMath.SumLast(x, E, ref N));
            textBox8.Text = Convert.ToString(N);
            textBox9.Text = Convert.ToString(MyMath.SumLast(x, E/10, ref N));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
