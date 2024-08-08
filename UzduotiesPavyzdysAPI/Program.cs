using UzduotiesPavyzdysAPI.Contracts;
using UzduotiesPavyzdysAPI.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IBookService, BookService>();
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


//Sukurti naują ASP.NET Core Web API projektą.
//Sukurti modelį, skirtą knygai aprašyti (angl. Book) su šiais laukais:
//Id(int)
//Title(string)
//Author(string)
//Year(int)
//Sukurti kontrolerį BooksController su šiais veiksmais (angl. actions):
//GET / api / books - Grąžina visų knygų sąrašą.
//GET /api/books/{id} -Grąžina vieną knygą pagal ID.
//POST /api/books - Prideda naują knygą.
//PUT /api/books/{id} -Atnaujina egzistuojančią knygą pagal ID.
//DELETE /api/books/{id} -Ištrina knygą pagal ID.
//Naudoti atmintyje (angl. in-memory) saugomą sąrašą knygų duomenų saugojimui.