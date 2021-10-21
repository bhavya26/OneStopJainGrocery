using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneStopJainGrocery.Models_Combined
{
    public class grocery_main
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public string Productimage { get; set; }
        public string Producturl { get; set; }
        public string Categories { get; set; }
        public string DietType { get; set; }
        public string Country { get; set; }

        public int totalSize { get; set; }
    }
}
