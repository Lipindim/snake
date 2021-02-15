using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class ContainerLocationModel : IContainerLocationModel
    {
        private List<ILocationVeiwModel> _locationVeiwModels;

        public ContainerLocationModel()
        {
            _locationVeiwModels = new List<ILocationVeiwModel>();
        }
        public void AddLocationViewModel(ILocationVeiwModel locationViewModel)
        {
            _locationVeiwModels.Add(locationViewModel);
        }

        public ILocationVeiwModel First()
        {
            return _locationVeiwModels.First();
        }

        public IEnumerator<ILocationVeiwModel> GetEnumerator()
        {
            return _locationVeiwModels.GetEnumerator();
        }

        public ILocationVeiwModel Last()
        {
            return _locationVeiwModels.Last();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _locationVeiwModels.GetEnumerator();
        }
    }
}
