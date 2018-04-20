using System.Linq;
using BL.Link.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Services.Connectors.Link.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly DBTestContext _context;

        public ValuesController(DBTestContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public string Get()
        {
            var thing = _context.Users;

            string toReturn = JsonConvert.SerializeObject(thing);
            return toReturn;
        }

        // GET api/values/5
        [HttpGet("{term}")]
        public string Get(string term)
        {
            var rows = _context.Users.Where(a => a.Name.ToLower().Contains(term.ToLower()));
            return JsonConvert.SerializeObject(rows);
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