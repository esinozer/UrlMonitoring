﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public T Data { get; }
        public DataResult(T data, bool succsess, string message) : base(succsess, message)
        {
            Data = data;
        }
        public DataResult(T data, bool succsess) : base(succsess)
        {
            Data = data;
        }
    }
}
