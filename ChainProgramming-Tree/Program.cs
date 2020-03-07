using System;

namespace ChainProgramming_Tree
{
    internal class Program
    {
        static int maxDepth = 0;

        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var root = new TreeNode("root").AddChildren(
                    ((TreeNode)"A_0").AddChildren(
                        ((TreeNode)"B_0").AddChildren(
                            "C_0",
                            "C_1",
                            "C_2"),
                        ((TreeNode)"B_1").AddChildren(
                            ((TreeNode)"C_3").AddChildren(
                                "D_0",
                                ((TreeNode)"D_1").AddChildren(
                                    "E_0",
                                    "E_1"
                                    )))),
                    "A_1");

            PrintTree(root, 0);
            Console.WriteLine($"最大深度：{maxDepth}");
            Console.Read();
        }

        private static void PrintTree(TreeNode node, int level)
        {
            maxDepth = Math.Max(level, maxDepth);
            Console.WriteLine($"{string.Empty.PadLeft(level, '·')}└ {node.Name}");
            node.Children.ForEach(child => PrintTree(child, level + 1));
        }
    }
}
