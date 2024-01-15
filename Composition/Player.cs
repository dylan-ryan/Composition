using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Player
    {
        public int x;
        public int y;
        public HealthSystem healthSystem;

        //constructor
        public Player()
        {
            healthSystem = new HealthSystem(100);
        }


    }
}
