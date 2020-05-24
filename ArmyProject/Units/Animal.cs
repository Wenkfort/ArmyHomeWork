using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject.Units
{
    class Animal
    {
        public string name;
        public int health = 27;
        public int speed = 11;
        public int dam = 5;
        public bool Alive;

        public Animal(string name)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            // TODO: if you create an animal it's alive by default. You can not create dead animal ;)
            this.Alive = true;
        }
    }
}
