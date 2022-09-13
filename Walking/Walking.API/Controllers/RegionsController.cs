using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Walking.API.DTOs;
using Walking.API.Models.Domain;
using Walking.API.Repositories;

namespace Walking.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            _regionRepository = regionRepository;
            _mapper = mapper;
        }
        [HttpGet]
     public IActionResult GetAllRegions()
        {
            var regions = _regionRepository.GetAll();
            //var regionsDTO = new List<DTOs.Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new DTOs.Region()
            //    {
            //        Id = region.Id,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population,
            //        Name = region.Name,
            //        Code = region.Code,
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
           var regionsDTO = _mapper.Map<List<DTOs.Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
