﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Controllers
{
    [Route(("api/Cities"))]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current.Cities);
        }
        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
           var city= CitiesDataStore.Current.Cities.FirstOrDefault(c=>c.Id==id);
            if(city==null)
            {
                return NotFound();
            }
            return Ok(city);
        }
    }
}
