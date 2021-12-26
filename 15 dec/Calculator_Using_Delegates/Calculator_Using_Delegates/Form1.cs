using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Using_Delegates
{

    public delegate void calDelegate(int a, int b);           //delegate
    public partial class Form1 : Form
    {
        public string ch;
        double resultValue = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn=(Button)sender;                            //casting object to button
            textinput.Text = textinput.Text + btn.Text;
        }

        private void btnCalculation_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;                            //casting object to button
            textinput.Text = textinput.Text + btn.Text;
            
        }

        private void btneql_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           // textinput.Text = (textinput.Text + btn.Text) + ToString();
            switch (ch)
            {
                case "+":
                    textinput.Text = (resultValue + double.Parse(textinput.Text)).ToString();
                    break;
                case "-":
                    textinput.Text = (resultValue - double.Parse(textinput.Text)).ToString();
                    break;
                case "*":
                    textinput.Text = (resultValue * double.Parse(textinput.Text)).ToString();
                    break;
                case "/":
                    textinput.Text = (resultValue / double.Parse(textinput.Text)).ToString();
                    break;
                default:
                    break;


            }
        }
    }
}
