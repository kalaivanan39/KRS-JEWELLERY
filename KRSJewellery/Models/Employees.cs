using System.ComponentModel.DataAnnotations;

namespace KRSJewellery.Models
{
    public class Employees
    {
        [Key]
        public int EMPID { get; set; }

        public string EMPNAME { get; set; }

        public string PLACE { get; set; }

        public string CONTACT { get; set; }

        public string EMAIL { get; set; }

        public decimal SALARY { get; set; }
    }
}
