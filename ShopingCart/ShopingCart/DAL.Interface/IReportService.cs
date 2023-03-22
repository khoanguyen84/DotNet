using ShopingCart.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.DAL.Interface
{
    public interface IReportService
    {
        List<Report> GetReports(int totalAmountMin, int totalAmountMax);
    }
}
