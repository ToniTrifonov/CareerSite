namespace KarieriBG.Data.Models
{
    using System.Collections.Generic;

    using KarieriBG.Data.Common.Models;

    public class City : BaseModel<int>
    {
        public City()
        {
            this.CityPositions = new HashSet<PositionCity>();
        }

        public string Name { get; set; }

        public virtual ICollection<PositionCity> CityPositions { get; set; }
    }
}
