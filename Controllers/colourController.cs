using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class colourController: ControllerBase
{

    IcolourService colourService;
    public colourController(IcolourService servicecolour){
        colourService=servicecolour;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postalcolour([FromBody] colour newcolour)
        {
            await colourService.CreateAsync(newcolour);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(colourService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] colour updcolour)
        {
            await colourService.Update(id, updcolour);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await colourService.Delete(id);
            return Ok();
        }
    }
}