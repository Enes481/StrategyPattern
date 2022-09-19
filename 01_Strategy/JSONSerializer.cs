using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Strategy
{
    internal class JSONSerializer : ISerialize<string>
    {
        public string Deserialize(string serializedData)
        {
            return $"{serializedData} verisi JSON'dan deserilize edildi";
        }

        public string Serialize(string data)
        {
            return $"{data} verisi JSON'a serilize edildi";
        }
    }
}
