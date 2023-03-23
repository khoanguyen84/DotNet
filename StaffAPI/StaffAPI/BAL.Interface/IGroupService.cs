using StaffAPI.Entities;

namespace StaffAPI.BAL.Interface
{
    public interface IGroupService
    {
        Task<List<Group>> GetGroups();
        Task<Group> GetGroup(int groupId);
    }
}
