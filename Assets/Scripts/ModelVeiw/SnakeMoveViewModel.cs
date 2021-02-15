using System.Linq;

namespace Snake
{
    internal class SnakeMoveViewModel
    {
        private readonly ILocationVeiwModel _headLocationViewModel;
        private readonly IContainerLocationModel _snakeContainer;

        public SnakeMoveViewModel(IContainerLocationModel snakeContainer, ILocationVeiwModel headLocationViewModel)
        {
            _headLocationViewModel = headLocationViewModel;
            _snakeContainer = snakeContainer;

            _headLocationViewModel.OnLocationChange += OnHeadChangeLocation;
        }

        ~SnakeMoveViewModel()
        {
            _headLocationViewModel.OnLocationChange -= OnHeadChangeLocation;
        }

        private void OnHeadChangeLocation(ILocationChangeModel headLocationChangeModel)
        {
            float previousX = headLocationChangeModel.PreviousX;
            float previousY = headLocationChangeModel.PreviousY;
            foreach (ILocationVeiwModel segment in _snakeContainer)
            {
                if (segment != _snakeContainer.First())
                {
                    float previousBufferX = segment.LocationModel.X;
                    float previousBufferY = segment.LocationModel.Y;
                    segment.Move(previousX, previousY);
                    previousX = previousBufferX;
                    previousY = previousBufferY;
                }
            }
        }
    }
}
