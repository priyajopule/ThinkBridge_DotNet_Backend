using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace assignment_WindowsFormsApp
{
    public partial class Form1 : Form
    {

        List<Categories> categories = new List<Categories>
        {
            new Categories{CId=1,Name="furniture"},
            new Categories{CId=2,Name="Electronics"},
            new Categories{CId=3, Name="mobile" }
        };

        List<Products> plist = new List<Products> {
             new Products{PId=101,ProductName="Sofa",Price=34000,CId=1},
             new Products{PId=102,ProductName="Chair",Price=4000,CId=1},
             new Products{PId=103,ProductName="Sony LED",Price=74000,CId=2},
             new Products{PId=104,ProductName="Intex LED",Price=74000,CId=2},
             new Products{PId=105,ProductName="Apple 10",Price=74000,CId=3},
             new Products{PId=106,ProductName="Samsung",Price=23000,CId=3},
        };

        List<Products> filterList = new List<Products>();


        public Form1()
        {
            InitializeComponent();
            comboBoxcat.DataSource = categories;
            comboBoxcat.ValueMember = "CId";
            comboBoxcat.DisplayMember = "Name";
        }

        private void comboBoxcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            filterList.Clear();
            checkedListBoxcat.Items.Clear();
            Categories c = (Categories)checkedListBoxcat.SelectedItem;
            foreach (Products item in plist)
            {
                if (item.CId == c.CId)
                {
                    filterList.Add(item);
                }
            }
            foreach (Products item in filterList)
            {
              checkedListBoxcat.Items.Add(item.ProductName);
            }
        }

        private void btn_view_Click(object sender, EventArgs e)
        {

            labelprdt.Text = "Selected Products :";
            for (int i = 0; i < checkedListBoxcat.Items.Count; i++)
            {
                if (checkedListBoxcat.GetItemCheckState(i) == CheckState.Checked)
                {
                    labelprdt.Text += " " + checkedListBoxcat.Items[i];
                }
            }
        }
    }
}
