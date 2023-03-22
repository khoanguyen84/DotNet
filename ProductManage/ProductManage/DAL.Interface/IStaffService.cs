using ProductManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManage.DAL.Interface
{
    public interface IStaffService
    {
        List<Staff> GetStaffs();
    }
}
