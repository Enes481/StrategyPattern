using System;

namespace _01_Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SerializerMAnager serializerMAnager = new SerializerMAnager(Serializers.JSON);
            Console.WriteLine(serializerMAnager.Serialize("Fermat"));

            serializerMAnager.SetSerializer(Serializers.XML);
            Console.WriteLine(serializerMAnager.Deserialize("kjwbckjsbcw"));

            Console.ReadKey();
        }
    }
}
