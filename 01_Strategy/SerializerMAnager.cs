using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Strategy
{
    public class SerializerMAnager
    {
        ISerialize<string> serializer;

        public SerializerMAnager(Serializers serializers)
        {
            SetSerializer(serializers);
        }

        public void SetSerializer(Serializers serializers)
        {
            switch (serializers)
            {
                case Serializers.XML:
                    serializer = new XMLSerializer();
                    break;
                case Serializers.JSON:
                    serializer = new JSONSerializer();
                    break;
            }
        }

        public string Serialize(string data)
        {
            return serializer.Serialize(data);
        }

        public string Deserialize(string data)
        {
            return serializer.Deserialize(data);
        }
    }
}
