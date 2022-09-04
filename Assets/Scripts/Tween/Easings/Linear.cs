using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ans
{
    public class Linear: IEasing
    {
        public float Run(float rate)
        {
            return rate;
        }
    }
}
