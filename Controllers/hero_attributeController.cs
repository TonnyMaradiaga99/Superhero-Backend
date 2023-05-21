using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class hero_attributeController: ControllerBase
{

    Ihero_attributeService hero_attributeService;
    public hero_attributeController(Ihero_attributeService servicehero_attribute){
        hero_attributeService=servicehero_attribute;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> posthero_attribute([FromBody] hero_attribute newhero_attribute)
        {
            await hero_attributeService.CreateAsync(newhero_attribute);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(hero_attributeService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] hero_attribute updheroAttribute)
        {
            await hero_attributeService.Update(id, updheroAttribute);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await hero_attributeService.Delete(id);
            return Ok();
        }
    }
}