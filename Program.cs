using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

using ExerciseTracker;

// Create builder for the app
var builder = Host.CreateApplicationBuilder(args);

// Register DbContext, use Sqlite
// Register scoped and transient services
// Scoped - same lifetime as scope of request or operation
// Transient - service created each time it is requested
builder.Services
        .AddDbContext<ExerciseDbContext>(opt =>
        opt.UseSqlite("Data Source=exercise.db"))
        .AddScoped<IExerciseService, ExerciseService>()
        .AddScoped<IExerciseRepository, ExerciseRepository>()
        .AddTransient<ExerciseController>();

// Filter to show only log messages related to EF 
builder.Logging.AddFilter("Microsoft.EntityFrameworkCore", LogLevel.Warning);

// Instance of IHost - manage app lifetime, service and configuration
var app = builder.Build();

// Create scope for DI
using var scope = app.Services.CreateScope();
// Obtain service from DI container
var controller = scope.ServiceProvider.GetRequiredService<ExerciseController>();
var menu = new Menu(controller);
menu.Start();