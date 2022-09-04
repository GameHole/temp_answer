namespace Ans
{
    public class EaseOut : IEasing
    {
        public float Run(float rate)
        {
            return 2 * rate - rate * rate;
        }
    }
}
