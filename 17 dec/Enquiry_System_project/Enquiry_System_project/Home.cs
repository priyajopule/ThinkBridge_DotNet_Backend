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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnEnquiry_Click(object sender, EventArgs e)
        {
            Enquiry enquiry = new Enquiry();
            enquiry.Show();        
        }

        private void btnCounseller_Click(object sender, EventArgs e)
        {
            Counsellor counsellor=new Counsellor();
            counsellor.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login login=new Login();
            login.Show();
        }
    }
}
