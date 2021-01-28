using System;

namespace Polymorphism
{
    public abstract class AbstractShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy Shape into Clipboad.");
        }

        public void Select()
        {
            Console.WriteLine("Select the Shape.");
        }
    }
}
