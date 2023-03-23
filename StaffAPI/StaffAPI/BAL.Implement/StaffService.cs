using Microsoft.EntityFrameworkCore;
using StaffAPI.BAL.Interface;
using StaffAPI.Entities;
using StaffAPI.StaffContext;

namespace StaffAPI.BAL.Implement
{
    public class StaffService : IStaffService
    {
        private StaffDbContext _dbContext;
        public StaffService() 
        {
            _dbContext = new StaffDbContext();
        }
        public async Task<Staff> CreateStaff(Staff newStaff)
        {
            try
            {
                _dbContext.Staffs.Add(newStaff);
                _dbContext.Entry(newStaff.Group).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
                return newStaff;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<Staff> DeleteStaff(int staffId)
        {
            Staff delStaff = await GetStaff(staffId);
             _dbContext.Staffs.Remove(delStaff);
            await _dbContext.SaveChangesAsync();
            return delStaff;
        }

        public async Task<Staff> GetStaff(int staffId)
        {
            return await _dbContext.Staffs.Include(s => s.Group).FirstOrDefaultAsync(s => s.Id == staffId);
        }

        public async Task<List<Staff>> GetStaffs()
        {
            return await _dbContext.Staffs.Include(s => s.Group).ToListAsync();
        }

        public Task<Staff> UpdateStaff(Staff newStaff)
        {
            throw new NotImplementedException();
        }
    }
}
