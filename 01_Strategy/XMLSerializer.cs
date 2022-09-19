using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Strategy
{
    internal class XMLSerializer : ISerialize<string>
    {
        public string Deserialize(string serializedData)
        {
            return $"{serializedData} verisi XML'den deserilize edildi";
        }

        public string Serialize(string data)
        {
            return $"{data} verisi XML'e serilize edildi";
        }
    }
}
