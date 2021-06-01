using System.Collections.Generic;

namespace M3OO
{
    class Dictionary
    {
        private readonly List<string> _keys;
        private readonly List<string> _values;
        //private readonly List<string> _keysAndValues;

        public Dictionary()
        {
            //_keysAndValues = new List<string>();
            _keys = new List<string>();
            _values = new List<string>();
        }
        public void Add(string key, string value)
        {
            _keys.Add(key);
            _values.Add(value);
            //_keysAndValues.Add(key);
            //_keysAndValues.Add(value);

        }

        public string Get(string key)
        {
            var index = _keys.IndexOf(key);
            return index == -1 ? null : _values[index];
            //var index = _keysAndValues.IndexOf(key);
            //return index == -1 ? null : _keysAndValues[index+1];
        }
    }
}
