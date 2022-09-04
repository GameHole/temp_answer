using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ans
{
    public class QuestionTree
    {
        public static TreeNode Build()
        {
            var root = new TreeNode(2);
            var left0 = new TreeNode(11);
            var right0 = new TreeNode(23);
            var left00 = new TreeNode(10);
            var right00 = new TreeNode(15);
            var left10 = new TreeNode(7);
            var right10 = new TreeNode(14);
            var right100 = new TreeNode(12);
            var left1000 = new TreeNode(13);
            right100.left = left1000;
            left10.right = right100;
            right0.left = left10;
            right0.right = right10;
            left0.left = left00;
            left0.right = right00;
            root.left = left0;
            root.right = right0;
            return root;
        }
    }
}
