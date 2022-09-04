using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ans
{
   
    public class Tween
    {
        public void Move(GameObject go, Vector3 from, Vector3 to, float time, bool pingpong)
        {
            EasingMove(go, from, to, time, pingpong, new Linear());
        }
        public virtual void EasingMove(GameObject go, Vector3 from, Vector3 to, float time, bool pingpong,IEasing easing)
        {
           go.AddComponent<MonoDriver>().driver = new Driver(go.transform, from, to, time, pingpong, easing);
        }

        public void EaseIn(GameObject go, Vector3 from, Vector3 to, int time, bool pingpong)
        {
            EasingMove(go, from, to, time, pingpong, new EaseIn());
        }
        public void EaseOut(GameObject go, Vector3 from, Vector3 to, int time, bool pingpong)
        {
            EasingMove(go, from, to, time, pingpong, new EaseOut());
        }
        public void EaseInOut(GameObject go, Vector3 from, Vector3 to, int time, bool pingpong)
        {
            EasingMove(go, from, to, time, pingpong, new EaseInOut(new EaseIn(),new EaseOut()));
        }
    }
}

