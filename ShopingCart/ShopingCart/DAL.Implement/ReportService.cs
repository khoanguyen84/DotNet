using Dapper;
using ShopingCart.DAL.Interface;
using ShopingCart.Domain;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Implement
{
    public class ReportService : BaseRepository, IReportService
    {
        public List<Report> GetReports(int totalAmountMin = 0, int totalAmountMax = 0)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@min", totalAmountMin);
            parameters.Add("@max", totalAmountMax);
            return SqlMapper.Query<Report>(cnn: connection, 
                                        sql: "sp_Report", 
                                        param: parameters,
                                        commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
