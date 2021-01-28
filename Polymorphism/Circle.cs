using System;

namespace Polymorphism
{
    public class Circle : PolyShape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw a circle.");
        }
    }
}
