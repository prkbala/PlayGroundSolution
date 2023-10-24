using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Logging
    .ClearProviders()
    .AddSerilog(new LoggerConfiguration()
        .ReadFrom.Configuration(builder.Configuration)
        .Enrich.WithThreadId()
        .CreateLogger())
    .AddConsole();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.Services.GetRequiredService<ILogger<Program>>().LogInformation("Starting Web Api...");

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
