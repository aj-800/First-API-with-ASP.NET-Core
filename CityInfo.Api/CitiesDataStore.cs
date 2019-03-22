using CityInfo.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            Cities = new List<CityDto>
            {
                new CityDto
                {
                    Id = 1,
                    Name = "New York City",
                    Description = "The one with that big park"
                },

                new CityDto
                {
                    Id = 2,
                    Name = "Antwerp",
                    Description = "The one with the cthedral that was never really finished"
                },

                new CityDto
                {
                    Id = 3,
                    Name = "Paris",
                    Description = "That one with that big tower"
                }
            };
        }
    }
}
