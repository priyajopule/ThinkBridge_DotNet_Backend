using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Enquiry_System_project
{
    public partial class Counsellor : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
        public Counsellor()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.; Database=TBDemo; Integrated Security=True");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                string response;
                if(checkBoxYes.Checked)
                {
                    response = "yes";
                }
                else
                {
                    response = "no";
                }

                //comboBoxCourses.Items.Add("java");
                //comboBoxCourses.Items.Add("c#");
                //comboBoxCourses.Items.Add("HTML");
                //comboBoxCourses.Items.Add("c++");

               
                string course;
                if(comboBoxCourses.Items.Equals("java"))
                {
                    course = "java";
                }
                else if (comboBoxCourses.Items.Equals("HTML"))
                {
                    course = "HTML";
                }
                else if (comboBoxCourses.Items.Equals("C#"))
                {
                    course = "C#";
                }
                else 
                {
                    course = "c++";
                }



                //string name=comboBoxCourses.SelectedValue.ToString();

                string qry = "insert into counsellor values(@stuID,@stu_Name,@course,@followUp,@stu_response)";
                cmd = new SqlCommand(qry, con);                                                 
                cmd.Parameters.AddWithValue("@stuID", Convert.ToInt32(textStuID.Text));                
                cmd.Parameters.AddWithValue("@stu_Name", textStuName.Text);
                cmd.Parameters.AddWithValue("@course", course);
                cmd.Parameters.AddWithValue("@followUp", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@stu_response", response);
                
                con.Open();
               
                int result = cmd.ExecuteNonQuery();   
                if (result == 1)
                {
                    MessageBox.Show("succesfully saved");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from counsellor";
                cmd = new SqlCommand(qry, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dataGridView1.DataSource = rdr;
                DataTable dataTable1 = new DataTable();   
                dataTable1.Load(rdr);
                dataGridView1.DataSource = dataTable1;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
