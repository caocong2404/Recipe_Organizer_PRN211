using Services.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recipe_Organizer_PRN211.Plan
{
    public partial class ARecipe : UserControl
    {
        private PlanItem job;

        public PlanItem Job
        {
            get { return job; }
            set { job = value; }
        }

        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }
        public ARecipe(PlanItem job)
        {
            InitializeComponent();

            cbStatus.DataSource = PlanItem.ListStatus;

            this.Job = job;

            ShowInfo();
        }

        void ShowInfo()
        {
            txbJob.Text = Job.Recipe.Title;

            cbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Job.Status);
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (deleted != null)
                deleted(this, new EventArgs());
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Job.Recipe.Title = txbJob.Text;

            Job.Status = PlanItem.ListStatus[cbStatus.SelectedIndex];

            if (edited != null)
                edited(this, new EventArgs());
        }

        
    }
}
