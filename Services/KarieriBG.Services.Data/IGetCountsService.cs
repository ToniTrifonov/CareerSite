namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using KarieriBG.Services.Data.Models;

    public interface IGetCountsService
    {
        CountsDto GetCounts();
    }
}
