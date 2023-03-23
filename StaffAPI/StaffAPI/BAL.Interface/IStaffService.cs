using StaffAPI.Entities;

namespace StaffAPI.BAL.Interface
{
    public interface IStaffService
    {
        Task<List<Staff>> GetStaffs();
        Task<Staff> GetStaff(int staffId);
        Task<Staff> CreateStaff(Staff newStaff);
        Task<Staff> UpdateStaff(Staff newStaff);
        Task<Staff> DeleteStaff(int staffId);
    }
}
