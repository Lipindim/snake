using System;
namespace Snake
{
    public class LocationCoordinates : ILocationCoorinates
    {
        public float MinX { get; }

        public float MaxX { get; }

        public float MinY { get; }

        public float MaxY { get; }

        public LocationCoordinates(float minX, float maxX, float minY, float maxY)
        {
            MinX = minX;
            MaxX = maxX;
            MinY = minY;
            MaxY = maxY;
        }
    }
}
