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
                "WHERE secretAnswer = @answer and secretQuestion = @question";
            SqlParameter[] sqlParameters = new SqlParameter[3]
            {
                new SqlParameter("@username", user.Username),
                new SqlParameter("@password", user.Password),
                new SqlParameter("@admin", user.Admin)
            };
            return ExecuteEditQuery(query, sqlParameters);
        }
        public void GetGetquestion(User user)
        {
            string query = "SELECT Users.secretAnswer , Users.secretQuestion" +
                "FROM Users" +
                "WHERE username = @username";
            SqlParameter[] sqlParameters = new SqlParameter[1]
           {
                new SqlParameter("@username", user.Username)

           };

            ExecuteSelectQuery(query, sqlParameters);

        }
    }
}
