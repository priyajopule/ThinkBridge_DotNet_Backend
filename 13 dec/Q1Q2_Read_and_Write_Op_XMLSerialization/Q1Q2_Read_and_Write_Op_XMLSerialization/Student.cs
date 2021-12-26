using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1Q2_Read_and_Write_Op_XMLSerialization
{
    [Serializable]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public decimal Marks { get; set; }
    }
}
