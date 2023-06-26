﻿using System;
using System.Collections.Generic;

namespace Recipe_Organizer_PRN211.Models
{
    public partial class Recipe
    {
        public Recipe()
        {
            Categories = new HashSet<Category>();
            Sessions = new HashSet<Session>();
            Users = new HashSet<User>();
        }

        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string Ingredient { get; set; } = null!;
        public string? Img { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ICollection<Category> Categories { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
