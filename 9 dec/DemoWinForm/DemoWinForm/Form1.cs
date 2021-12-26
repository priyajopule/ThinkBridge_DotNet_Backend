using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace DemoWinForm
{
    public partial class Form1 : Form
    {
         List<Department> dept=new List<Department>();   

      


        public Form1()
        {
            InitializeComponent();
            dept.Add(new Department { Id = 1, Name = "testing"});
            dept.Add(new Department { Id = 2, Name = "HR" });
            dept.Add(new Department { Id = 3, Name = "Development" });
            comboBoxDept.DataSource = dept;
            comboBoxDept.ValueMember = "Id";
            comboBoxDept.DisplayMember = "Name";
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textEmpName.Text))
            {
                MessageBox.Show("Name is required");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textEmpID.Clear();
            textEmpName.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            Department dept=(Department)comboBoxDept.SelectedItem;
            textEmpID.Text = dept.Id.ToString();
          
            
        }

        private void textHRA_TextChanged(object sender, EventArgs e)
        {
           
        
        }

        private void textBSalary_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double basicsalary = Convert.ToDouble(textBSalary.Text);
                if(basicsalary>0)
                {
                    double hra = basicsalary * 0.20;
                    double ta = basicsalary * 0.15;
                    double pf = basicsalary * 0.12;
                    double petpaid = (basicsalary + hra + pf) - pf;
                    textHRA.Text = hra.ToString();
                    textTA.Text = ta.ToString();
                    textPF.Text = pf.ToString();
                    textNetPaid.Text = petpaid.ToString();

                }

                else
                {
                    textBSalary.Clear();
                    textHRA.Clear();
                    textTA.Clear();
                    textPF.Clear();

                }
            }

            catch (Exception ex)
            { }
        }
    }
}
