using System;
using System.Collections.Generic;

#nullable disable

namespace OneStopJainGrocery.Models
{
    public partial class GroceryItem
    {
        public int Id { get; set; }
        public string Productname { get; set; }
        public string Productimage { get; set; }
        public string Producturl { get; set; }
        public int? Categories { get; set; }
        public int? DietType { get; set; }
        public int? Country { get; set; }

        public virtual Category CategoriesNavigation { get; set; }
        public virtual Country CountryNavigation { get; set; }
        public virtual Diet DietTypeNavigation { get; set; }
    }
}
