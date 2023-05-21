using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class raceController: ControllerBase
{

    IraceService raceService;
    public raceController(IraceService servicerace){
        raceService=servicerace;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postrace([FromBody] race newrace)
        {
            await raceService.CreateAsync(newrace);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(raceService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] race updrace)
        {
            await raceService.Update(id, updrace);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await raceService.Delete(id);
            return Ok();
        }
    }
}