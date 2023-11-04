using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FominIN.Sprint4.Task0.V11.Lib
{
    public class DataService : ISprint4Task0V11
    {
        public int GetMultOddArrEl(int[] array)
        {
            int product = 1;

            foreach (int num in array)
            {
                if (num % 2 != 0)
                {
                    product *= num;
                }
            }

            return product;
        }

    }
}
