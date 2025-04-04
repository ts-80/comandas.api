using Comandas.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Comandas.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CardapioItemController : ControllerBase
    {
        // GET: api/<CardapioItemController>
        [HttpGet]
        public IEnumerable<CardapioItemResponse> Get()
        {
            return new List<CardapioItemResponse>() {
                new CardapioItemResponse() {
                    Id = 1,
                    Titulo = "Hamburguer",
                    Descricao = "Lanche",
                    PossuiPreparo = true,
                    Preco= 25.25M
                }
            };
        }

        // GET api/<CardapioItemController>/5
        [HttpGet("{id}")]
        public CardapioItemResponse Get(int id)
        {
            return new CardapioItemResponse()
            {
                Id = 1,
                Titulo = "Hamburguer",
                Descricao = "Lanche",
                PossuiPreparo = true,
                Preco = 25.25M
            };
        }

        // POST api/<CardapioItemController>
        [HttpPost]
        public ActionResult Post([FromBody] CardapioItemCreateRequest cardapioItemCreate)
        {
            return CreatedAtAction("Get", new {Id= 1}, new CardapioItemResponse()
            {
                Id = 1,
                Titulo = "Hamburguer",
                Descricao = "Lanche",
                PossuiPreparo = true,
                Preco = 25.25M
            });
        }

        // PUT api/<CardapioItemController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]CardapioItemUpdateRequest cardapioItemUpdate)
        {
            return NoContent();
        }

        // DELETE api/<CardapioItemController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
