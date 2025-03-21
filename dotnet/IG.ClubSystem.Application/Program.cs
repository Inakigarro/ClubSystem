using IG.ClubSystem.Contracts.Repositories;
using IG.ClubSystem.Contracts.Services;
using IG.ClubSystem.Persistence;
using IG.ClubSystem.Persistence.Repositories;
using IG.ClubSystem.Persistence.Services;
using Microsoft.EntityFrameworkCore;

namespace IG.ClubSystem.Application;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddDbContext<ApplicationDbContext>(opts =>
            opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                    assembly => assembly.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));
        
        builder.Services.AddLogging();
        // Repositories.
        builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
        builder.Services.AddScoped<IMembersRepository, MembersRepository>();

        // Services.
        builder.Services.AddScoped<IMembersService, MembersService>();

        builder.Services.AddControllers();
        builder.Services.AddOpenApi();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
