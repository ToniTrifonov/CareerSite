namespace KarieriBG.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PositionCity
    {
        public int Id { get; set; }

        public int CityId { get; set; }

        public virtual City City { get; set; }

        public string PositionId { get; set; }

        public virtual Position Position { get; set; }
    }
}
