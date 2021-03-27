using System.Collections.Generic;
using AutoMapper;
using Vendors.Data;
using Vendors.Dto;
using Vendors.Models;
using Microsoft.AspNetCore.Mvc;

namespace Vendors.Controllers
{
    [Route("api/Vendors")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorRepo _repository;
        private readonly IMapper _mapper;

        public VendorController(IVendorRepo repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //private readonly MockVendorerRepo _repository = new MockVendorerRepo();
        //GET api/Vendors
        [HttpGet]
        public ActionResult<IEnumerable<VendorReadDto>> GetAllVendors()
        {
            var VendorItems = _repository.GetAllVendors();

            return Ok(_mapper.Map<IEnumerable<VendorReadDto>>(VendorItems));
        }
        //GET api/Vendors/{id}
        [HttpGet("{id}", Name = "GetVendorById")]
        public ActionResult<VendorReadDto> GetVendorById(int id)
        {
            var VendorItem = _repository.GetVendorById(id);
            if (VendorItem != null)
            {
                return Ok(_mapper.Map<VendorReadDto>(VendorItem));
            }
            return NotFound();
        }
        //POST api/Vendors
        [HttpPost]
        public ActionResult<VendorCreateDto> CreateVendor(VendorCreateDto VendorCreateDto)
        {
            var VendorModel = _mapper.Map<Vendor>(VendorCreateDto);
            _repository.CreateVendor(VendorModel);
            _repository.SaveChanges();

            var VendorReadDto = _mapper.Map<VendorReadDto>(VendorModel);

            return CreatedAtRoute(nameof(GetVendorById), new { Id = VendorReadDto.Id }, VendorReadDto);
            //return Ok(VendorReadDto);
        }
        //PUT api/Vendors/{id}
        [HttpPut]
        public ActionResult UpdateVendor(int id, VendorUpdateDto VendorUpdateDto)
        {
            var VendorModelFromRepo = _repository.GetVendorById(id);
            if (VendorModelFromRepo == null)
            {
                return NotFound();
            }

            _mapper.Map(VendorUpdateDto, VendorModelFromRepo);
            _repository.UpdateVendor(VendorModelFromRepo);
            _repository.SaveChanges();

            return NoContent();
        }
    }
}