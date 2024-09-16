var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseDefaultFiles();
app.UseStaticFiles();

// TODO: decide between int and guid
app.MapGet("/playlist/{id}", (int id) =>
{
    switch (id)
    {
        case 1:
            {
                string playlistUrl = "https://open.spotify.com/playlist/4EWFFqW2vhLs47eJkTtyzR";
                return Results.Redirect(playlistUrl, true, true);
            }
        default:
            return Results.BadRequest();
    }
})
.WithName("GetPlaylist")
.WithOpenApi();

app.Run();
