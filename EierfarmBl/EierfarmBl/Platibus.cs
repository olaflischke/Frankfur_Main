using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public class Platibus : Mamal, IEggProducer
    {
        public Platibus()
        {
            this.Id = Guid.NewGuid();
            this.Eggs = new List<Egg>();
            this.Weight = 2000;
        }

        public List<Egg> Eggs { get; set; }

        public double Weight { get; set; }

        public event EventHandler<BirdEventArgs> PropertyChanged;

        public override void BreastFeed()
        {
            throw new NotImplementedException();
        }

        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void LayEgg()
        {
            Egg<Platibus> egg = new Egg<Platibus>(this);

            Egg<IEggProducer> egg1 = new Egg<IEggProducer>(this);
        }
    }
}