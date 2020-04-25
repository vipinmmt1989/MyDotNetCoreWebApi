using CityInfo.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
   [ApiController]
   [Route("api/cities/{cityid}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetPointsOfInterest(int cityid)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null)
            {
                return NotFound();
            }
            return Ok(city.PointOfInterest);
        }
        [HttpGet("{id}" ,Name = "GetPointOfInterest")]
        public IActionResult GetPointOfInterest(int cityid,int id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityid);
            if (city == null)
            {
                return NotFound();
            }

            var pointofinterest = city.PointOfInterest.FirstOrDefault(c => c.Id == id);
            if (pointofinterest == null)
            {
                return NotFound();
            }
            return Ok(pointofinterest);
        }
        [HttpPost]
       
        public ActionResult<PointOfInterestDto> CreatePointOfInterest(int cityid,[FromBody] PointOfInterestForCreatioDto pointOfInterest)
        {
            try
            {
                var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == cityid);
                if (city == null)
                {
                    return NotFound();
                }
                var maxPointOfInterestId = CitiesDataStore.Current.Cities.SelectMany(c => c.PointOfInterest).Max(p => p.Id);
                var finalPointOfInterest = new PointOfInterestDto()
                {
                    Id = ++maxPointOfInterestId,
                    Name = pointOfInterest.Name,
                    Description = pointOfInterest.Description
                };

                city.PointOfInterest.Add(finalPointOfInterest);
               
                 return    CreatedAtRoute("GetPointOfInterest",
                                            new {
                                                cityid,finalPointOfInterest.Id 
                                                },
                                            finalPointOfInterest);
            }
            catch(Exception e)
            {
                throw e;
            }

        }
    }

}
