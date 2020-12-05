namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using KarieriBG.Data.Common.Repositories;
    using KarieriBG.Data.Models;
    using KarieriBG.Services.Data.Models;

    public class GetCountsService : IGetCountsService
    {
        private readonly IRepository<City> citiesRepository;
        private readonly IDeletableEntityRepository<Position> positionsRepository;

        public GetCountsService(
            IRepository<City> citiesRepository,
            IDeletableEntityRepository<Position> positionsRepository)
        {
            this.citiesRepository = citiesRepository;
            this.positionsRepository = positionsRepository;
        }

        public CountsDto GetCounts()
        {
            var countsDto = new CountsDto()
            {
                CitiesCount = this.citiesRepository.All().Count(),
                PositionsCount = this.positionsRepository.All().Count(),
            };

            return countsDto;
        }
    }
}
