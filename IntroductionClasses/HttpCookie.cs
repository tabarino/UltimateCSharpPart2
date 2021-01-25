using System;
using System.Collections.Generic;

namespace IntroductionClasses
{
    public class HttpCookie
    {
        // An indexer is a member that enables an object to be indexed in the same way as an array

        // Indexer is a special kind of property that allows accessing elements of a list by an index.
        // If a class has the semantics of a list, or collection, we can define an indexer property for it.
        // This way it’s easier to get or set items in the collection.

        // Key type string and Value type string
        // A Dictionary is used to translate Key into Strings
        private readonly Dictionary<string, string> _dictionary;

        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }
    }
}
