namespace KarieriBG.Web.ViewModels.Position
{
    using System.Collections.Generic;

    public class AllPositionsViewModel
    {
        public AllPositionsViewModel()
        {
            this.Positions = new HashSet<PositionViewModel>();
        }

        public ICollection<PositionViewModel> Positions { get; set; }

        public int PageNumber { get; set; }
    }
}
