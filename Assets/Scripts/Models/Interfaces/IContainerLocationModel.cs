using System.Collections.Generic;


namespace Snake
{
    internal interface IContainerLocationModel : IEnumerable<ILocationVeiwModel>
    {
        void AddLocationViewModel(ILocationVeiwModel locationModel);
        ILocationVeiwModel First();
        ILocationVeiwModel Last();
    }
}