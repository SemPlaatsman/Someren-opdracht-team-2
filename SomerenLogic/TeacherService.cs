using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class TeacherService
    {
        TeacherDao Teacherdb;

        public TeacherService()
        {
            Teacherdb = new TeacherDao();
        }

        public List<Teacher> GetStudents()
        {
            List<Teacher> students = Teacherdb.GetAllTeachers();
            return students;
        }
    }
}
