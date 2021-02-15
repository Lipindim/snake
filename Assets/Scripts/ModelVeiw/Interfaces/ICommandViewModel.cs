using System;


namespace Snake
{
    internal interface ICommandViewModel
    {
        event Action<MoveDirection> OnGetCommand;
    }
}
