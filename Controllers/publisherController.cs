using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class publisherController: ControllerBase
{

    IpublisherService publisherService;
    public publisherController(IpublisherService servicepublisher){
        publisherService=servicepublisher;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postcolour([FromBody] publisher newpublisher)
        {
            await publisherService.CreateAsync(newpublisher);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(publisherService.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] publisher updpublisher)
        {
            await publisherService.Update(id, updpublisher);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await publisherService.Delete(id);
            return Ok();
        }
    }
}