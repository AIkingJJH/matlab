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

    

    public partial class 계산기 : Form
    {

        bool isOperatorClicked;
        public static float a;
        float b ;
        float c;

        string select;
        


        public 계산기()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void but0_Click(object sender, EventArgs e)
        {
            if (isOperatorClicked == true)
            {
                textBox1.Text = "";
            }
            textBox1.Text += ((Button)sender).Text;
            isOperatorClicked = false;
        }

        private void butplus_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text + ((Button)sender).Text;
            if ((Button)sender==butplus)
                select = "selectplus";

            if ((Button)sender == butminus)
                select = "selectminus";

            if ((Button)sender == butmulti)
                select = "selectmultiply";

            if ((Button)sender == butdivide)
                select = "selectdivide";

            a = float.Parse(textBox1.Text);
            textBox1.Text ="";


            isOperatorClicked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                textBox1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        void butequal_Click(object sender, EventArgs e)
        {
            
            string d;

            b = float.Parse(textBox1.Text);
            switch (select)
            {
                case "selectplus":
                    c = a + b;
                    break;

                case "selectminus":
                    c = a - b;
                    break;

                case "selectmultiply":
                    c = a * b;
                    break;

                case "selectdivide":
                    c = a / b;
                    break;
            }

            d = (c).ToString(); 
            
            
            label1.Text = d;
        }

       
    }
}
