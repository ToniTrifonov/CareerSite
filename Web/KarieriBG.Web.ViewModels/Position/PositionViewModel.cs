namespace KarieriBG.Web.ViewModels.Position
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using KarieriBG.Data.Models;
    using KarieriBG.Services.Mapping;

    public class PositionViewModel : IMapFrom<Position>
    {
        public PositionViewModel()
        {
            this.Types = new HashSet<PositionType>();
        }

        public string PositionName { get; set; }

        public string CompanyName { get; set; }

        public DateTime AddedOn { get; set; }

        public ICollection<PositionType> Types { get; set; }
    }
}
