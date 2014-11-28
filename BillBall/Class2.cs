using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillBall
{
    class Data
    {
        public List<Year> Years { get; set; }

        public void results()
        {
            for(int i = 0; i < Years.Count; i++)
            {
                Console.WriteLine(Years[i].count);
            }
        }
    }
}
