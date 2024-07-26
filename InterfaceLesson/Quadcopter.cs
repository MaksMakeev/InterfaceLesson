using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLesson
{
    internal class Quadcopter : IFlyingRobot, IChargeable
    {
        List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public List<string> GetComponents()
        {
            return _components;
        }

        public string GetInfo()
        {
            return "Super Flying Robot 3000";
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }
}
