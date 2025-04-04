using Comandas.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comandas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MesaController : ControllerBase
    {
        // GET: api/<MesaController>
        [HttpGet]
        public IEnumerable<MesaResponse> Get()
        {
            
            return new List<MesaResponse> { 
                new MesaResponse
                {
                    Id = 1,
                    NumeroMesa = 1,
                    SituacaoMesa = 0,
                }
            
            };
        }

        // GET api/<MesaController>/5
        [HttpGet("{id}")]
        public MesaResponse Get(int id)
        {
            return new MesaResponse
            {
                Id = 1,
                NumeroMesa = 1,
                SituacaoMesa = 0,
            };
        }

        // POST api/<MesaController>
        [HttpPost]
        public IActionResult Post([FromBody]MesaCreateRequest mesaCreateRequest)
        {
            return CreatedAtAction("Get",new {Id=1}, new MesaResponse()
            {
                Id = 1,
                NumeroMesa =1,
                SituacaoMesa = 0
            });
        }

        // PUT api/<MesaController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody]MesaUpdateRequest mesaUpdateRequest)
        {
            return NoContent();
        }

        // DELETE api/<MesaController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
