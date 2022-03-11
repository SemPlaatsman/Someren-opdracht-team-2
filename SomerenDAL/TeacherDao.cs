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
    public class TeacherDao : BaseDao
    {      
        public List<Teacher> GetAllTeachers()
        { 
            string query = "SELECT teacherId, teacherFirstName, teacherLastName FROM Teachers";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> students = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher student = new Teacher()
                {
                    Number = (int)dr["teacherId"],
                    FirstName = (string)dr["teacherFirstName"],
                    LastName = (string)dr["teacherLastName"]


                };
                students.Add(student);
            }
            return students;
        }
    }
}
