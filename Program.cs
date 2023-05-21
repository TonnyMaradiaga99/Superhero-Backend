using Superhero;
using Superhero.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddSqlServer<SuperheroContext>("Data Source=localhost; Initial Catalog=SuperheroDB;user id=sa;password=C0ntrol1*;Encrypt=False");
builder.Services.AddScoped<IalignmentService, alignmentServices>();
builder.Services.AddScoped<IattributeService, attributeServices>();
builder.Services.AddScoped<IcolourService, colourServices>();
builder.Services.AddScoped<IgenderService, genderServices>();
builder.Services.AddScoped<IgenderService, genderServices>();
builder.Services.AddScoped<Ihero_attributeService, hero_attributeServices>();
builder.Services.AddScoped<Ihero_powerService, hero_powerServices>();
builder.Services.AddScoped<IpublisherService, publisherServices>();
builder.Services.AddScoped<IraceService, raceServices>();
builder.Services.AddScoped<Isuperhero1Service, superhero1Services>();
builder.Services.AddScoped<IsuperpowerService, superpowerServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
