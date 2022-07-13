using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchesTask
{
    public class BranchFactory
    {
        public static Branch CreateBranchInstance()
        {
            return new Branch();
        }

        public static List<Branch> CreateBranchList(int count)
        {
            List<Branch> list = new List<Branch>();
            for(int i = 0; i < count; i++)
            {
                list.Add(CreateBranchInstance());
            }
            return list;
        }
    }
}
