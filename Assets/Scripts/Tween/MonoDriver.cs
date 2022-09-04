using UnityEngine;

namespace Ans
{
    public class MonoDriver : MonoBehaviour
    {
        public Driver driver;
        private void Update()
        {
            driver.Update(Time.deltaTime);
        }
    }
}
