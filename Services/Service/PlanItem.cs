using Services.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public class PlanItem
    {
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private int userId;

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }

        private Recipe recipe;

        public Recipe Recipe
        {
            get { return recipe; }
            set { recipe = value; }
        }

        

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public static List<string> ListStatus = new List<string>() { "Breakfast", "Lunch", "Dinner" };
    }

    public enum EPlanItem
    {
        Breakfast,
        Lunch,
        Dinner
    }
}

