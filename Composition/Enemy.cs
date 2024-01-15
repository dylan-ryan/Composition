using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    internal class Enemy
    {
        public int x;
        public int y;
        //declare
        public HealthSystem healthSystem;

        //constructor
        public Enemy()
        {
            //instantiate
            healthSystem = new HealthSystem(50);
        }


    }
}
