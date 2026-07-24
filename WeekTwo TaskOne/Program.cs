using WeekTwo_TaskOne.MiddleWare;
using WeekTwo_TaskOne.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add OpenAPI and Swagger services
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddScoped<StudentService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // OpenAPI endpoint
    app.MapOpenApi();

    // Swagger middleware
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "WeekTwoTaskAPI v1");
        options.RoutePrefix = "swagger";
    });
}

app.UseHttpsRedirection();

app.UseMiddleware<CustomMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();