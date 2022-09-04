using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Ans
{
    public class TreeHelper
    {
        public static ILogger logger = Debug.unityLogger;

        public static void LogLeft(TreeNode root)
        {
            logger.Log(LogType.Log, root.value);
            if (root.left != null)
                LogLeft(root.left);
            if (root.right != null && root.right.left != null)
                LogLeft(root.right.left);
        }
        
    }
}
