using System;
using System.Collections;
using System.Collections.Generic;
using Ans;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
namespace TweenTests
{
    public class TestTween
    {

        public static void AssertVector3(Vector3 exp,Vector3 act)
        {
            Assert.AreEqual(exp.x, act.x,1e-4);
            Assert.AreEqual(exp.y, act.y, 1e-4);
            Assert.AreEqual(exp.z, act.z, 1e-4);
        }
        GameObject go;
        LogTween tween;
        Vector3 from ;
        Vector3 to;
        [SetUp]
        public void SetUp()
        {
            go = new GameObject();
            from = new Vector3(1, 1, 1);
            to = new Vector3(0, 0, 0);
            tween = new LogTween();
        }
        [Test]
        public void testSetInfo()
        {
            var linear = new Linear();
            tween.EasingMove(go, from, to, 1, true, linear);
            var drv = go.GetComponent<MonoDriver>();
            Assert.NotNull(drv);
            Assert.AreEqual(go.transform, drv.driver.transform);
            Assert.AreEqual(from, drv.driver.from);
            Assert.AreEqual(to, drv.driver.to);
            Assert.AreEqual(1, drv.driver.time);
            Assert.IsTrue(drv.driver.pingpong);
            Assert.AreSame(linear, drv.driver.easing);
        }
        [Test]
        public void testMove()
        {
            var funcNames = new string[] { "Move", "EaseIn" , "EaseOut","EaseInOut" };
            var types = new Type[] {typeof(Linear),typeof(EaseIn),typeof(EaseOut), typeof(EaseInOut) };
            for (int i = 0; i < funcNames.Length; i++)
            {
                SetUp();
                var move = typeof(Tween).GetMethod(funcNames[i]);
                move.Invoke(tween, new object[] { go, from, to, 1, false });
                var drv = go.GetComponent<MonoDriver>();
                Assert.IsTrue(tween.isSetInfo);
                Assert.AreSame(types[i], drv.driver.easing.GetType());
            }
        }
    }
}
