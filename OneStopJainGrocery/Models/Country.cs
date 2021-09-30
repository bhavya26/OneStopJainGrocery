using System;
using System.Collections.Generic;

#nullable disable

namespace OneStopJainGrocery.Models
{
    public partial class Country
    {
        public Country()
        {
            GroceryItems = new HashSet<GroceryItem>();
        }

        public int Id { get; set; }
        public string Countryname { get; set; }

        public virtual ICollection<GroceryItem> GroceryItems { get; set; }
    }
}
