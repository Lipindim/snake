namespace Snake
{
    internal interface ILocationChangeModel
    {
        float PreviousX { get; }
        float PreviousY { get; }
        float CurrentX { get; }
        float CurrentY { get; }
    }
}
