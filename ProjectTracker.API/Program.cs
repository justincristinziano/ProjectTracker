using Microsoft.EntityFrameworkCore;
using ProjectTracker.API.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Use SQLite database and save it to projectracker.dv
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=projecttracker.db"));

var app = builder.Build();

app.UseStaticFiles(); // Request to get static page? If so, stop here.
app.UseRouting(); // If not trying to get static page, use HTTP routing
app.UseAuthorization(); // Is the user able to make this request?
app.MapControllers(); // If yes, then bring em to the correct controller endpoint

app.Run();