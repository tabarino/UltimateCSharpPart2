using System;

namespace Polymorphism
{
    // Any class can inherit from a sealed class
    // Do NOT use sealed, only use if you have a very strict reason to use so.
    // This is kind of a antipattern
    public sealed class SealedClassExample
    {
        public SealedClassExample()
        {
            Console.WriteLine("Sealed Class");
        }
    }
}
