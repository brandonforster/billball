using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillBall
{
    class RootObject
    {
        public List<Result> results { get; set; }

        public int getCount()
        {
            int runningCount = 0;
            for (int i = 0; i < results.Count; i++)
            {
                runningCount += (int)results[i].count;
            }
            return runningCount;
        }
    }
}
