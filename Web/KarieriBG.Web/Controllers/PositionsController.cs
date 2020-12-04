namespace KarieriBG.Web.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    public class PositionsController : BaseController
    {
        public IActionResult All(int id)
        {
            if (id == 0)
            {
                return this.View();
            }

            return this.View();
        }

        // TOOD: Fix post method
        [HttpPost]
        public IActionResult Add(string name, string description)
        {
            return this.View();
        }

        public IActionResult Add()
        {
            return this.View();
        }

    }
}
