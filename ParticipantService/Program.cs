using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using ParticipantService.ExceptionHandling;
using ParticipantService.Persistence;
using ParticipantService.Services;
using ParticipantService.Services.Contracts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ParticipantDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddAutoMapper(typeof(Program));

// Add services to the container.
builder.Services.AddScoped<IParticipantsService, ParticipantsService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

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
