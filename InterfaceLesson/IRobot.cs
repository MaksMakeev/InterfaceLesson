using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    interface IRobot
    {
        public string GetInfo();
        public List<string> GetComponents();
        public string GetRobotType()
        {
            return "I am a simple robot.";
        }


    }
}
