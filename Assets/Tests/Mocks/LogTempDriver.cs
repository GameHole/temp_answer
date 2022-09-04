using Ans;
using UnityEngine;

namespace TweenTests
{
    class LogTempDriver:Driver
    {
        internal Vector3 log;

        public override Vector3 Drive()
        {
            return new Vector3(0.1f, 0.2f, 0.3f);
        }
        public override void SetPosition(Vector3 pos)
        {
            log = pos;
        }
    }
}
