namespace KarieriBG.Data.Models
{
    using System;
    using System.Collections.Generic;

    using KarieriBG.Data.Common.Models;

    public class Position : BaseDeletableModel<string>
    {
        public Position()
        {
            this.Id = Guid.NewGuid().ToString();
            this.PositionTypes = new HashSet<PositionType>();
            this.PositionCities = new HashSet<PositionCity>();
        }

        public string Name { get; set; }

        public string CompanyName { get; set; }

        public string Description { get; set; }

        public string Responsibilities { get; set; }

        public string Requirements { get; set; }

        public string Offerings { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int DepartmentId { get; set; }

        public virtual Department Department { get; set; }

        public int DegreeId { get; set; }

        public virtual Degree Degree { get; set; }

        public virtual ICollection<PositionCity> PositionCities { get; set; }

        public virtual ICollection<PositionType> PositionTypes { get; set; }
    }
}
