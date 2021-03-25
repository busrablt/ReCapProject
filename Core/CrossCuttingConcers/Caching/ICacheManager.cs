using System;
using System.Collections.Generic;
using System.Text;

namespace Core.CrossCuttingConcers.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration); //Object is the base of all data types.
        bool IsAdd(string key); 
        void Remove(string key);
        void RemoveByPattern(string key);
    }
}
