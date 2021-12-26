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


namespace Demo_ADOdotNET
{

    public partial class Form2 : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;

        public Form2()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.; Database=TBDemo; Integrated Security=True");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                
                string qry = "insert into Employee values(@ID,@EName,@Salary,@DeptNo)"; //writing query
                cmd = new SqlCommand(qry, con);                                         //responsible to fire query in DB
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(textEmpId.Text));      //adding values tothe parameters
                cmd.Parameters.AddWithValue("@EName", textEmpName.Text);
                cmd.Parameters.AddWithValue("@Salary", Convert.ToDouble(textSalary.Text));
                cmd.Parameters.AddWithValue("@DeptNo", Convert.ToInt32(textDeptNo.Text));
                //open connection with DB
                con.Open();
                //fire query in DB
                int result = cmd.ExecuteNonQuery();   //firing DMl queries
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

        private void btnDelete_Click(object sender, EventArgs e)
        {

            try
            {
                //writing query
                string qry = "delete from Employee where Id=@ID";
                cmd = new SqlCommand(qry, con);    //responsible to fire query in DB
                cmd.Parameters.AddWithValue("@ID", Convert.ToInt32(textEmpId.Text));      //adding values tothe parameters

                //open connection with DB
                con.Open();
                //fire query in DB
                int result = cmd.ExecuteNonQuery();   //firing DMl queries
                if (result == 1)
                {
                    MessageBox.Show("succesfully deleted");
                    textEmpId.Clear();
                    textEmpName.Clear();
                    textSalary.Clear();
                    textDeptNo.Clear();
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "select MAX(ID) from Employee";    //it will return max value of id from table
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();   //when u use select with aggregate function use Executescalar for returning single value

                if (obj == DBNull.Value)             // check for null  
                {
                    textEmpId.Text = "1";
                }
                else
                {
                    int ID = Convert.ToInt32(obj);
                    ID++;
                    textEmpId.Text = ID.ToString();

                }
                // textname.Clear();

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            textEmpId.Clear();
            textEmpName.Clear();
            textSalary.Clear();
            textDeptNo.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {

            try
            {
                string qry = "select * from employee";
                cmd = new SqlCommand(qry, con);
                con.Open();
                rdr = cmd.ExecuteReader();
                dataGridView1.DataSource = rdr;
                DataTable dataTable = new DataTable();    //data table arrange data in table format from reader  object
                dataTable.Load(rdr);
                dataGridView1.DataSource = dataTable;

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
