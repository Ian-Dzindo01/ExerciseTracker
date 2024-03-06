using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using ExerciseTracker;

var builder = Host.CreateApplicationBuilder(args);

builder.Services
        .AddDbContext<ExerciseDbContext>(opt =>
        opt.UseSqlite("Data Source=exercise.db"))
        .AddScoped<IExerciseService, ExerciseService>()
        .AddScoped<IExerciseRepository, ExerciseRepository>()
        .AddTransient<ExerciseController>();

builder.Logging.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);

var app = builder.Build();

using var scope = app.Services.CreateScope();
var controller = scope.ServiceProvider.GetRequiredService<ExerciseController>();
var menu = new Menu(controller);
menu.Start();