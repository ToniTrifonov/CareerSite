namespace KarieriBG.Web.Controllers
{
    using System.Diagnostics;

    using KarieriBG.Services.Data;
    using KarieriBG.Web.ViewModels;
    using KarieriBG.Web.ViewModels.Home;
    using Microsoft.AspNetCore.Mvc;

    public class HomeController : BaseController
    {
        private readonly IGetCountsService getCountsService;

        public HomeController(IGetCountsService getCountsService)
        {
            this.getCountsService = getCountsService;
        }

        public IActionResult Index()
        {
            var data = this.getCountsService.GetCounts();

            var viewModel = new IndexViewModel()
            {
                CitiesCount = data.CitiesCount,
                PositionsCount = data.PositionsCount,
            };

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
