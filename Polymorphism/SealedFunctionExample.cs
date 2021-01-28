using System;

namespace Polymorphism
{
    public class SealedFunctionExample : PolyShape
    {
        // A sealed class can be under a normal class
        // A sealed method is slighty faster because if some run-time optimisations
        // Do NOT use sealed, only use if you have a very strict reason to use so.
        // This is kind of a antipattern
        public sealed override void Draw()
        {
            Console.WriteLine("Draw a sealed class.");
        }
    }
}
