﻿using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivityService
    {
        //new ActivityDao
        ActivityDao activitydb;
        ActivitieFullDao activitieFullDao;
        //constructor to initialize the activitydb
        public ActivityService()
        {
            activitydb = new ActivityDao();
            activitieFullDao= new ActivitieFullDao();

        }

        //command to get all activities with the activitydb
        public List<Activity> GetActivities()
        {
            List<Activity> activities = activitydb.GetAllActivities();
            return activities;
        }
        public List<Activity> GetActivitesWhitTeacherJoin(int TeacherId)
        {
            List<Activity> activitiesSupervisors = activitieFullDao.GetActivitesWhitTeacherJoin(TeacherId);
            return activitiesSupervisors;
        }

        //command to add a activity with the activitydb
        public void AddActivity(Activity activity)
        {
            activitydb.Add(activity);
        }

        //command to update a activity with the activitydb
        public void UpdateActivity(Activity oldActivity, Activity newActivity)
        {
            activitydb.Update(oldActivity, newActivity);
        }

        //command to delete a activity with the activitydb
        public void DeleteActivity(Activity activity)
        {
            activitydb.Delete(activity);
        }

    }
}
