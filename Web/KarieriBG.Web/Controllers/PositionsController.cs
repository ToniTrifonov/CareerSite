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

        public IActionResult All(string id)
        {
            var viewModel = this.positionsService.GetById(id);

            return this.Json(viewModel);
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
