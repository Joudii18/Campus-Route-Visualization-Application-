using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xAcademics
{
    internal class Building
    {

        private string _buildingNumber;
        private Point _location;

        private static readonly Dictionary<string, Point> BuildingLocations = new Dictionary<string, Point>
        {
            // Approximate (x, y) pixel coordinates on the KFUPM map image
           
            { "2", new Point(113, 71) },
            { "3", new Point(182, 118) },
            { "4", new Point(164, 99) },
            { "6",  new Point(224, 158) },
            { "7", new Point(222, 184) },
            { "8", new Point(261, 199) },
            { "9", new Point(265, 230 )},
            { "10", new Point(260, 257) },
            { "11", new Point(306, 283) },
            { "12", new Point(172, 177) },
            { "14", new Point(188, 236) },
            { "15", new Point(133, 194) },
            { "16", new Point(159, 122) },
            { "17", new Point(225, 216) },
            { "18", new Point(212, 259) },
            { "19", new Point(223, 282) },
            { "20", new Point(236, 293) },
            { "21", new Point(295, 241 )},
            { "22", new Point(326, 257) },
            { "23", new Point(353, 281 )},
            { "24", new Point(337, 301) },
            { "25", new Point(355, 329) },
            { "26", new Point(69, 54) },
            { "40", new Point(268, 38) },
            { "59", new Point(280, 146) },
            { "68", new Point(550, 100) },
            };

        public Building(string buildingNumber)
        {
            _buildingNumber = buildingNumber;

            if (BuildingLocations.ContainsKey(buildingNumber))
                _location = BuildingLocations[buildingNumber];
            else
                _location = new Point(-1, -1);
        }

        public string getBuildingNumber()
        {
            return _buildingNumber;
        }

        public Point getLocation ()
        {
            return _location;
        }
        public bool hasKnownLocation()
        {
            return _location.X != -1 && _location.Y != -1;
        }

        public override string ToString()
        {

            return "Building " + _buildingNumber;

        }
    }
}
