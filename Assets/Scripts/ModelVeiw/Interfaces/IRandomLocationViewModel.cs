using System;


namespace Snake
{
    internal interface IRandomLocationViewModel
    {
        ILocationModel LocationModel { get; }
        void ChangeLocation();
        event Action<ILocationChangeModel> OnLocationChange;
    }
}
