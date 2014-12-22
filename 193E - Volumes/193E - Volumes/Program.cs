using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _193E___Volumes
{
    class Program
    {
        /* Program Spec:
           Description:
           An international shipping company is trying to figure out how to manufacture various types of containers. Given a volume they want to figure out the dimensions of various shapes that would all hold the same volume.
           Input:
           A volume in cubic meters.
           Output:
           Dimensions of containers of various types that would hold the volume. The following containers are possible.
           Cube
           Ball (Sphere)
           Cylinder
           Cone */
        static void Main()
        {
            double vol;
            Console.WriteLine("Please enter a volume: ");
            string input = Console.ReadLine();

            Func<double, double> cubeRoot = (x) => Math.Pow(x, 1.0 / 3.0);

            if (!double.TryParse(input, out vol))
            {
                Console.WriteLine("WARNING: Unable to parse input");
            }
            Console.WriteLine("For a volume of {0} cubic meters: ", vol);
            Console.WriteLine();

            var cube = Math.Round(cubeRoot(vol), 2);
            Console.WriteLine("You could use a cube with a side length of {0} meters", cube);

            var sphere = Math.Round(cubeRoot((0.75 * vol) / Math.PI), 2);
            Console.WriteLine("You could use a sphere of radius {0} meters", sphere);

            var cylinder = Math.Round(cubeRoot(vol / Math.PI), 2);
            Console.WriteLine("You could use a cylinder of radius and height {0} meters", cylinder);

            var cone = Math.Round(cubeRoot((3 * vol) / Math.PI), 2);
            Console.WriteLine("You could use a cone of base radius and height {0} meters", cone);

            // TODO: Make continue code, provide options with regard to height/radius ratio? Main functionality done.
        }
    }
}