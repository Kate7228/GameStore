using GameStore.Api.Dtos;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Data Tranfer Object (DTO)
// A DTO is an object that carries data between processes or applications 
// It encapsulated data in a simple and standardised format that can be easily transmitted 
// across different applications.

// Defining a DTO to represent our games... solution explorer > Dtos

var games = new List<GameDto>
{
    new GameDto(
        1,
        "Street Fighter II",
        "Fighting",
        19.99M,
        new DateOnly(1992, 7, 15)),
    new GameDto(
        2,
        "Final Fantasy XIV",
        "Roleplaying",
        59.99M,
        new DateOnly(2010, 9, 30)),
    new GameDto(
        3,
        "FIFA 23",
        "Sports",
        69.99M,
        new DateOnly(2022, 9, 27))
};
//GET /games
app.MapGet("games", () => games);

//GET /games/1 (or any game with any id)... this request is variable.
// What game (id) it retrives depends on the id specified in the http request in games.http
app.MapGet("games/{id}", (int id) => games.Find(game => game.Id == id));

app.Run();


