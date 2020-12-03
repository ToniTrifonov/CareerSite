namespace KarieriBG.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PositionType
    {
        public int Id { get; set; }

        public string PositionId { get; set; }

        public virtual Position Position { get; set; }

        public int TypeId { get; set; }

        public virtual Type Type { get; set; }
    }
}
