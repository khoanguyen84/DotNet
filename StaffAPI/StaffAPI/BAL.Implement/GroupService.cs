using Microsoft.EntityFrameworkCore;
using StaffAPI.BAL.Interface;
using StaffAPI.Entities;
using StaffAPI.StaffContext;

namespace StaffAPI.BAL.Implement
{
    public class GroupService : IGroupService
    {
        private readonly StaffDbContext  staffDbContext;  
        public GroupService() 
        {
            staffDbContext = new StaffDbContext();
        }
        public async Task<Group> GetGroup(int groupId)
        {
            return await staffDbContext.Groups.FirstOrDefaultAsync(g => g.Id == groupId);
        }

        public async Task<List<Group>> GetGroups()
        {
            return await staffDbContext.Groups.ToListAsync();
        }
    }
}
