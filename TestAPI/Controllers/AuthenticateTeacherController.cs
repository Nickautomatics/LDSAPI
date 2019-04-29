using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.BaseClass;
using TestAPI.Models.Teacher;

namespace TestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class AuthenticateTeacherController : ControllerBase
    {
        private readonly UnitOfWork uow;
        private IEnumerable<NPTeacher> npTeachers;
        private List<DTOTeacher> dtoTeachers;
        NPTeacher currentTeacher;

        public AuthenticateTeacherController()
        {
            this.uow = new UnitOfWork(DatabaseHelper.GetLDSDataLayer());
            this.npTeachers = this.uow.GetObjectsFromQuery<NPTeacher>(Query.GetTeacher());
        }

        // GET: api/AuthenticateTeacher
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/AuthenticateTeacher/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/AuthenticateTeacher
        [HttpPost]
        public IActionResult Post([FromBody] TeacherModel teacher)
        {
            Authenticator(teacher);
            if(currentTeacher!= null)
            {
                if(this.currentTeacher.Password == teacher.Password)
                {
                    return this.Ok(new { Message = "Successfully Logged In", Oid = this.currentTeacher.Oid, FirstName = this.currentTeacher.FirstName, LastName = this.currentTeacher.LastName });
                }
                else
                {
                    return this.BadRequest(new { Message = "Password does not match" });
                }
            }
            else
            {
                return this.BadRequest(new { Message = "User not found" });
            }
        }

        public void Authenticator(TeacherModel teacher)
        {
            currentTeacher = this.npTeachers.Where(t => t.UserName == teacher.Username).FirstOrDefault();
        }

        // PUT: api/AuthenticateTeacher/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
