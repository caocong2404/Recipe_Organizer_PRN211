using System;
using System.Collections.Generic;

namespace Services.Models
{
    public partial class MealPlanning
    {
        public int PlanId { get; set; }
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public DateTime WeekStartDate { get; set; }
        public string Session { get; set; } = null!;

        public virtual Recipe Recipe { get; set; } = null!;
        public virtual User User { get; set; } = null!;
    }
}
