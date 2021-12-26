using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enquiry_System_project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = textUname.Text;
            string pass = textPassword.Text="";
            textPassword.PasswordChar = '*';
           
            MessageBox.Show("successfully logged in");
        }
    }
}
