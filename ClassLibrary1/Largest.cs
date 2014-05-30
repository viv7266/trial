using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestFunction
{
    public class LargestNumber
    {
        public static int Largest (int[] list)
        {
            int index, max = 0;
            for (index = 0; index < list.Length - 1; index++) 
            {
                if (list[index] > max) 
                {
                    max = list[index];
                }
            }
            return max;
        }

    }
}
