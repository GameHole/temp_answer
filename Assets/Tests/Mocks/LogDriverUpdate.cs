using Ans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweenTests
{
    internal class LogDriverUpdate:Driver
    {
        public string log;


        public override void UpdatePosition()
        {
            log += "UpdatePosition ";
        }
        public override void UpdateInput(float deltaTime)
        {
            log += $"UpdateInput:{deltaTime} ";
        }
        public override void UpdateOutPut()
        {
            log += "UpdateOutPut ";
        }
    }
}
