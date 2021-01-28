using System;
namespace Polymorphism
{
    public class CircleAbstractExample : AbstractShape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle.");
        }
    }
}
