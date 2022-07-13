namespace BranchesTask
{
    public class Program
    {
        static void Main(string[] args)
        {
            Branch root = initTree();
            BranchTraverser branchTraverser = new BranchTraverser();
            Console.WriteLine("Tree's depth is: " + branchTraverser.getTreeDepth(root));
        }

        private static Branch initTree()
        {
            Branch root = BranchFactory.CreateBranchInstance();
            root.Branches = BranchFactory.CreateBranchList(2);
            root.Branches[0].Branches = BranchFactory.CreateBranchList(1);
            root.Branches[1].Branches = BranchFactory.CreateBranchList(3);
            root.Branches[1].Branches[0].Branches = BranchFactory.CreateBranchList(1);
            root.Branches[1].Branches[1].Branches = BranchFactory.CreateBranchList(2);
            root.Branches[1].Branches[2].Branches = BranchFactory.CreateBranchList(1);
            root.Branches[1].Branches[1].Branches[0].Branches = BranchFactory.CreateBranchList(1);
            return root;
        }
    }
}