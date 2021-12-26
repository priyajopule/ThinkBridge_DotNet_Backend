using System;
using System.Windows.Forms;
using System.Data.SqlClient;   //ADO.NET
using System.Data;

namespace ADODisconnectedDemo
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cb;
        public Form1()
        {
            InitializeComponent();
            con = new SqlConnection("Server=.; Database=TBDemo; Integrated Security=True");
        }

        private DataSet GetRecords()
        {
            da=new SqlDataAdapter("select * from product",con);
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            cb=new SqlCommandBuilder(da);     //pass to adaptera after generating query
            ds=new DataSet();
            da.Fill(ds,"prod");
            return ds;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetRecords();
                DataRow row = ds.Tables["prod"].NewRow();    //to insert
                row["PID"] = textPid.Text;
                row["Pname"] = textPname.Text;
                row["PPrice"] = textPrice.Text;
                ds.Tables["prod"].Rows.Add(row);     //add row in to the dataset table
                da.Update(ds.Tables["prod"]);        //update the new row in to the main DB
                int res = da.Update(ds.Tables["prod"]);
                if (res == 1)
                {
                    MessageBox.Show("record successfully saved");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetRecords();
                DataRow row = ds.Tables["prod"].Rows.Find(textPid.Text);   //find() always work with primarykey col
                row["Pname"] = textPname.Text;
                row["PPrice"] = textPrice.Text;
                int res = da.Update(ds.Tables["prod"]);
                if (res == 1)
                {
                    MessageBox.Show("record successfully updated");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetRecords();
                DataRow row = ds.Tables["prod"].Rows.Find(textPid.Text);   //find() always work with primarykey col
                row.Delete();
                int res = da.Update(ds.Tables["prod"]);
                if (res == 1)
                {
                    MessageBox.Show("record successfully deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {

            try
            {
                ds = GetRecords();
                DataRow row = ds.Tables["prod"].Rows.Find(textPid.Text);   //find() always work with primarykey col
                textPid.Text= row["PID"].ToString();
                textPname.Text = row["Pname"].ToString();
                textPrice.Text=row["PPrice"].ToString();
                int res = da.Update(ds.Tables["prod"]);
                if (res == 1)
                {
                    MessageBox.Show("record successfully deleted");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btnShowAllrecords_Click(object sender, EventArgs e)
        {
            ds = GetRecords();
            dataGridView1.DataSource = ds.Tables["prod"];
        }
    }
}

