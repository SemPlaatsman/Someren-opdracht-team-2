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
    public class RevenueDao : BaseDao
    {
        public RevenueReport GetRevenueReport()
        {
            string query = "SELECT SUM(nrOfSales) AS [Sales], SUM(nrOfSales * salesPrice) AS [Turnover], (SELECT COUNT(DISTINCT ForeignStudent) FROM Orders) AS [Number of customers] FROM Drinks";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private RevenueReport ReadTables(DataTable dataTable)
        {
            RevenueReport revenueReport = new RevenueReport()
            {
                Sales = int.Parse(dataTable.Rows[0]["Sales"].ToString()),
                Turnover = int.Parse(dataTable.Rows[0]["Turnover"].ToString()),
                NumberOfCustomers = int.Parse(dataTable.Rows[0]["Number of customers"].ToString())
            };
            return revenueReport;
        }
    }
}
