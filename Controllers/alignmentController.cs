using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class alignmentController: ControllerBase
{

    IalignmentService alignmentService;
    public alignmentController(IalignmentService servicealignment){
        alignmentService=servicealignment;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postalignment([FromBody] Alignment newalignment)
        {
            await alignmentService.CreateAsync(newalignment);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(alignmentService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Alignment updalignment)
        {
            await alignmentService.Update(id, updalignment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await alignmentService.Delete(id);
            return Ok();
        }
    }
}