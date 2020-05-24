using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject.Units
{
    class Rider : Unit
    {
        Soldier rider_druid = new Soldier("Fighter", 100, 10);
        Animal wolf = new Animal("Wolf");
        public int health { get; set; }
        public int deffense { get; set; }
        public int dammage { get; set; }

        public Rider(string name, int health, int dammage)
        {
            Console.WriteLine("Rider is created!");
        }
        // 
        public void info()
        {
            Console.WriteLine();
        }
    }
}
