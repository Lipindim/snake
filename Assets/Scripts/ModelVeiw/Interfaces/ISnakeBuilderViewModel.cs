using System;

namespace Snake
{
    internal interface ISnakeBuilderViewModel
    {
        event Action<ILocationVeiwModel> OnCreateSegment;
    }
}
