using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    public class Duck : Bird
    {
        public Duck() : base("New Duck")
        {

        }

        public override void Eat()
        {
            if (this.Weight < 2000)
            {
                this.Weight += 200;
            }
        }

        public override void LayEgg()
        {
            if (this.Weight > 1000)
            {
                Egg egg = new Egg(this);
                this.Eggs.Add(egg);
                this.Weight -= egg.Weight;
            }
        }

        public void Dive()
        { }
    }
}
