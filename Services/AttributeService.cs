using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class attributeServices : IattributeService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public attributeServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(attribute newAttribute)
    {
        newAttribute.attribute_id = Guid.NewGuid();
        await context.AddAsync<attribute>(newAttribute);
        await context.SaveChangesAsync();
    }

    public IEnumerable<attribute> Get()
    {
        return context.attribute;
    }   

    public async Task Update(Guid id, attribute updattribute)
    {
        var Attribute = context.attribute.Find(id);
        if(Attribute != null)
        {
            Attribute.attribute_id = updattribute.attribute_id;
            context.Update(Attribute);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var Attribute = context.attribute.Find(id);
        if (Attribute != null)
        {
            context.Remove(Attribute);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IattributeService
{
    Task CreateAsync(attribute newAttribute);
    IEnumerable<attribute> Get();
    Task Update(Guid id, attribute updattribute);
    Task Delete(Guid id);
}
