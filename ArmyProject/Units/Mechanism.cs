using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject.Units
{
    class Mechanism : Unit
    {
        public string name;
        public int health { get; set; }
        public int deffense { get; set; }
        public int dammage { get; set; }

        public int Ammo_count;
        public Mechanism(string name, int health, int def, int dam, int ammo_count)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            // i don't remember if "this" is nedded?
            this.health = health;
            this.deffense = def;
            this.dammage = dam;
            this.Ammo_count = ammo_count;
        }
        public void info() //pishetsia infa o Mech
        {
            Console.WriteLine("Mechanism:" + this.name + " health: " + this.health.ToString());
        }

    }
}
