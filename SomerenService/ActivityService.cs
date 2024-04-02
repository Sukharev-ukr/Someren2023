﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class ActivityService
    {
        private TeacherDao teacherDao;
        private StudentDao studentDao;
        private ActivityDao activityDao;

        public ActivityService()
        {
            teacherDao = new TeacherDao();
            studentDao = new StudentDao();
            activityDao = new ActivityDao();
        }

        public List<Activity> GetAllActivities()
        {
            return activityDao.GetAllActivities();
        }

        public Activity GetActivityById(int id)
        {
            foreach (Activity activity in GetAllActivities())
            {
                if (activity.ActivityId == id)
                {
                    return activity;
                }
            }

            return null;
        }

        public List<ActivitySupervisor> GetAllActivitySupervisors()
        {
            TeacherService teacherService = new TeacherService();
            List<ActivitySupervisor> activitySupervisors = new List<ActivitySupervisor>();

            foreach (ActivitySupervisor activitySupervisor in activityDao.GetAllActivitiesSupervisors())
            {
                activitySupervisor.Activity = GetActivityById(activitySupervisor.ActivityID);
                activitySupervisor.Teacher = teacherService.GetTeacherById(activitySupervisor.LecturerID);
                activitySupervisors.Add(activitySupervisor);
            }

            return activitySupervisors;
        }

        public List<ActivityParticipant> GetAllActivityParticipants()
        {
            StudentService studentService = new StudentService();
            List<ActivityParticipant> activityParticipants = new List<ActivityParticipant>();

            foreach (ActivityParticipant activityParticipant in activityDao.GetAllActivityParticipants())
            {
                activityParticipant.Activity = GetActivityById(activityParticipant.ActivityID);
                activityParticipant.Student = studentService.GetStudentById(activityParticipant.StudentID);
                activityParticipants.Add(activityParticipant);
            }

            return activityParticipants;
        }

        public void AddActivitySupervisor(ActivitySupervisor activitySupervisor)
        {
            activityDao.AddActivitySupervisor(activitySupervisor);
        }

        public void AddActivityParticipant(ActivityParticipant activityParticipant)
        {
            activityDao.AddActivityParticipant(activityParticipant);
        }

        public void RemoveActivitySupervisor(ActivitySupervisor activitySupervisor)
        {
            activityDao.RemoveActivitySupervisor(activitySupervisor);
        }

        public void RemoveActivityParticipant(ActivityParticipant activityParticipant)
        {
            activityDao.RemoveActivityParticipant(activityParticipant);
        }
    }
}
