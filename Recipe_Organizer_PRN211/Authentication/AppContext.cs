using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe_Organizer_PRN211.Authentication
{
    public static class AppContext
    {
        public static User CurrentUser { get; set; }
        public static int RecipeId { get; set; }
    }
}
