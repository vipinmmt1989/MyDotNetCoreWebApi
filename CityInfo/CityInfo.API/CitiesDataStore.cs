using CityInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; }= new CitiesDataStore();
        public List<CityDto> Cities { get; set; }
        public CitiesDataStore()
        {
            //Dummy Data
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id=1,
                    Name="Delhi",
                    Description="Capital of India",
                    PointOfInterest=new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                             Id=1,
                             Name="Delhi1",
                             Description="Capital of India alfa"
                        },
                         new PointOfInterestDto()
                        {
                             Id=2,
                             Name="Delhi2",
                             Description="Capital of India beta"
                        }
                    }
                },
                 new CityDto()
                {
                    Id=2,
                    Name="Mumbai",
                    Description="Bollywood of India",
                    PointOfInterest=new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                             Id=3,
                             Name="Mumbai3",
                             Description="Bollywood of India alfa"
                        },
                         new PointOfInterestDto()
                        {
                             Id=4,
                             Name="Mumbai4",
                             Description="Bollywood of India beta"
                        }
                    }
                },
                 new CityDto()
                {
                    Id=3,
                    Name="Pune",
                    Description="IT City of India",
                    PointOfInterest=new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                             Id=5,
                             Name="Pune5",
                             Description="IT City of India alfa"
                        },
                         new PointOfInterestDto()
                        {
                             Id=6,
                             Name="Pune6",
                             Description="IT City of India beta"
                        }
                    }
                }

            };
        }
    }
}
