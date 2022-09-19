using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Strategy
{
    public interface ISerialize<T> where T : class
    {
        string Serialize(T data);
        T Deserialize(string serializedData);
    }
}
