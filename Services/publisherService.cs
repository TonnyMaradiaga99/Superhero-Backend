using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class publisherServices : IpublisherService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public publisherServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(publisher newpublisher)
    {
        newpublisher.publisher_id = Guid.NewGuid();
        await context.AddAsync<publisher>(newpublisher);
        await context.SaveChangesAsync();
    }

    public IEnumerable<publisher> Get()
    {
        return context.publisher;
    }   

    public async Task Update(Guid id, publisher updpublisher)
    {
        var publisher = context.publisher.Find(id);
        if(publisher != null)
        {
            publisher.publisher_id = updpublisher.publisher_id;
            context.Update(publisher);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
        {
        var publisher = context.publisher.Find(id);
        if (publisher != null)
        {
            context.Remove(publisher);
            await context.SaveChangesAsync();
        }
        }
    }
}

public interface IpublisherService
{
    Task CreateAsync(publisher newpublisher);
    IEnumerable<publisher> Get();
    Task Update(Guid id, publisher updpublisher);
    Task Delete(Guid id);
}