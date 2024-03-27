using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class ActivitySupervisor
    {
        public int ActivityID { get; set; }
        public int LecturerID { get; set; }
        public Activity Activity { get; set; }
        public Teacher Teacher { get; set; }

        public ActivitySupervisor(int activityID, int lecturerID)
        {
            ActivityID = activityID;
            LecturerID = lecturerID;
        }


    }
}
