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
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader rdr;
       
        public Form1()
        {
            InitializeComponent();
            //establish connecion with DB
            con = new SqlConnection("Server=.; Database=TBDemo; Integrated Security=True");
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                //writing query
                // string qry = "insert into product values(@PID,@Pname,@PPrice)";
               //cmd = new SqlCommand(qry, con);
               //cmd =new SqlCommand("InsertSP_product", con);           //responsible to fire query in DB
               cmd.commandType=con.CommandType.StoredProcedure;
               cmd.Parameters.AddWithValue("@PID",Convert.ToInt32(textID.Text));      //adding values tothe parameters
               cmd.Parameters.AddWithValue("@Pname",textname.Text );
               cmd.Parameters.AddWithValue("@PPrice",Convert.ToDouble(textprice.Text));
                //open connection with DB
                con.Open();
                //fire query in DB
                int result = cmd.ExecuteNonQuery();   //firing DMl queries
                if(result==1)
                {
                    MessageBox.Show("succesfully saved");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                //writing query
                // string qry = "update product set Pname=@Pname,PPrice=@PPrice where PID=@PID";     //updating values
                // cmd = new SqlCommand(qry, con);    //responsible to fire query in DB
                cmd = new SqlCommand("UpdateSP_product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(textID.Text));      //adding values tothe parameters
                cmd.Parameters.AddWithValue("@Pname", textname.Text);
                cmd.Parameters.AddWithValue("@PPrice", Convert.ToDouble(textprice.Text));
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

        private void btnSearchID_Click(object sender, EventArgs e)
        {
            try
            {
               string qry = "select * from product where PID=@PID";
                cmd = new SqlCommand(qry, con);    
              

                cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(textID.Text));
                
                con.Open();
                rdr = cmd.ExecuteReader();
               
                if (rdr.HasRows)            // check records present or not
                {
                    if (rdr.Read())         // read record from reader
                    {
                        textname.Text = rdr["Pname"].ToString();
                        textprice.Text = rdr["PPrice"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            try
            {
                //writing query
                // string qry = "delete from product where PID=@PID";
                // cmd = new SqlCommand(qry, con);    //responsible to fire query in DB
                cmd = new SqlCommand("DeleteSP_product", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PID", Convert.ToInt32(textID.Text));      //adding values tothe parameters
                
                //open connection with DB
                con.Open();
                //fire query in DB
                int result = cmd.ExecuteNonQuery();   //firing DMl queries
                if (result == 1)
                {
                    MessageBox.Show("succesfully deleted");
                    textID.Clear();
                    textname.Clear();
                    textprice.Clear();
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

        private void btnshowallrec_Click(object sender, EventArgs e)
        {
            try
            {
                //string qry = "select * from product";
                // cmd = new SqlCommand(qry, con);
                // cmd = new SqlCommand(qry, con);                     //responsible to fire query in DB
                cmd = new SqlCommand("Select_AllSP_product, con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                rdr = cmd.ExecuteReader();
                dataGridView1.DataSource = rdr;
                DataTable dataTable = new DataTable();                //data table arrange data in table format from reader  object
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

        
        
        private void btnaddnew_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select MAX(PID) from product";    //it will return max value of id from table
                cmd = new SqlCommand(qry, con);
                con.Open();
                object obj = cmd.ExecuteScalar();   //when u use select with aggregate function use Executescalar for returning single value

                if (obj == DBNull.Value)             // check for null  
                {
                    textID.Text = "1";
                }
                else
                {
                    int PID = Convert.ToInt32(obj);
                    PID++;
                    textID.Text = PID.ToString();

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

        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
