using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgrammer_192E {

    class Program {

        static void Main(string[] args)
        {
            var values = args[0].Split('+');
            var numbers = new List<int[]>();
            int carry = 0;
            int carrySum = 0;
            

            foreach (string value in values)
            {
                int[] number = value.ToCharArray().Select(x => (int) Char.GetNumericValue(x)).ToArray();
                numbers.Add(number);
            }

            // For each number in numbers, call numSplit. Then equalize size of results. 
        }

        public static List<int> numSplit(int number)
        {
            var splitNum = new List<int>();
            while (number > 0)
            {
                splitNum.Add(number % 10);
                number /= 10;
            }
            splitNum.Reverse();
            return splitNum;

        }
    }
}
