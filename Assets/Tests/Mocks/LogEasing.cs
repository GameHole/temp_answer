using Ans;

namespace TweenTests
{
    class LogEasing : IEasing
    {
        public double value;
        public IEasing easing;
        public float Run(float rate)
        {
            value = rate;
            return easing.Run(rate);
        }
    }
}
