using System;

namespace Snake
{
    public class UnityTimer
    {
        private float _timeUntilNextSpawn;
        private float _interval;

        public event Action OnTick;

        public UnityTimer(float interval, float startToFirst)
        {
            _interval = interval;
            _timeUntilNextSpawn = startToFirst;
        }

        public void Tick(float deltaTime)
        {
            _timeUntilNextSpawn -= deltaTime;
            if (_timeUntilNextSpawn <= 0)
            {
                OnTick?.Invoke();
                _timeUntilNextSpawn = _interval;
            }
        }
    }
}
