using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success)//:this(success) Result'ın tek parametreli olan Constructor'ına success yolla demek bu kodla aşağıdaki Constructor'da çalışır.2 parametreli gönderirsen otomatik olacak aşağıdaki Constructor'da çalışır.
        {
            Message = message;
        }

        public Result(bool success)//Yapıcı metot'u overload ettik sadece işlem başarılımı değilmi diye kontrol etmek istersek bunu kullanacağız.
        {
            Success = success;
        }


        public bool Success { get; }

        public string Message { get; }
    }
}
