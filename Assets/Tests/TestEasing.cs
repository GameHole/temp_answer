using Ans;
using NUnit.Framework;
using UnityEngine;

namespace TweenTests
{
    class TestEasing
    {
        [Test]
        public void testEaseIn()
        {
            var ease = new EaseIn();
            Assert.AreEqual(0.25f, ease.Run(0.5f));
        }
        [Test]
        public void testEaseOut()
        {
            var ease = new EaseOut();
            Assert.AreEqual(0, ease.Run(0));
            Assert.AreEqual(0.75f, ease.Run(0.5f));
            Assert.AreEqual(1, ease.Run(1));
        }
        [Test]
        public void testEaseInOut()
        {
            var logIn = new LogEasing();
            logIn.easing = new EaseIn();
            var logOut = new LogEasing();
            logOut.easing = new EaseOut();
            var ease = new EaseInOut(logIn, logOut);
            Assert.AreEqual(0.5f, ease.Run(0.5f));
            Assert.AreEqual(1, logIn.value, 1e-4);
            Assert.AreEqual(0.5f + logOut.easing.Run(0.02f) / 2f, ease.Run(0.51f));
            Assert.AreEqual(0.02f, logOut.value, 1e-4);
        }
    }
}
