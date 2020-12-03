namespace KarieriBG.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KarieriBG.Data.Common.Models;

    public class Department : BaseDeletableModel<int>
    {
        public Department()
        {
            this.Positions = new HashSet<Position>();
        }

        public string Name { get; set; }

        public virtual ICollection<Position> Positions { get; set; }
    }
}
