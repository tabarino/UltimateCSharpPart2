using System;

namespace IntroductionClasses
{
    public class Calculator
    {
        public Calculator()
        {
        }

        // Setting params here we do not need to instantiate the array when calling this method
        // Without params -> calculator.Add(new int[] { 1, 2 });
        // With params -> calculator.Add(1, 2);
        public int Add(params int[] numbers)
        {
            var sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }
    }
}
