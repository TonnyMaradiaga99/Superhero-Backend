using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class hero_attributeServices : Ihero_attributeService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public hero_attributeServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(hero_attribute newheroAttribute)
    {
        newheroAttribute.hero_id = Guid.NewGuid();
        await context.AddAsync<hero_attribute>(newheroAttribute);
        await context.SaveChangesAsync();
    }

    public IEnumerable<hero_attribute> Get()
    {
        return context.hero_attribute;
    }   

    public async Task Update(Guid id, hero_attribute updheroAttribute)
    {
        var hero_Attribute = context.hero_attribute.Find(id);
        if(hero_Attribute != null)
        {
            hero_Attribute.hero_id = updheroAttribute.hero_id;
            context.Update(hero_Attribute);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var hero_Attribute = context.hero_attribute.Find(id);
        if (hero_Attribute != null)
        {
            context.Remove(hero_Attribute);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface Ihero_attributeService
{
    Task CreateAsync(hero_attribute newhero_attribute);
    IEnumerable<hero_attribute> Get();
    Task Update(Guid id, hero_attribute updheroAttribute);
    Task Delete(Guid id);
}
