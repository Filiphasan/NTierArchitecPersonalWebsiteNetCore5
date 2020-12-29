using System;
using System.Collections.Generic;
using System.Text;

namespace MyWebApp.Shared.Utilities.Abstract
{
    public interface IDataResult<out T> : IResult
    {
        public T Data { get; }
    }
}
