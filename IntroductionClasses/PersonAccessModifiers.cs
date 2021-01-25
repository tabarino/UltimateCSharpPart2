using System;

namespace IntroductionClasses
{
    public class PersonAccessModifiers
    {
        // Private fields
        private string _name;
        private DateTime _birthday;

        // Properties - The names use Pascal Case
        // Property - Birthday
        public DateTime Birthday
        {
            get => _birthday;
            set => _birthday = value;
        }

        // Property - Name
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(this._name))
                {
                    this._name = value;
                }
            }
        }

        public void ShowValues()
        {
            Console.WriteLine(this._name);
            Console.WriteLine(this._birthday);
        }
    }
}
