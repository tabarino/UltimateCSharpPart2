using System;

namespace Polymorphism
{
    public class Rectangle : PolyShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
            base.Draw();
        }
    }
}
