using System;

namespace Polymorphism
{
    public class RectangleAbstractExample : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }
}
