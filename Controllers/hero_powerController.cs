using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class hero_powerController: ControllerBase
{

    Ihero_powerService hero_powerService;
    public hero_powerController(Ihero_powerService servicehero_power){
        hero_powerService=servicehero_power;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> posthero_power([FromBody] hero_power newheropower)
        {
            await hero_powerService.CreateAsync(newheropower);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(hero_powerService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] hero_power updheropower)
        {
            await hero_powerService.Update(id, updheropower);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await hero_powerService.Delete(id);
            return Ok();
        }
    }
}