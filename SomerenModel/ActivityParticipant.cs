using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class ActivityParticipant
    {
        public int ActivityID { get; set; }
        public int StudentID { get; set; }
        public Activity Activity { get; set; }
        public Student Student { get; set; }

        public ActivityParticipant(int activityID, int studentID)
        {
            ActivityID = activityID;
            StudentID = studentID;
        }


    }
}
