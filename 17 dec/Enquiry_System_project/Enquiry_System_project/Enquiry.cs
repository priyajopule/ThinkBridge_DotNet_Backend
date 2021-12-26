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
    public partial class Enquiry : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        
        public Enquiry()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.; Database=TBDemo; Integrated Security=True");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string course;
                if (checkBoxCSharp.Checked)
                {
                    course = "C Sharp";
                }
                else if (checkBoxJava.Checked)
                {
                    course = "java";
                }
                else if (checkBoxHTML.Checked)
                {
                    course = "HTML";
                }
                else
                {
                    course = "CPP";
                }
                MessageBox.Show("your course choice:" + course);

                con.Open();
                string qry= "insert into enquiry values(@username,@mobno,@address,@email_id,@course_choice)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@username", textUname.Text);
                cmd.Parameters.AddWithValue("@mobno", Convert.ToInt32(textConNo.Text));
                cmd.Parameters.AddWithValue("@address", textAddress.Text);
                cmd.Parameters.AddWithValue("@email_id", textemail.Text);
                cmd.Parameters.AddWithValue("@course_choice", course);
                //cmd.Parameters.AddWithValue("@courses", checkBoxCSharp.Text);
                //cmd.Parameters.AddWithValue("@courses", checkBoxHTML.Text);
                //cmd.Parameters.AddWithValue("@courses", checkBoxJava.Text);
               
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
    }
}
