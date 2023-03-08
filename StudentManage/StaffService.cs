using Microsoft.EntityFrameworkCore;
using StudentManage.AppDbContext;
using StudentManage.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManage
{
    internal class StaffService : IStaffService
    {
        private StudentDbContext context;
        public StaffService()
        {
            context = new StudentDbContext();
        }

        public List<Staff> GetStaffs()
        {
            try
            {
                var result =   context.Staffs.ToList();
                return result;
            }
            catch(Exception ex)
            {
                var message = ex.Message;
                return new List<Staff>();
            }
        }
        public async Task<bool> CreateStaff(Staff staff)
        {
            context.Add(staff);
            return  await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateStaff(Staff staff)
        {
            Staff currentStaff = await context.Staffs.FirstOrDefaultAsync(s => s.StaffId == staff.StaffId) ?? new Staff();
            currentStaff.DateOfBirth = staff.DateOfBirth;
            currentStaff.Fullname = staff.Fullname;
            return await context.SaveChangesAsync() > 0;
        }

        public async Task<bool> DeleteStaff(int staffId)
        {
            Staff delStaff = await context.Staffs.FirstOrDefaultAsync(s => s.StaffId == staffId) ?? new Staff();
            if(delStaff != null)
            {
                context.Staffs.Remove(delStaff);
                return await context.SaveChangesAsync() > 0;
            }
            return false;
        }
    }
}
