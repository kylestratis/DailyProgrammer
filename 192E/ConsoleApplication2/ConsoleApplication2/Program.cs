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

            // Get carry values only. TODO: Fix and finish obtaining carry values, then write actual addition. 
            // Carry values are for display only.
            for (int i = 1; i < numbers.Count; i++)
            {
                carrySum += numbers[i].Last();
            }

            carry = carrySum % 10;


    

        }
    }
}
