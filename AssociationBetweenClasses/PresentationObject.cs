using System;

namespace AssociationBetweenClasses
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object Copied to Clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was Duplicated.");
        }
    }
}
