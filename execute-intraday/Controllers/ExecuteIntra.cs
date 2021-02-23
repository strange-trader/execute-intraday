using execute_intraday.services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace execute_intraday.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExecuteIntra : ControllerBase
    {
        private IZerodhaService _zerodhaService;
        public ExecuteIntra(IZerodhaService zerodhaService)
        {
            _zerodhaService = zerodhaService;

        }
        // GET: api/<ExecuteIntra>
        [HttpGet]
        public string Get()
        {
            return _zerodhaService.zerodhatrying();
        }

        // GET api/<ExecuteIntra>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ExecuteIntra>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ExecuteIntra>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ExecuteIntra>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
