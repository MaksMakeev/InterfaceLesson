﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    interface IFlyingRobot : IRobot
    {
        public string GetRobotType()
        {
            return "I am a flying robot.";
        }
    }
}
