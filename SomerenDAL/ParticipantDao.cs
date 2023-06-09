﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class ParticipantDao : BaseDao
    {
        public List<Participant> GetAllParticipants()
        { // previous query: SELECT activityId, studentID FROM ActivityStudent
            string query = "SELECT activityId, studentId FROM ActivityStudent;";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        public void Add(Participant participant)
        {
            string query = "INSERT INTO ActivityStudent (activityId, studentId) VALUES (@activityId, @studentId)";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@activityId", participant.ActivityId),
                new SqlParameter("@studentId", participant.StudentId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        public void Delete(Participant participant)
        {
            string query = "DELETE FROM ActivityStudent WHERE activityId=@activityId AND studentId=@studentId";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@activityId", participant.ActivityId),
                new SqlParameter("@studentId", participant.StudentId)
            };
            ExecuteEditQuery(query, sqlParameters);
        }

        private List<Participant> ReadTables(DataTable dataTable)
        {
            List<Participant> participantsList = new List<Participant>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Participant participant = new Participant()
                { // must add data from students and activities
                    ActivityId = (int)dr["activityId"],
                    StudentId = (int)dr["studentId"]
                };
                participantsList.Add(participant);
            }
            return participantsList;
        }
    }
}