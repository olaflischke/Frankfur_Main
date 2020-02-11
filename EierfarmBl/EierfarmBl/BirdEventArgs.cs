using System;

namespace EierfarmBl
{
    public class BirdEventArgs : EventArgs
    {
        public BirdEventArgs(string propName)
        {
            this.ChangedProperty = propName;
        }

        public string ChangedProperty { get; set; }
    }
}