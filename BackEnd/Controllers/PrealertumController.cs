using BackEnd.Services.Interfaces;
using Entities.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrealertumController : ControllerBase
    {
        IPrealertumService _prealertumService;
        public PrealertumController(IPrealertumService prealertumService)
        {
            _prealertumService = prealertumService;
        }

            // GET: api/<PrealertumController>
            [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PrealertumController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PrealertumController>
        [HttpPost]
        public void Post([FromBody]Prealertum prealertum)
        {
            _prealertumService.AddPrealertum(prealertum);
        }

        // PUT api/<PrealertumController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<PrealertumController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
