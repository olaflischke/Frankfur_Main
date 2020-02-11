using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Chicken : Bird
    {
        public Chicken():base("New Chicken")
        {
            this.Weight = 1000;
        }

        public Chicken(string name):this()
        {
            this.Name = name;
        }

        public override void LayEgg()
        {
            if (this.Weight > 1500)
            {
                Egg ei = new Egg(this);
                this.Weight -= ei.Weight;
                this.Eggs.Add(ei);
            }
        }

        public override void Eat()
        {
            if (this.Weight < 3000)
            {
                this.Weight += 100;
            }
        }
    }
}
