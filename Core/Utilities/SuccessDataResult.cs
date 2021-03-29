using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
   public class SuccessDataResult<T>:DataResult<T>
    {
        //işlem sonucu default true
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        //sadece mesaj
        public SuccessDataResult(string message) : base(default, true, message)
        {

        }
        //hiçbir şey vermedik.
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
