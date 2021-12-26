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

namespace Q1Q2_Read_and_Write_Op_XMLSerialization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCreateFolder_Click(object sender, EventArgs e)      // creating folder
        {
            string path = @"D:\QuestionOne&two";
            if (Directory.Exists(path))
            {
                MessageBox.Show("folder exist");
            }
            else
            {
                Directory.CreateDirectory(path);

            }
        }


        private void btnCreateFile_Click(object sender, EventArgs e)   // creating .txt file
        {
            string path = @"D:\QuestionOne&two\Q1File.txt";
            if (File.Exists(path))
            {
                MessageBox.Show("file exist");
            }
            else
            {
                File.Create(path);

            }
        }

        private void btnSave_Click(object sender, EventArgs e)    // save .txt file
        {
            try
            {
                FileStream fs = new FileStream(@"D:\QuestionOne&two\Q1File.txt", FileMode.Create, FileAccess.Write);

                BinaryWriter bw = new BinaryWriter(fs);        //creating object binarywriter
                bw.Write(Convert.ToInt32(textRollNo.Text));    //write to file
                bw.Write(textName.Text);
                bw.Write(Convert.ToDecimal(textMarks.Text));
                bw.Close();                                   //closing files 
                fs.Close();
                MessageBox.Show("file saved");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnreadTxt_Click(object sender, EventArgs e)    // read .txt file
        {
            try
            {
                FileStream fs = new FileStream(@"D:\QuestionOne&two\Q1File.txt", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                textRollNo.Text = br.ReadInt32().ToString();
                textName.Text = br.ReadString();
                textMarks.Text = br.ReadDecimal().ToString();
                br.Close();
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            

        }

        private void btnWriteXML_Click(object sender, EventArgs e)     // .xml file write operation
        {
            try
            {
                FileStream fs = new FileStream(@"D:\QuestionOne&two\studentXML.xml", FileMode.Create, FileAccess.Write);
                Student stu = new Student();
                stu.RollNo = Convert.ToInt32(textRollNo.Text);
                stu.Name = textName.Text;
                stu.Marks = Convert.ToDecimal(textMarks.Text);
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                xml.Serialize(fs, stu);
                fs.Close();
                MessageBox.Show("file created");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnReadXML_Click(object sender, EventArgs e)    // .xml file read operation
        {
            try
            {
                FileStream fs = new FileStream(@"D:\QuestionOne&two\studentXML.xml", FileMode.Open, FileAccess.Read);
                Student stu = new Student();
                XmlSerializer xml = new XmlSerializer(typeof(Student));
                stu = (Student)xml.Deserialize(fs);
                textRollNo.Text =stu.RollNo.ToString();
                textName.Text = stu.Name;
                textMarks.Text = stu.Marks.ToString();
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

       
     

        private void btnWrite_Click_1(object sender, EventArgs e)    // write operation .txt file
        {
            try
            {
                FileStream fs = new FileStream(@"D:\QuestionOne&two\Q1File.txt", FileMode.Create, FileAccess.Write);
                BinaryWriter br = new BinaryWriter(fs);
                br.Write(textRollNo.Text);
                br.Write(textName.Text);
                br.Write(textMarks.Text);
                //textRollNo.Text = br.ReadInt32().ToString();
                //textName.Text = br.ReadString();
                //textMarks.Text = br.ReadDecimal().ToString();
                br.Close();
                fs.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
