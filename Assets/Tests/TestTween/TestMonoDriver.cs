using Ans;
using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TestTools;

namespace TweenTests
{
    class TestMonoDriver
    {
        [UnityTest]
        public IEnumerator testUpdated()
        {
            var test = new LogDriver();
            var driver = new GameObject().AddComponent<MonoDriver>();
            driver.driver = test;
            yield return new WaitForSeconds(0.1f);
            Assert.IsTrue(test.IsRun);
        }
    }
}
