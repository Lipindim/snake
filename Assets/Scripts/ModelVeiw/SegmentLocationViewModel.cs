using System;


namespace Snake
{
    internal class SegmentLocationViewModel : ILocationVeiwModel
    {
        public ILocationModel LocationModel { get; }

        public event Action<ILocationChangeModel> OnLocationChange;

        public SegmentLocationViewModel(ILocationModel locationModel)
        {
            LocationModel = locationModel;
        }

        public void Move(float x, float y)
        {
            var locationChangeModel = new LocationChangeModel(LocationModel.X, LocationModel.Y, x, y);
            LocationModel.X = x;
            LocationModel.Y = y;
            OnLocationChange?.Invoke(locationChangeModel);
        }
    }
}
