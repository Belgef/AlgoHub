using AlgoHub.API.Profiles;
using AlgoHub.API.ServiceExtensions;
using AlgoHub.BLL.Services.Implementations;
using AlgoHub.BLL.Services.Interfaces;
using AlgoHub.DAL.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAlgoHubDbContext(builder.Configuration);

builder.Services.AddAutoMapper(typeof(AlgoHubProfile));

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<ILessonService, LessonService>();



var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
