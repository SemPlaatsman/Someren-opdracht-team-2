using System;
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
    public class UserDao : BaseDao
    {
        public bool? ValidateUserPassword(User user)
        {
            string query = "SELECT [admin] FROM Users WHERE username = @username AND [password] = @password; ";
            SqlParameter[] sqlParameters = new SqlParameter[2]
            {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@password", user.Password)
            };
            if (true)
            {

            }
            return ReadUserValidation(ExecuteSelectQuery(query, sqlParameters));
        }

        public bool RegisterUser(User user)
        {
            string query = "INSERT INTO Users (username, [password], [admin]) VALUES (@username, @password, @admin);";
            SqlParameter[] sqlParameters = new SqlParameter[3]
            {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@password", user.Password),
                new SqlParameter("@admin", user.Admin)
            };
            return ExecuteEditQuery(query, sqlParameters);
        }

        private bool? ReadUserValidation(DataTable dataTable)
        {
            if (dataTable.Rows.Count == 0)
            {
                return null;
            }
            return Convert.ToBoolean(dataTable.Rows[0]["admin"]);
        }
        public bool UpdateUser(User user)
        {
            string query = "UPDATE User" +
                "SET pasword = @pasword" +
                "WHERE username= @username and secretAnswer = @answer and secretQuestion = @question";
            SqlParameter[] sqlParameters = new SqlParameter[4]
            {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@password", user.Password),
                new SqlParameter("@answer", user.Admin),
                new SqlParameter("@question", user.question)


            };
            return ExecuteEditQuery(query, sqlParameters);
        }

        public UserQuestion GetGetquestion(User user)
        {
          

            string query = "SELECT  Users.secretAnswer , Users.secretQuestion " +
                "FROM Users " +
                "WHERE username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[1]
           {
                new SqlParameter("@username", user.Username)

           };

           return ReadUserQuestion(ExecuteSelectQuery(query, sqlParameters));

        }

        public UserQuestion GetAnswer(User user)
        {


            string query = "SELECT Users.secretAnswer , Users.secretQuestion " +
                "FROM Users " +
                "WHERE username = @username AND secretAnswer = @secretAnswer " ;
            SqlParameter[] sqlParameters = new SqlParameter[2]
           {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@secretAnswer", user.question.answer)


           };

            return ReadUserQuestion(ExecuteSelectQuery(query, sqlParameters));

        }



        UserQuestion ReadUserQuestion(DataTable dt)
        {
            UserQuestion userQuestion;
            try
            {
                DataRow dr = dt.Rows[0];
                userQuestion = new UserQuestion((string)dr["secretQuestion"], (string)dr["secretAnswer"]);
            }
            catch
            {
                userQuestion = new UserQuestion(null,null);
            }
          
                return userQuestion;
            

        }

    }
}
