using System;


namespace Snake
{
    internal class SnakeBuilderViewModel : ISnakeBuilderViewModel
    {
        private readonly IContainerLocationModel _snakeSegmentsContainer;
        private readonly ISegmentBuilderViewModel _segmentBuilder;
        private readonly IRandomLocationViewModel _foodLocation;

        public event Action<ILocationVeiwModel> OnCreateSegment;

        public SnakeBuilderViewModel(ISegmentBuilderViewModel segmentBuilder, IRandomLocationViewModel foodLocation,
            IContainerLocationModel snakeSegmentsContainer)
        {
            _snakeSegmentsContainer = snakeSegmentsContainer;
            _segmentBuilder = segmentBuilder;
            _foodLocation = foodLocation;

            _foodLocation.OnLocationChange += OnFoodLocationChange;
        }

        private void OnFoodLocationChange(ILocationChangeModel locationChangeModel)
        {
            var lastSegment = _snakeSegmentsContainer.Last();
            var newSegment = _segmentBuilder.CreateSegment(lastSegment.LocationModel.X, lastSegment.LocationModel.Y);
            _snakeSegmentsContainer.AddLocationViewModel(newSegment);
            OnCreateSegment?.Invoke(newSegment);
        }
    }
}
