using MicroServiceTest.Services.CouponAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServiceTest.Services.CouponAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) { }
        public DbSet<Coupon> Coupons { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Coupon>().HasData
                (new Coupon()
                {
                    CouponId = 1,
                    CouponCode = "2801A",
                    DiscountAmount = 100,
                    MinAmount = 1000
                }, new Coupon()
                {
                    CouponId = 2,
                    CouponCode = "Test",
                    DiscountAmount = 20,
                    MinAmount = 2000
                });
        }

    }


    
}
