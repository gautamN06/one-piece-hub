var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.MapGet("/characters", () =>
{
    return new[]
    {
        new
        {
            Name = "Monkey D. Luffy",
            Crew = "Straw Hat Pirates",
            Role = "Captain"
        },
        new
        {
            Name = "Roronoa Zoro",
            Crew = "Straw Hat Pirates",
            Role = "Swordsman"
        }
    };
});
app.Run();