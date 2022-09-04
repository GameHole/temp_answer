using Ans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweenTests
{
    class LogDriver:Driver
    {
        internal bool IsRun;
        public override void Update(float deltaTime)
        {
            IsRun = true;
        }
    }
}
