using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_MVC_API.Model
{
    [Table("product")]
    public class Product
    {
       [Key]
        public int PID { get; set; }

        public string Pname { get; set; }

        public decimal PPrice { get; set; }
    }
}
