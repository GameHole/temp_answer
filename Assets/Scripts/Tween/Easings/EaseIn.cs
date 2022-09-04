namespace Ans
{
    public class EaseIn : IEasing
    {
        public float Run(float rate)
        {
            return rate * rate;
        }
    }
}
