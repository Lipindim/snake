namespace Snake
{
    internal class LocationModel : ILocationModel
    {
        public float X { get; set; }
        public float Y { get; set; }

        public LocationModel(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
