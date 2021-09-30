using System;
using System.Collections.Generic;

#nullable disable

namespace OneStopJainGrocery.Models
{
    public partial class Diet
    {
        public Diet()
        {
            GroceryItems = new HashSet<GroceryItem>();
        }

        public int Id { get; set; }
        public string DietType { get; set; }

        public virtual ICollection<GroceryItem> GroceryItems { get; set; }
    }
}
