using System;
using ArmyProject.Units;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject
{
    class Army
    {
        public Army()
        {
            Soldier soldier = new Soldier("Fighter", 100, 10);
            Rider rider = new Rider("Rider", 100, 10);
            Mechanism mechanism = new Mechanism("catapult", 790, 100, 10, 50);
            Console.WriteLine("Army is created!");
        }
    }
}
