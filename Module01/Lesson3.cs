using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module01
{
    // lesson 3 - code reuse/methods
    class Point
    {
        private int x, y, z;
        // this class represents a 3D point in space
        void SetLocation(int xValue, int yValue, int zValue)
        {
            x = xValue;
            y = yValue;
            z = zValue;
            // return keyword not required
        } // SetLocation method

        // calculate distance from another point
        // See, http://charliebravotango.com/link/getlink/951404
        double Distance(Point p)
        {
            double distance = 
                Math.Sqrt(
                    Math.Pow(p.x - x, 2)
                  + Math.Pow(p.y - y, 2)
                  + Math.Pow(p.z - z, 2));
            return distance;
        } // Distance method
    } // Point class
} // namespace
