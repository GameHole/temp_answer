using System;
using UnityEngine;

namespace Ans
{
    public class Driver
    {
        public bool pingpong;
        public IEasing easing;
        public float output { get; set; }
        public float time { get; private set; }
        public Vector3 from { get; private set; }
        public Vector3 to { get; private set; }
        public Transform transform { get; set; }
        float velocity;
        public float input { get; set; }
        public Driver() { }
        public Driver(Transform transform,Vector3 from, Vector3 to, float time,bool pingpong,IEasing easing)
        {
            this.transform = transform;
            this.from = from;
            this.to = to;
            this.time = time;
            this.pingpong = pingpong;
            this.easing = easing;
            velocity = 1 / time;
        }
        public virtual Vector3 Drive()
        {
            return from * (1 - output) + output * to;
        }

        public virtual void Update(float deltaTime)
        {
            UpdateInput(deltaTime);
            UpdateOutPut();
            UpdatePosition();
        }

        public virtual void UpdateInput(float deltaTime)
        {
            input += velocity * deltaTime;
            if (input >= 1)
            {
                if (pingpong)
                {
                    input = 0;
                    ExchangePoint();
                }
                else
                {
                    input = 1;
                }
            }
        }

        public virtual void UpdateOutPut()
        {
            output = easing.Run(input);
        }

        public virtual void UpdatePosition()
        {
            SetPosition(Drive());
        }

        private void ExchangePoint()
        {
            var saved = from;
            from = to;
            to = saved;
        }

        public virtual void SetPosition(Vector3 pos)
        {
            transform.position = pos;
        }
    }
}
