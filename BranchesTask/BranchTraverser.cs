using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesTask
{
    public class BranchTraverser
    {
        public int getTreeDepth(Branch root)
        {
            if(root == null)
            {
                return 0;
            }
            if(root.Branches == null)
            {
                return 1;
            }

            int max = 0;
            foreach(Branch branch in root.Branches)
            {
                max = Math.Max(max, getTreeDepth(branch));
            }
            return max + 1;
        } 
    }
}
