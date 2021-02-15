using System;


namespace Snake
{
    internal class LocationCommandVeiwModel : ILocationVeiwModel
    {
        public ILocationModel LocationModel { get; }

        private readonly ICommandViewModel _commandViewModel;

        public event Action<ILocationChangeModel> OnLocationChange;


        public LocationCommandVeiwModel(ILocationModel locationModel, ICommandViewModel commandViewModel)
        {
            LocationModel = locationModel;
            _commandViewModel = commandViewModel;
            _commandViewModel.OnGetCommand += GetMoveCommand; ;
        }

        private void GetMoveCommand(MoveDirection moveDirection)
        {
            switch (moveDirection)
            {
                case MoveDirection.None:
                    break;
                case MoveDirection.Up:
                    LocationModel.Y++;
                    break;
                case MoveDirection.Down:
                    LocationModel.Y--;
                    break;
                case MoveDirection.Left:
                    LocationModel.X--;
                    break;
                case MoveDirection.Right:
                    LocationModel.X++;
                    break;
                default:
                    break;
            }
            Move(LocationModel.X, LocationModel.Y);
        }

        ~LocationCommandVeiwModel()
        {
            _commandViewModel.OnGetCommand -= GetMoveCommand;
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
