using AutoMapper;
using Vendors.Dto;
using Vendors.Models;

namespace Vendors.Profiles
{
    public class VendorProfile : Profile{
        public VendorProfile()         
        {
            // Source -> Target
            CreateMap<Vendor,VendorReadDto>();
            // Target -> Source
            CreateMap<VendorCreateDto, Vendor>();
            // Target -> Source update
            CreateMap<VendorUpdateDto, Vendor>();
        }
    }
}