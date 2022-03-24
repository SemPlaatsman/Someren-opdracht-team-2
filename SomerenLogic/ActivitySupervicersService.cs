using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ActivitySupervicersService
    {
        ActivitieFullDao activitieFullDao;

        public ActivitySupervicersService()
        {
            activitieFullDao = new ActivitieFullDao();
        }



        //get all activities
        public List<Activity> GetActivitesWhitTeacherJoin(int TeacherId)
        {
            List<Activity> activitiesSupervisors = activitieFullDao.GetActivitesWhitTeacherJoin(TeacherId);
            return activitiesSupervisors;
        }
        //set activities
        public void InsertActivity(int activity,List<Teacher> teachers)
        {
            foreach(Teacher teacher in teachers)
            {
                activitieFullDao.InsertActivity(activity, teacher);
            }
        }
        public void DeleteActivity(int activity, List<Teacher> teachers)
        {
            foreach (Teacher teacher in teachers)
            {
                activitieFullDao.DeleteActivity(activity, teacher);
            }
        }
        

    }
}
