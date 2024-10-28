
using Microsoft.EntityFrameworkCore;
using OurHeroWebAPI.Entity;
using OurHeroWebAPI.Services;

namespace OurHeroWebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddTransient<IOurHeroService, OurHeroService>();

            builder.Services.AddDbContext<OurHeroDbContext>(db => db.UseSqlServer(builder.Configuration.GetConnectionString("OurHeroConnectionString")), ServiceLifetime.Singleton);


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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
        }
    }
}
