using System;
using System.Collections.Generic;

#nullable disable

namespace OneStopJainGrocery.Models
{
    public partial class Category
    {
        public Category()
        {
            GroceryItems = new HashSet<GroceryItem>();
        }

        public int Id { get; set; }
        public string Categories { get; set; }

        public virtual ICollection<GroceryItem> GroceryItems { get; set; }
    }
}
