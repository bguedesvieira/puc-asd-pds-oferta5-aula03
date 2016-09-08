using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityServicesApi.ApiException
{
    public class CityServiceException : System.Exception
    {
        public int ExceptionCode { get; set; }
        public string DeveloperMessage { get; set; }

        override
        public string Message { get; }

        public CityServiceException()
        {
        }

        public CityServiceException(int code, string message)
        {
            this.ExceptionCode = code;
            Message = message;
        }

        public CityServiceException(int code, string message, string developerMessagge)
            : this (code, message)
        {
            
            DeveloperMessage = developerMessagge;
        }

    }
}
