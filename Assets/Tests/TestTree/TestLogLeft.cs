using Ans;
using NUnit.Framework;
using UnityEngine;

namespace TreeTests
{
    class TestLogLeft
    {
        ILogger org;
        LogLogger log;
        [SetUp]
        public void SetUp()
        {
            log = new LogLogger();
            org = TreeHelper.logger;
            TreeHelper.logger = log;
        }
        [TearDown]
        public void TearDown()
        {
            TreeHelper.logger = org;
        }
        [Test]
        public void testLogRootValue()
        {
            var root = new TreeNode(2);
            TreeHelper.LogLeft(root);
            Assert.AreEqual("2 ", log.log);
        }
        [Test]
        public void testLogLeftValue()
        {
            var root = new TreeNode(2);
            var left = new TreeNode(11);
            root.left = left;
            TreeHelper.LogLeft(root);
            Assert.AreEqual("2 11 ", log.log);
        }
        [Test]
        public void testLogRightLeftValue()
        {
            var root = new TreeNode(2);
            var right = new TreeNode(11);
            var left = new TreeNode(10);
            right.left = left;
            root.right = right;
            TreeHelper.LogLeft(root);
            Assert.AreEqual("2 10 ", log.log);
        }
        [Test]
        public void testIntergration()
        {
            TreeNode root = QuestionTree.Build();
            TreeHelper.LogLeft(root);
            Assert.AreEqual("2 11 10 7 13 ", log.log);
        }
    }
}
