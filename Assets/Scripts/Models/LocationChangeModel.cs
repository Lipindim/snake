namespace Snake
{
    public class LocationChangeModel : ILocationChangeModel
    {
        public float PreviousX { get; }

        public float PreviousY { get; }

        public float CurrentX { get; }

        public float CurrentY { get; }

        public LocationChangeModel(float previouX, float previousY, float currentX, float currentY)
        {
            PreviousX = previouX;
            PreviousY = previousY;
            CurrentX = currentX;
            CurrentY = currentY;
        }
    }
}
