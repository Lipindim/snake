using System;


namespace Snake
{
    internal interface ILocationVeiwModel
    {
        ILocationModel LocationModel { get; }
        void Move(float x, float y);
        event Action<ILocationChangeModel> OnLocationChange;
    }
}
