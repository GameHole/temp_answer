using Ans;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.TestTools;

namespace TweenTests
{
    class TestDriver
    {
        Vector3 from;
        Vector3 to;
        Driver driver;
        Transform tran;
        float v;
        [SetUp]
        public void SetUp()
        {
            tran = new GameObject().transform;
            from = new Vector3(1, 1, 1);
            to = new Vector3(0, 0, 0);
            driver = new Driver(tran, from, to, 1.5f, false, new Linear());
            v = 1 / 1.5f;
        }
        [Test]
        public void testDriver()
        {
            driver.output = 0.01f;
            TestTween.AssertVector3(from * (1 - driver.output) + to * driver.output, driver.Drive());
        }
        [Test]
        public void testDriverTempulete()
        {
            var log = new LogDriverUpdate();
            log.Update(0.1f);
            Assert.AreEqual("UpdateInput:0.1 UpdateOutPut UpdatePosition ", log.log);
        }
        [Test]
        public void testUpdateInput()
        {
            driver.UpdateInput(0.1f);
            Assert.AreEqual(0.1f*v, driver.input, 1e-4);
            driver.UpdateInput(1f);
            Assert.AreEqual(1.1f * v,driver.input, 1e-4);
            driver.UpdateInput(0.4f);
            Assert.AreEqual(1f, driver.input, 1e-4);
        }
        [Test]
        public void testUpdateOutput()
        {
            driver.easing = new TEasing();
            driver.UpdateOutPut();
            Assert.AreEqual(0.5f, driver.output, 1e-4);
        }
        [Test]
        public void testUpdatePosition()
        {
            var driver = new LogTempDriver();
            driver.UpdatePosition();
            TestTween.AssertVector3(driver.Drive(),driver.log);
        }
        [Test]
        public void testPingPong()
        {
            driver.pingpong = true;
            Assert.AreEqual(from, driver.from);
            Assert.AreEqual(to, driver.to);
            driver.Update(1.5f);
            Assert.AreEqual(driver.input, 0);
            Assert.AreEqual(driver.output, 0);
            Assert.AreEqual(to, driver.from);
            Assert.AreEqual(from, driver.to);
        }
    }
}
