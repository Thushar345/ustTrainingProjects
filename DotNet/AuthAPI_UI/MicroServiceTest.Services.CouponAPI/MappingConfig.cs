using AutoMapper;
using MicroServiceTest.Services.CouponAPI.Models;
using MicroServiceTest.Services.CouponAPI.Models.DTO;

namespace MicroServiceTest.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDTO, Coupon>();
                config.CreateMap<Coupon, CouponDTO>();
            });
            return mappingConfig;
        }
    }
}
