using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.Dapper
{
    public class BaseRepository
    {
        public IDbConnection _connection;
        public BaseRepository()
        {
            string connection = @"Data Source=khoanguyen\sqlexpress;Initial Catalog=CGCafe;Integrated Security=True; Encrypt=True; TrustServerCertificate=True";
            _connection = new SqlConnection(connection);
        } 
    }
}
