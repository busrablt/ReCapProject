using Core.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Results.Concreate
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool success, string message):base(success,message)
        {
            Data = data;
        }

        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
