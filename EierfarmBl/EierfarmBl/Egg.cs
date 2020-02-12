using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EierfarmBl
{
    [Serializable]
    public class Egg
    {
        //private Egg()
        //{

        //}

        public Egg(/*IEggProducer mother*/)
        {
            //this.Mother = mother;

            Random random = new Random();
            this.Weight = random.NextDouble() * 35 + 45;
            this.Color = (EggColor)random.Next(Enum.GetNames(typeof(EggColor)).Count());
        }

        // was kann?

        // was hat?

        [XmlAttribute(attributeName: "Size")]
        public double Weight { get; set; }

        [XmlElement(elementName: "Colour")]
        public EggColor Color { get; set; }
        public DateTime LayingDate { get; set; }

        //[XmlIgnore]
        //public IEggProducer Mother { get; set; }
    }

    public class Egg<TEggProducer> : Egg where TEggProducer : class, IEggProducer //, IDisposable, new()
    {
        public Egg(TEggProducer mother) //: base(mother)
        {
            this.Mother = mother;

            Random random = new Random();

            switch (mother)
            {
                case Chicken chicken:
                    this.Weight = random.NextDouble() * 45 + 35;
                    break;

                case Duck duck:
                    this.Weight = random.NextDouble() * 25 + 10;
                    break;

                default:
                    break;
            }

            this.Color = (EggColor)random.Next(3);
        }

        public TEggProducer Mother { get; set; }
    }

    public enum EggColor
    {
        Light,
        Dark,
        Green
    }
}
