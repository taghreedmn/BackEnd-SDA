using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.Utils
{
    public class CustomException: Exception
    {
        public int statusCode { get; set; }

        public CustomException(int StatusCode, string message): base(message)
        {
            StatusCode = statusCode;
        }

        //
    }
}