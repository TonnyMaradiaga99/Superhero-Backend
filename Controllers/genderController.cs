using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class genderController: ControllerBase
{

    IgenderService genderService;
    public genderController(IgenderService servicegender){
        genderService=servicegender;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postgender([FromBody] gender newgender)
        {
            await genderService.CreateAsync(newgender);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(genderService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] gender updgender)
        {
            await genderService.Update(id, updgender);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await genderService.Delete(id);
            return Ok();
        }
    }
}