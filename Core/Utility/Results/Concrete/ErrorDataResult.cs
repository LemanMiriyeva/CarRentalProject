﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utility.Results.Concrete
{
    class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {
        }

        public ErrorDataResult(T data) : base(data, false)
        {
        }

        public ErrorDataResult() : base(default, false)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }
    }
}
