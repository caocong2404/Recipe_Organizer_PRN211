using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    [Serializable]
    public class PlanData
    {
        private List<PlanItem> job;

        public List<PlanItem> Job
        {
            get { return job; }
            set { job = value; }
        }
    }
}
