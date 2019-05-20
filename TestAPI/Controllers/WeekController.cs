using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExpress.Xpo;
using LDS.Module.PublicEnums;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestAPI.BaseClass;
using TestAPI.Models.Week;

namespace TestAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [EnableCors("MyPolicy")]
    [ApiController]
    public class WeekController : ControllerBase
    {
        private readonly UnitOfWork uow;
        private IEnumerable<NPWeek> npWeeks;
        private List<DTOWeek> dtoWeeks;

        public WeekController()
        {
            this.uow = new UnitOfWork(DatabaseHelper.GetLDSDataLayer());
            this.npWeeks = this.uow.GetObjectsFromQuery<NPWeek>(Query.GetWeek());

        }

        // GET: api/Week
        [HttpGet]
        public ActionResult Get()
        {
            this.dtoWeeks = new List<DTOWeek>();
            foreach (NPWeek nPWeek in npWeeks)
            {
                DTOWeek dtoWeek = new DTOWeek()
                {
                    Oid = nPWeek.Oid,
                    Week = (Week)nPWeek.Weeks,
                    ActiveWeek = nPWeek.ActiveWeek,
                    Program = (LDS.Module.PublicEnums.Program)nPWeek.Program
                };
                this.dtoWeeks.Add(dtoWeek);
            }
            return this.Ok(this.dtoWeeks);
        }

        // GET: api/Week/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Week
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Week/5
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
