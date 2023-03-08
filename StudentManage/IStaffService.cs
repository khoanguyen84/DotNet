using StudentManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    internal interface IStaffService
    {
        List<Staff> GetStaffs();
        Task<bool> CreateStaff(Staff staff);
        Task<bool> UpdateStaff(Staff staff);
        Task<bool> DeleteStaff(int staffId);
    }
}
