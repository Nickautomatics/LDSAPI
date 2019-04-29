using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TestAPI.BaseClass;
using TestAPI.Models.User;

namespace TestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly UnitOfWork uow;
        private IEnumerable<NPUser> npUsers;
        private List<DTOUser> dtoUsers;

        public UsersController()
        {
            this.uow = new UnitOfWork(DatabaseHelper.GetLDSDataLayer());
            this.npUsers = this.uow.GetObjectsFromQuery<NPUser>(Query.GetStudents());
        }

        // GET api/values
        [HttpGet]
        public ActionResult Get()
        {
            this.dtoUsers = new List<DTOUser>();
            foreach (NPUser nPUser in this.npUsers)
            {
                DTOUser dtoUser = new DTOUser()
                {
                    Oid = nPUser.Oid,
                    Program = nPUser.Program,
                    Batch = nPUser.Batch,
                    IDNumber = nPUser.IDNumber,
                    Year = nPUser.Year,
                    Network = nPUser.Year,
                    Teacher = nPUser.Teacher
                };
                this.dtoUsers.Add(dtoUser);
            }
            return this.Ok(this.dtoUsers);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
