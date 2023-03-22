using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Domain
{
    public class Report
    {
        public int BillId { get; set; }
        public int TotalQuantity { get; set; }
        public int TotalAmount { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
