using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class Category
    {
        public Category()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int CategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
