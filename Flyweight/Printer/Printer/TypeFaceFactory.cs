using System.Collections.Generic;

namespace Printer
{
    public class TypeFaceFactory
    {
        private static readonly IDictionary<string, TypeFace> _dict = new Dictionary<string, TypeFace>();
        private static readonly object _lock = new object();

        public static void SetTypeFace(string key, TypeFace typeFace)
        {
            if (!_dict.ContainsKey(key))
            {
                lock (_lock)
                {
                    if(!_dict.ContainsKey(key))
                        _dict[key] = typeFace;
                }
            }
        }

        public static TypeFace GetTypeFace(string key)
        {
            return _dict.ContainsKey(key) ? _dict[key] : null;
        }
    }
}