using Microsoft.AspNetCore.Mvc;
using StaffAPI.BAL.Implement;
using StaffAPI.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StaffAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private GroupService groupService;
        public GroupController()
        {
            groupService = new GroupService();
        }
        // GET: api/<GroupController>
        [HttpGet]
        public async Task<IEnumerable<Group>> Get()
        {
            return await groupService.GetGroups();
        }

        // GET api/<GroupController>/5
        [HttpGet("{id}")]
        public async Task<Group> Get(int id)
        {
            return await groupService.GetGroup(id);
        }

        // POST api/<GroupController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GroupController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GroupController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
