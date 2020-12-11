namespace KarieriBG.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;

    using KarieriBG.Web.ViewModels.Position;

    public interface IPositionsService
    {
        Task AddAsync(AddPositionInputModel input);

        T GetById<T>(string id);

        AllPositionsViewModel GetAll();

        Task EditAsync(string id, EditPositionViewModel input);
    }
}
