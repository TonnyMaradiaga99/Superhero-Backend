using System;
using Superhero.Models;

namespace Superhero.Services
{
    public class alignmentServices: IalignmentService

    {
    //Inyectar de Independencia
        SuperheroContext context;
        public alignmentServices(SuperheroContext dbcontext)
        {
            context=dbcontext;
        }

    //CRUD
    public async Task CreateAsync(Alignment newAlignment)
    {
        newAlignment.aligment_id= Guid.NewGuid();
        await context.AddAsync<Alignment>(newAlignment);
        await context.SaveChangesAsync();
    }

    public IEnumerable<Alignment> Get()
    {
        return context.Alignment;
    }   

    public async Task Update(Guid id, Alignment updalignment)
    {
        var Alignment = context.Alignment.Find(id);
        if(Alignment != null)
        {
            Alignment.aligment_id = updalignment.aligment_id;
            context.Update(Alignment);
            await context.SaveChangesAsync();
        }
    }

    public async Task Delete(Guid id)
    {
        var Alignment = context.Alignment.Find(id);
        if (Alignment != null)
        {
            context.Remove(Alignment);
            await context.SaveChangesAsync();
        }
    }



    }
}

public interface IalignmentService
{
    Task CreateAsync(Alignment newAlignment);
    IEnumerable<Alignment> Get();
    Task Update(Guid id, Alignment updalignment);
    Task Delete(Guid id);
}

