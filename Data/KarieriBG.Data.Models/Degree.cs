namespace KarieriBG.Data.Models
{
    using System.Collections.Generic;

    using KarieriBG.Data.Common.Models;

    public class Degree : BaseDeletableModel<int>
    {
        public Degree()
        {
            this.Positions = new HashSet<Position>();
        }

        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
