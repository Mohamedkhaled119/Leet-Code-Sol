namespace _94._Binary_Tree_Inorder_Traversal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    public class Solution
    {
        List<int> ans = new List<int>();

        public IList<int> InorderTraversal(TreeNode root)
        {
            if (root == null) return ans;
            InorderTraversal(root.left);
            ans.Add(root.val);
            InorderTraversal(root.right);
            return ans;

        }
    }
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
