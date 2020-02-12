using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EierfarmBl
{
    //public delegate void MachWas(object sender, EventArgs eventArgs);

    public abstract class Bird : IEggProducer
    {
        // Event-Deklaration
        public event EventHandler<BirdEventArgs> PropertyChanged;

        // Event-Trigger
        private void OnPropertyChanged([CallerMemberName]string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new BirdEventArgs(propertyName));
            }

            //PropertyChanged?.Invoke(this, new EventArgs());
        }

        //MachWas machWas;

        private Bird() { }

        public Bird(string name)
        {
            this.Name = name;

            //machWas = TuWas;
        }

        //private void TuWas(object sender, EventArgs eventArgs)
        //{
        //    throw new NotImplementedException();
        //}

        private double _weight;


        /// <summary>
        /// The weight of this animal in Gramm
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Weight may not be 0 or lower to prevent risk of anti-matter reaction.</exception>
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Weight may not be 0 or lower to prevent risk of anti-matter reaction.");
                }
                _weight = value;
                OnPropertyChanged();
            }
        }
        public DateTime Birthdate { get; set; }

        public List<Egg> Eggs { get; set; } = new List<Egg>();

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public abstract void Eat();
        public abstract void LayEgg();
    }
}
