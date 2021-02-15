using System;


namespace Snake
{
    internal class RandomLocationViewModel : IRandomLocationViewModel
    {
        private readonly ILocationCoorinates _locationCoorinates;

        public ILocationModel LocationModel { get; }

        public event Action<ILocationChangeModel> OnLocationChange;

        public RandomLocationViewModel(ILocationModel locationModel, ILocationCoorinates locationCoorinates)
        {
            _locationCoorinates = locationCoorinates;
            LocationModel = locationModel;
        }

        public void ChangeLocation()
        {
            float previouxX = LocationModel.X;
            float previousY = LocationModel.Y;

            LocationModel.X = UnityEngine.Random.Range(_locationCoorinates.MinX, _locationCoorinates.MaxX);
            LocationModel.Y = UnityEngine.Random.Range(_locationCoorinates.MinY, _locationCoorinates.MaxY);
            var locationChangeModel = new LocationChangeModel(previouxX, previousY, LocationModel.X, LocationModel.Y);
            OnLocationChange?.Invoke(locationChangeModel);
        }

        
    }
}
