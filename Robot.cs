using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotLawnMower
{
    class Robot
    {
        public Robot(int x, int y)
        {
            PositionX = x;
            PositionY = y;
        }

        public int PositionX { get; set; }
        public int PositionY { get; set; }
    }
}
