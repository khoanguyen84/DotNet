using Dapper;
using ProductManage.DAL.Interface;
using ProductManage.Dapper;
using ProductManage.Entities;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.DAL.Implement
{
    public class StaffService : BaseRepository, IStaffService
    {
        public StaffService() { }
        public List<Staff> GetStaffs()
        {
            return SqlMapper.Query<Staff>(_connection, sql: "sp_GetStaffs", commandType: CommandType.StoredProcedure).ToList();
        }
    }
}
