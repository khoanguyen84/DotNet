using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace ShopingCart.DAL.Implement
{
    public class BaseRepository
    {
        public IDbConnection connection;
        public BaseRepository() 
        {
            string connectString = @"Data Source=khoanguyen\sqlexpress;Initial Catalog=ShoppingDb;Integrated Security=True; encrypt=true;trustServerCertificate=true";
            connection = new SqlConnection(connectString);
        }
    }
}
