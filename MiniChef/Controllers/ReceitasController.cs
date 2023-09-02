using Microsoft.AspNetCore.Mvc;
using MiniChef.Domain.IService;
using System;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MiniChef.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceitasController : ControllerBase
    {
        private IReceitasService _service;
        public ReceitasController(IReceitasService service)
        {
            _service = service;
        }

        // GET: api/<ReceitasController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/<ReceitasController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ReceitasController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReceitasController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
