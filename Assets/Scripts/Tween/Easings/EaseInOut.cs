namespace Ans
{
    public class EaseInOut : IEasing
    {
        private IEasing logIn;
        private IEasing logOut;

        public EaseInOut(IEasing logIn, IEasing logOut)
        {
            this.logIn = logIn;
            this.logOut = logOut;
        }

        public float Run(float rate)
        {
            if (rate <= 0.5)
            {
                return logIn.Run(rate * 2) / 2;
            }
            return 0.5f + logOut.Run((rate - 0.5f) * 2) / 2;
        }
    }
}
