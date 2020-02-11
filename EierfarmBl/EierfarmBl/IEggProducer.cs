using System;
using System.Collections.Generic;

namespace EierfarmBl
{
    public interface IEggProducer
    {
        List<Egg> Eggs { get; set; }
        double Weight { get; set; }

        void Eat();
        void LayEgg();

        event EventHandler<BirdEventArgs> PropertyChanged;
    }
}