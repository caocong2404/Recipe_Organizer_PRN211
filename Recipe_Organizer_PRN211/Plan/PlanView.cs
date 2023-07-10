using Recipe_Organizer_PRN211.Authentication;
using Recipe_Organizer_PRN211.Recipe;
using Services.Models;
using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Recipe_Organizer_PRN211.Plan
{
    public partial class PlanView : Form
    {


        #region Peoperties

        private MealPlanningRepository _mealPlanningRepository = new MealPlanningRepository();
        private RecipeRepository _recipeRepository = new RecipeRepository();
        private List<List<Button>> matrix;


        public List<List<Button>> Matrix
        {
            get { return matrix; }
            set { matrix = value; }
        }

        private PlanData job;

        public PlanData Job
        {
            get { return job; }
            set { job = value; }
        }

        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public PlanView()
        {
            InitializeComponent();

            LoadMatrix();
            int userId = Recipe_Organizer_PRN211.Authentication.AppContext.CurrentUser.UserId;

            Job = DeserializeFromXML(userId);
            if (job == null)
            {
                Plan.AppContext.planData = new PlanData();
            }


        }

        void SetDefaultJob()
        {
            Job = new PlanData();
            Job.Job = new List<PlanItem>();
            Job.Job.Add(new PlanItem()
            {
                Date = DateTime.Now,

                RecipeId = -1,
                Status = PlanItem.ListStatus[(int)EPlanItem.Breakfast]
            });
        }

        void LoadMatrix()
        {
            Matrix = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {
                    Button btn = new Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += btn_Click;

                    pnlMatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);

                    oldBtn = btn;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight) };
            }

            SetDefaultDate();
        }

        void btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
                return;
            DailyPlan daily = new DailyPlan(new DateTime(dtpkDate.Value.Year, dtpkDate.Value.Month, Convert.ToInt32((sender as Button).Text)), Job);
            this.Hide();
            daily.ShowDialog();
            this.Show();
        }

        int DayOfMonth(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
        }

        void AddNumberIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime useDate = new DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());
                Button btn = Matrix[line][column];
                btn.Text = i.ToString();

                if (isEqualDate(useDate, DateTime.Now))
                {
                    btn.BackColor = Color.Yellow;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = Color.Aqua;
                }

                if (column >= 6)
                    line++;

                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(DateTime dateA, DateTime dateB)
        {
            return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        }

        void ClearMatrix()
        {
            for (int i = 0; i < Matrix.Count; i++)
            {
                for (int j = 0; j < Matrix[i].Count; j++)
                {
                    Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.BackColor = Color.WhiteSmoke;
                }
            }
        }

        void SetDefaultDate()
        {
            dtpkDate.Value = DateTime.Now;
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(1);
        }

        private void btnPreviours_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddMonths(-1);
        }

        private void btnToDay_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }



        private PlanData DeserializeFromXML(int userId)
        {
            List<MealPlanning> mealPlannings = _mealPlanningRepository.getListRecipesByUserId(userId);

            PlanData data = new PlanData();
            data.Job = new List<PlanItem>();
            if (mealPlannings.Count > 0)
            {
                foreach (MealPlanning item in mealPlannings)
                {
                    data.Job.Add(new PlanItem()
                    {
                        Date = item.WeekStartDate,
                        RecipeId = item.RecipeId,
                        Status = item.Session,
                        UserId = userId
                    });
                }
            }

            return data;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<MealPlanning> mealPlannings = new List<MealPlanning>();
            int userId = Recipe_Organizer_PRN211.Authentication.AppContext.CurrentUser.UserId;
            if (Job.Job == null)

            {
                Job = Plan.AppContext.planData;
            }
            if (Job.Job == null)
            {
                _mealPlanningRepository.DeleteAllPlan(userId);
            }
            else

            if (Job.Job.Count > 0)
            {
                foreach (PlanItem item in Job.Job)
                {
                    if (item.RecipeId != -1)
                    {
                        mealPlannings.Add(new MealPlanning()
                        {
                            RecipeId = item.RecipeId,
                            UserId = item.UserId,
                            Session = item.Status,
                            WeekStartDate = item.Date
                        });
                    }
                }


                _mealPlanningRepository.SavePlan(mealPlannings, userId);
            }



        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlanView_Load(object sender, EventArgs e)
        {

        }
    }
}







