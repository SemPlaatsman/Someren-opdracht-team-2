using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Activity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public Teacher Teacher { get; set; }

        public Student Student { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}
