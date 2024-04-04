﻿using FrontendCNE.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontendCNE.WebAPI
{
    public class ApiException : Exception
    {
        public ApiException()
        {
        }

        public ApiException(string message)
            : base(message)
        {
        }

        public ApiException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        public ApiException(IApiResult result)
            : base((result.Success ? "Successful" : "Unsuccessful") +
                  $" response type {result.Type} in API call {result.Path}: {result.Message}.")
        {

        }

    }
}

