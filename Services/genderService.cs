using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class genderServices : IgenderService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public genderServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(gender newgender)
    {
        newgender.gender_id = Guid.NewGuid();
        await context.AddAsync<gender>(newgender);
        await context.SaveChangesAsync();
    }

    public IEnumerable<gender> Get()
    {
        return context.gender;
    }   

    public async Task Update(Guid id, gender updgender)
    {
        var gender = context.gender.Find(id);
        if(gender != null)
        {
            gender.gender_id = updgender.gender_id;
            context.Update(gender);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var gender = context.gender.Find(id);
        if (gender != null)
        {
            context.Remove(gender);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IgenderService
{
    Task CreateAsync(gender newgender);
    IEnumerable<gender> Get();
    Task Update(Guid id, gender updgender);
    Task Delete(Guid id);
}
