using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCAssignment2
{
    public static class TriangleSolver
    {
        public static string Analyze(string[] triDimensions)
        {
            string returnMessage = "";
            int[] measurements = new int[triDimensions.Length];

            for (int i = 0; i < triDimensions.Length; i++)
            {
                bool parsed = Int32.TryParse(triDimensions[i], out measurements[i]);
                if (!parsed)
                {
                    returnMessage = "Not a triangle : One or more values are not numeric";
                }
            }
            if (returnMessage == "")
            {
                if (triDimensions[0] == triDimensions[1] && triDimensions[0] == triDimensions[2])
                {
                    returnMessage = "This is a triangle : It is Equilateral";
                }
                else if (triDimensions[0] != triDimensions[1] && triDimensions[0] != triDimensions[2] && triDimensions[1] != triDimensions[2])
                {
                    returnMessage = "This is a triangle : It is Scalene";
                }
                else if (triDimensions[0] == triDimensions[1] || triDimensions[0] == triDimensions[2] || triDimensions[1] == triDimensions[2])
                {
                    returnMessage = "This is a triangle : It is Isoceles";
                }
            }
            return returnMessage;
        }
    }
}
