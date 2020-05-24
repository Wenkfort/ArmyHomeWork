using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmyProject.Units
{
    //************ вывод информации **********      
    // TODO: read about c# codestyle 
    interface UCore
    {
        void info();
    }
    //*********** Юнит **********************
    interface Unit : UCore
    {
        int health { get; set; }
        int deffense { get; set; }
        int dammage { get; set; }
    }
}
