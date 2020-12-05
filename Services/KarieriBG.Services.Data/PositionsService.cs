namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using KarieriBG.Data.Common.Repositories;
    using KarieriBG.Data.Models;
    using KarieriBG.Web.ViewModels.Position;

    public class PositionsService : IPositionsService
    {
        private readonly IDeletableEntityRepository<Position> positionsRepository;

        public PositionsService(IDeletableEntityRepository<Position> positionsRepository)
        {
            this.positionsRepository = positionsRepository;
        }

        public async Task AddAsync(AddPositionInputModel input)
        {
            var position = new Position
            {
                Name = input.Name,
                CompanyName = input.CompanyName,
                Requirements = input.Requirements,
                Description = input.Description,
                Offerings = input.Offerings,
                Responsibilities = input.Responsibilities,
                PositionCities = input.Cities,
                PositionTypes = input.Types,
                CategoryId = input.CategoryId,
                DegreeId = input.DegreeId,
                DepartmentId = input.DepartmentId,
            };

            await this.positionsRepository.AddAsync(position);
            await this.positionsRepository.SaveChangesAsync();
        }
    }
}
