using OnePieceApi.Models; 

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();


app.MapGet("/characters", () =>
{
    return new[]
    {
        new Character
        {
            Id = 1,
            Name = "Monkey D. Luffy",
            Crew = "Straw Hat Pirates",
            Role = "Captain"
        },
        new Character
        {
            Id = 2,
            Name = "Roronoa Zoro",
            Crew = "Straw Hat Pirates",
            Role = "Swordsman"
        }
    };
});


app.MapGet("/characters/{id}", (int id) =>
{
    var characters = new []
    {
        new Character
        {
            Id = 1, 
            Name = "Monkey D. Luffy",
            Crew = "Straw Hat Pirates",
            Role = "Captain"
        },

        new Character
        {
            Id = 2, 
            Name = "Roronoa Zoro",
            Crew = "Straw Hat Pirates",
            Role = "Swordsman"
        }
    };

    var character = characters.FirstOrDefault(c=>c.Id == id);

    if (character == null)
    {
        return Results.NotFound();
    } 

    return Results.Ok(character);
});

app.Run();