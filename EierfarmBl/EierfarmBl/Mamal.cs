using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EierfarmBl
{
    public abstract class Mamal
    {
        public System.Guid Id { get; set; }

        public abstract void BreastFeed();
    }
}