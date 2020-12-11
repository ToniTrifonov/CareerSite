namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using KarieriBG.Data.Common.Repositories;
    using KarieriBG.Data.Models;
    using KarieriBG.Services.Mapping;
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

        public async Task EditAsync(string id, EditPositionViewModel input)
        {
            var position = this.positionsRepository
                .All()
                .FirstOrDefault(x => x.Id == id);

            position.Name = input.Name;
            position.CompanyName = input.CompanyName;
            position.Requirements = input.Requirements;
            position.Description = input.Description;
            position.Offerings = input.Offerings;
            position.Responsibilities = input.Responsibilities;
            position.PositionCities = input.Cities;
            position.PositionTypes = input.Types;
            position.CategoryId = input.CategoryId;
            position.DegreeId = input.DegreeId;
            position.DepartmentId = input.DepartmentId;

            await this.positionsRepository.SaveChangesAsync();
        }

        public AllPositionsViewModel GetAll()
        {
            var positions = this.positionsRepository
                .All()
                .Select(x => new PositionViewModel()
                {
                    CompanyName = x.CompanyName,
                    PositionName = x.Name,
                    AddedOn = x.CreatedOn,
                    Types = x.PositionTypes,
                })
                .ToList();

            var allPositionsViewModel = new AllPositionsViewModel()
            {
                Positions = positions,
            };

            return allPositionsViewModel;
        }

        public T GetById<T>(string id)
        {
            var position = this.positionsRepository
                .AllAsNoTracking()
                .Where(x => x.Id == id)
                .To<T>().FirstOrDefault();

            return position;
        }
    }
}
