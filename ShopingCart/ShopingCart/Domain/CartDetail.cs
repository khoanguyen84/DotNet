using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ShopingCart.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCart.Domain
{
    public class CartDetail
    {
        public int Price { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public int Amount => Price * Quantity;
        public int ProductId { get; set; }
    }
}
