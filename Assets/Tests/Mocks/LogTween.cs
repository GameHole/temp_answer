using Ans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TweenTests
{
    class LogTween:Tween
    {
        public bool isSetInfo;
        public override void EasingMove(GameObject go, Vector3 from, Vector3 to, float time, bool pingpong, IEasing easing)
        {
            base.EasingMove(go, from, to, time, pingpong, easing);
            isSetInfo = true;
        }
    }
}
