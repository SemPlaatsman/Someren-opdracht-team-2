﻿using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ActivitieFullDao :BaseDao
    {
        // get all activites supervisors

        public List<Activity> GetActivitesWhitTeacherJoin(int activitieId)
        {
            string query = "SELECT A.*,T.*" +
                "FROM ActivitySupervisor as ACS " +
                "JOIN Activities as A on ACS.activityId = A.activityId " +
                "JOIN Teachers as T on ACS.teacherId = T.teacherId " +
                "WHERE A.activityId = @ActivityId ";
            SqlParameter[] sqlParameters = new SqlParameter[1]
            {
                new SqlParameter("@ActivityId",activitieId)
             };
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void InsertActivity(int activity, Teacher teaches)
        {
            string query = "INSERT INTO ActivitySupervisor " +
                           "VALUES(@teacherID, @activityID)";
            SqlParameter[] sqlParameters = new SqlParameter[2]
           {
                new SqlParameter("@activityID",activity),
                new SqlParameter("@teacherID",teaches.Number)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void DeleteActivity(int activity, Teacher teaches)
        {
            string query = "DELETE FROM ActivitySupervisor " +
                           "WHERE activityId = @activity AND teacherId = @teacherID";
            SqlParameter[] sqlParameters = new SqlParameter[2]
           {
                new SqlParameter("@activity",activity),
                new SqlParameter("@teacherID",teaches.Number)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher();

                teacher.FirstName = (string)dr["TeacherFirstName"];
                teacher.LastName = (string)dr["TeacherLastName"];
                teacher.Number = (int)dr["teacherId"];

                Activity activity = new Activity()
                {
                    Id = (int)dr["activityId"],
                    Name = (string)dr["activityName"],
                    Location = (string)dr["activityLocation"],
                    StartDate = (DateTime)dr["startDateTime"],
                    EndDate = (DateTime)dr["endDateTime"],

                    //teacher object to teacher
                    Teacher = teacher
                };
                activities.Add(activity);
            }
            return activities;
        }
    }
}
