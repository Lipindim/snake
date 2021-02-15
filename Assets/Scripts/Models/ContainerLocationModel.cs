using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace Snake.Models
{
    internal class ContainerLocationModel : IContainerLocationModel
    {
        private List<ILocationVeiwModel> _locationModels;

        public ContainerLocationModel()
        {
            _locationModels = new List<ILocationVeiwModel>();
        }

        public void AddLocationViewModel(ILocationVeiwModel locationModel)
        {
            _locationModels.Add(locationModel);
        }

        public ILocationVeiwModel First()
        {
            return _locationModels.First();
        }

        public IEnumerator<ILocationVeiwModel> GetEnumerator()
        {
            return _locationModels.GetEnumerator();
        }

        public ILocationVeiwModel Last()
        {
            return _locationModels.Last();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _locationModels.GetEnumerator();
        }
    }
}
