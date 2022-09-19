using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Strategy
{
    public class SerializerMAnager2
    {
        XMLSerializer xmlSeriliazer;
        JSONSerializer jsonSerializer;

        public SerializerMAnager2(Serializers serializers)
        {
            xmlSeriliazer = new XMLSerializer();
            jsonSerializer = new JSONSerializer();
        }

        public string Serialize(string data)
        {
            if (data.Length < 15)
            {
                return xmlSeriliazer.Serialize(data);
            }
            else
            {
                return jsonSerializer.Serialize(data);
            }
        }

        public string Deserialize(string data)
        {
            if (data.Length < 15)
            {
                return xmlSeriliazer.Serialize(data);
            }
            else
            {
                return jsonSerializer.Serialize(data);
            }
        }
    }
}
