using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;

namespace Demo_Folder_and_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\DemoFolder";
            if (Directory.Exists(path))
            {
                MessageBox.Show("folder exist");
            }
            else
            {
                Directory.CreateDirectory(path);

            }
        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            string path = @"D:\DemoFolder\DemoFile";
            if (File.Exists(path))
            {
                MessageBox.Show("file exist");
            }
            else
            {
                File.Create(path);

            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            try 
            { 
            FileStream fs = new FileStream(@"D:\DemoFolder\BinaryFile",FileMode.Create, FileAccess.Write);
            
            BinaryWriter bw = new BinaryWriter(fs);  //create object binarywriter
            bw.Write(Convert.ToInt32(textEmpdept.Text));   //write to file
            bw.Write(textEmpName.Text);
            bw.Close();   // closing files 
            fs.Close();
            MessageBox.Show("file saved");
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnread_Click(object sender, EventArgs e)
        {
            try 
            {
            FileStream fs = new FileStream(@"D:\DemoFolder\BinaryFile",FileMode.Open,FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            textEmpdept.Text = br.ReadInt32().ToString();
            textEmpName.Text = br.ReadString();
            br.Close();
            fs.Close();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnwritexml_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptXML.xml", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(textEmpdept.Text);
                dept.DeptName = textEmpName.Text;
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                xml.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnreadxml_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptXML.xml", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                XmlSerializer xml = new XmlSerializer(typeof(Department));
                dept=(Department)xml.Deserialize(fs);
                textEmpdept.Text = dept.DeptID.ToString();
                textEmpName.Text = dept.DeptName;
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                // create a file, write open
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptBinary.dat", FileMode.Create, FileAccess.Write);
                
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(textEmpdept.Text);
                dept.DeptName = textEmpName.Text;
                BinaryFormatter binary = new BinaryFormatter();
                binary.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBinaryread_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptBinary.dat", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                BinaryFormatter binary = new BinaryFormatter();
                dept = (Department)binary.Deserialize(fs);
                textEmpdept.Text = dept.DeptID.ToString();
                textEmpName.Text = dept.DeptName;
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSoapwrite_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptSoap.soap", FileMode.Create, FileAccess.Write);
                Department dept = new Department();
                dept.DeptID = Convert.ToInt32(textEmpdept.Text);
                dept.DeptName = textEmpName.Text;
                SoapFormatter soap = new SoapFormatter();
                soap.Serialize(fs, dept);
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnreadSoap_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream(@"D:\DemoFolder\demoDeptSoap.soap", FileMode.Open, FileAccess.Read);
                Department dept = new Department();
                SoapFormatter soap = new SoapFormatter();
                dept = (Department)soap.Deserialize(fs);
                textEmpdept.Text = dept.DeptID.ToString();
                textEmpName.Text = dept.DeptName;
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
