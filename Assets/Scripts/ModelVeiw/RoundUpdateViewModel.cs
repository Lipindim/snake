using System;


namespace Snake
{
    public class RoundUpdateViewModel : IRoundUpdateViewModel, IUpdate
    {
        public event Action OnNewRound;

        private readonly UnityTimer _unityTimer;

        public RoundUpdateViewModel(float interval)
        {
            _unityTimer = new UnityTimer(interval, 0);
            _unityTimer.OnTick += OnTimerTick;
        }

        ~RoundUpdateViewModel()
        {
            _unityTimer.OnTick -= OnTimerTick;
        }

        private void OnTimerTick()
        {
            OnNewRound?.Invoke();
        }

        public void Update(float deltaTime)
        {
            _unityTimer.Tick(deltaTime);
        }
    }
}
