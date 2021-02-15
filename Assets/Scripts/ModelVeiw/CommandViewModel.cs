using System;
using UnityEngine;


namespace Snake
{
    internal class CommandViewModel : ICommandViewModel, IUpdate
    {
        private readonly IRoundUpdateViewModel _roundUpdateViewModel;
        private MoveDirection _lastMoveDirection;

        public event Action<MoveDirection> OnGetCommand;

        public CommandViewModel(IRoundUpdateViewModel roundUpdateViewModel)
        {
            _roundUpdateViewModel = roundUpdateViewModel;
            _roundUpdateViewModel.OnNewRound += OnNewRound;
        }
        ~CommandViewModel()
        {
            _roundUpdateViewModel.OnNewRound -= OnNewRound;
        }

        private void OnNewRound()
        {
            OnGetCommand?.Invoke(_lastMoveDirection);
        }

        public void Update(float deltaTime)
        {
            if (Input.GetKey(KeyCode.UpArrow))
                _lastMoveDirection = MoveDirection.Up;
            if (Input.GetKey(KeyCode.DownArrow))
                _lastMoveDirection = MoveDirection.Down;
            if (Input.GetKey(KeyCode.LeftArrow))
                _lastMoveDirection = MoveDirection.Left;
            if (Input.GetKey(KeyCode.RightArrow))
                _lastMoveDirection = MoveDirection.Right;
        }
    }
}
