using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class User
    {
        public User()
        {
            Feedbacks = new HashSet<Feedback>();
            MealPlannings = new HashSet<MealPlanning>();
            RecipesNavigation = new HashSet<Recipe>();
            Recipes = new HashSet<Recipe>();
        }

        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Role { get; set; } = null!;
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? Birthday { get; set; }
        public bool? Status { get; set; }
        public string? Avater { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<MealPlanning> MealPlannings { get; set; }
        public virtual ICollection<Recipe> RecipesNavigation { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
