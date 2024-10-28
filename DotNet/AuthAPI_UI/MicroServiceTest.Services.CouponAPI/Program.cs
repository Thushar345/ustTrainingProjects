
using AutoMapper;
using MicroServiceTest.Services.CouponAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceTest.Services.CouponAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var builder = WebApplication.CreateBuilder(args);

            IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();

            builder.Services.AddSingleton(mapper);

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            builder.Services.AddDbContext<AppDbContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
            ApplyMigration(app);

            app.Run();
        }
        static void ApplyMigration(WebApplication? app)
        {
            using (var scope = app.Services.CreateScope())
            {
                var _db =scope.ServiceProvider.GetRequiredService<AppDbContext>();
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }

        }
    }
}
