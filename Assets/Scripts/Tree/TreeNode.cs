using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Ans
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int v)
        {
            value = v;
        }

        public int value { get; private set; }
    }
}
