using Microsoft.AspNetCore.Mvc;
using StaffAPI.BAL.Implement;
using StaffAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StaffAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private StaffService _staffService;
        public StaffController()
        {
            _staffService = new StaffService();
        }    
        // GET: api/<StaffController>
        [HttpGet]
        public async Task<IEnumerable<Staff>> Get()
        {
            return await _staffService.GetStaffs();
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public async Task<Staff> Get(int id)
        {
            return await _staffService.GetStaff(id);
        }

        // POST api/<StaffController>
        [HttpPost]
        public async Task<Staff> Post([FromBody] Staff staff)
        {
            return await _staffService.CreateStaff(staff);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public async Task<Staff> Delete(int id)
        {
            return await _staffService.DeleteStaff(id);
        }
    }
}
