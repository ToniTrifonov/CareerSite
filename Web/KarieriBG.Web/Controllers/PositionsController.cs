namespace KarieriBG.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using KarieriBG.Data;
    using KarieriBG.Data.Models;
    using KarieriBG.Services.Data;
    using KarieriBG.Web.ViewModels.Position;
    using Microsoft.AspNetCore.Mvc;

    public class PositionsController : BaseController
    {
        private readonly IPositionsService positionsService;

        public PositionsController(
            IPositionsService positionsService)
        {
            this.positionsService = positionsService;
        }

        public IActionResult Edit(string id)
        {
            var position = this.positionsService.GetById<EditPositionViewModel>(id);

            if (position == null)
            {
                return this.NotFound();
            }

            return this.View(position);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, EditPositionViewModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.positionsService.EditAsync(id, input);

            return this.Redirect($"/Positions/ById/{id}");
        }

        public IActionResult All(int id = 1)
        {
            if (id <= 0)
            {
                return this.NotFound();
            }

            var viewModel = this.positionsService.GetAll();

            return this.View(viewModel);
        }

        public IActionResult ById(string id)
        {
            var viewModel = this.positionsService.GetById<PositionViewModel>(id);

            return this.View(viewModel);
        }

        // TOOD: Fix post method
        [HttpPost]
        public async Task<IActionResult> Add(AddPositionInputModel input)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            await this.positionsService.AddAsync(input);

            return this.Redirect("/");
        }

        public IActionResult Add()
        {
            return this.View();
        }
    }
}
