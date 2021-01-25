using System;

namespace IntroductionClasses
{
    public class PersonProperties
    {
        // Using this code C# automatically creates a private field
        // And implements the get and set methods
        public string Name { get; set; }
        public string UserName { get; set; }

        // In this case I can set the Birthday only once and it cannot be changed
        public DateTime Birthday { get; private set; }

        // Property with a custom get
        public int Age
        {
            get
            {
                var timespan = DateTime.Today - Birthday;
                var years = timespan.Days / 365;

                return years;
            }
        }

        public PersonProperties(DateTime birthday)
        {
            Birthday = birthday;
        }
    }
}
