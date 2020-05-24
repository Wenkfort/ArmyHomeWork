using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject.Units
{
    public class Soldier : Unit
    {
        public string name;
        public int health { get; set; }
        public int deffense { get; set; }
        public int dammage { get; set; }
        public string armor;

        public Soldier(string name, int health, int dammage)
        {
            this.name = name;
            this.health = health;
            this.dammage = dammage;
            // TODO: do something with "armor"
            Console.WriteLine("Soldier created!");
        } 

        public void info()
        {
            Console.WriteLine("Soldier: i am fine!");
        }
    }
}
