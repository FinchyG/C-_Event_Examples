using System;
using System.Collections.Generic;
using System.Text;

namespace EventExample
{
    public class Car
    {
        private int _speed = 0;
        private int _safetySpeed = 70;

        public int Speed
        {
            get => _speed;
        }

        public void Accelerate(int mph)
        {
            int oldSpeed = _speed;
            _speed += mph;

            if (oldSpeed <= _safetySpeed && _speed > _safetySpeed)
                OnSpeedLimitExceeded(new EventArgs());
        }

        public event SpeedLimitExceededEventHandler SpeedLimitExceeded;

        public virtual void OnSpeedLimitExceeded(EventArgs e)
        {
            if (SpeedLimitExceeded != null) SpeedLimitExceeded(this, e);
        }
    }
}
