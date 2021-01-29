using System;
using System.Linq;

namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
            return n < 0 ? -n : (int)Math.Pow(n, 2);
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
            if (n < 100 || n > 999) return n;

            return Convert.ToInt32(string.Concat(n.ToString().OrderByDescending(c => c)));
        }
    }
}
