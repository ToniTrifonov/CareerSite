namespace KarieriBG.Web.ViewModels.Position
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Text;

    using KarieriBG.Data.Models;
    using KarieriBG.Services.Mapping;

    public class EditPositionViewModel : IMapFrom<Position>
    {
        [Required]
        [Display(Name = "Position Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }

        [Required]
        [MinLength(100)]
        [Display(Name = "Position Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Main Responsibilities")]
        public string Responsibilities { get; set; }

        [Display(Name = "Candidate Requirements")]
        public string Requirements { get; set; }

        [Display(Name = "The company offers")]
        public string Offerings { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [Display(Name = "Degree")]
        public int DegreeId { get; set; }

        [Display(Name = "Suitable for")]
        public ICollection<PositionType> Types { get; set; }

        [Display(Name = "Position available in")]
        public ICollection<PositionCity> Cities { get; set; }
    }
}
