using Ans;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace TreeTests
{
    class TestTree
    {
        [Test]
        public void testTreeNode()
        {
            var node = new TreeNode(2);
            Assert.AreEqual(2, node.value);
        }
        [Test]
        public void testTreeHelper()
        {
            Assert.AreSame(Debug.unityLogger , TreeHelper.logger);
        }
    }
}
