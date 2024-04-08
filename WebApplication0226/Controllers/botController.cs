using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication0226.Models;

namespace WebApplication0226.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class botController : ControllerBase
    {
        // GET: api/bot
        [HttpGet]
        public IEnumerable<botM> Get()
        {
            return new botM[]
            {
                new botM(){ID = 1,type = "魔神",hp = 4200,atk = 60,def = 10,spd = 1.1f}
            };
        }

        // GET: api/bot/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/bot
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/bot/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/bot/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
