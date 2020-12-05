namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KarieriBG.Data.Common.Repositories;
    using KarieriBG.Data.Models;
    using KarieriBG.Web.ViewModels.Position;

    public class PositionsService : IPositionsService
    {
        private readonly IDeletableEntityRepository<Position> positionsRepository;
        private readonly IRepository<Department> departmentsRepository;
        private readonly IRepository<Degree> degreesRepository;
        private readonly IRepository<Category> categoriesRepository;

        public PositionsService(
            IDeletableEntityRepository<Position> positionsRepository,
            IRepository<Department> departmentsRepository,
            IRepository<Degree> degreesRepository,
            IRepository<Category> categoriesRepository)
        {
            this.positionsRepository = positionsRepository;
            this.departmentsRepository = departmentsRepository;
            this.degreesRepository = degreesRepository;
            this.categoriesRepository = categoriesRepository;
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

            var degree = new Degree() { Name = "Masters" };
            var department = new Department() { Name = "IT" };
            var category = new Category() { Name = "IT" };

            await this.degreesRepository.AddAsync(degree);
            await this.categoriesRepository.AddAsync(category);
            await this.departmentsRepository.AddAsync(department);

            await this.positionsRepository.AddAsync(position);
            await this.positionsRepository.SaveChangesAsync();
        }

        public PositionViewModel GetById(string id)
        {
            var position = this.positionsRepository.All().First(x => x.Id == id);

            var positionViewModel = new PositionViewModel()
            {
                PositionName = position.Name,
                CompanyName = position.CompanyName,
                AddedOn = position.CreatedOn,
                Types = position.PositionTypes,
            };

            return positionViewModel;
        }
    }
}
