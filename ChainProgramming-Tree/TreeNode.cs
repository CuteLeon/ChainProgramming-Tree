using System.Collections.Generic;

namespace ChainProgramming_Tree
{
    internal class TreeNode
    {
        public TreeNode(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }

        public TreeNode Parent { get; set; }

        public List<TreeNode> Children { get; set; } = new List<TreeNode>();

        public TreeNode this[int index] => this.Children[index];

        public static implicit operator TreeNode(string name)
        {
            return new TreeNode(name);
        }

        public TreeNode AddChildren(params TreeNode[] treeNodes)
        {
            this.Children.AddRange(treeNodes);
            return this;
        }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
