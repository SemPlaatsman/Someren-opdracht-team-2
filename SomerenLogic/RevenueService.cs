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
    public class RevenueService
    {
        RevenueDao revenuedb;

        public RevenueService()
        {
            revenuedb = new RevenueDao();
        }

        public RevenueReport GetReport()
        {
            return revenuedb.GetRevenueReport();
        }

    }
}
