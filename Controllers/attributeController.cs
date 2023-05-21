using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class attributeController: ControllerBase
{

    IattributeService attributeService;
    public attributeController(IattributeService serviceattribute){
        attributeService=serviceattribute;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postattribute([FromBody] attribute newAttribute)
        {
            await attributeService.CreateAsync(newAttribute);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(attributeService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] attribute updattribute)
        {
            await attributeService.Update(id, updattribute);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await attributeService.Delete(id);
            return Ok();
        }
    }
}