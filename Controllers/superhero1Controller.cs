using System.Net;
using Microsoft.AspNetCore.Mvc;
using Superhero.Models;
using Superhero.Services;

namespace Superhero.Controllers
{
//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class superhero1Controller: ControllerBase
{

    Isuperhero1Service superhero1Service;
    public superhero1Controller(Isuperhero1Service servicesuperhero1){
        superhero1Service=servicesuperhero1;
    }

    //CRUD API

        [HttpPost]
        public async Task<IActionResult> postrace([FromBody] superhero1 newsuperhero1)
        {
            await superhero1Service.CreateAsync(newsuperhero1);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(superhero1Service.Get());
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] superhero1 updsuperhero1)
        {
            await superhero1Service.Update(id, updsuperhero1);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await superhero1Service.Delete(id);
            return Ok();
        }
    }
}