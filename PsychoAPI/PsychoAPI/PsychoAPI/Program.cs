var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseRouting();

app.MapGet("/", () => Results.Redirect("/swagger"));

app.MapControllers();

app.Run();