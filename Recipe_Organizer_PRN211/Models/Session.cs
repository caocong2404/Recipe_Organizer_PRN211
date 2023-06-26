using System;
using System.Collections.Generic;

namespace Recipe_Organizer_PRN211.Models
{
    public partial class Session
    {
        public Session()
        {
            Recipes = new HashSet<Recipe>();
        }

        public int SessionId { get; set; }
        public int DayId { get; set; }
        public string SessionName { get; set; } = null!;

        public virtual Day Day { get; set; } = null!;

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
