namespace KarieriBG.Data.Models
{
    using System.Collections.Generic;

    using KarieriBG.Data.Common.Models;

    public class Type : BaseDeletableModel<int>
    {
        public Type()
        {
            this.TypePositions = new HashSet<PositionType>();
        }

        public string Name { get; set; }

        public virtual ICollection<PositionType> TypePositions { get; set; }
    }
}
