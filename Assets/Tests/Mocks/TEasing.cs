using Ans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweenTests
{
    class TEasing : IEasing
    {
        public float Run(float rate)
        {
            return 0.5f;
        }
    }
}
