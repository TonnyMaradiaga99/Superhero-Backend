using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class superpowerController: ControllerBase
{

    IsuperpowerService superpowerService;
    public superpowerController(IsuperpowerService servicesuperpower){
        superpowerService=servicesuperpower;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postsuperpower([FromBody] superpower newsuperpower)
        {
            await superpowerService.CreateAsync(newsuperpower);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(superpowerService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] superpower updsuperpower)
        {
            await superpowerService.Update(id, updsuperpower);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await superpowerService.Delete(id);
            return Ok();
        }
    }
}