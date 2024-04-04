﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FrontendCNE.WebAPI
{
    
        public interface IApiResult
        {
            public HttpStatusCode StatusCode { get; set; }
            public bool Success { get; }
            public ApiResultType Type { get; set; }
            public string Path { get; set; }
            public string Message { get; set; }
        }

        public class ApiResult<T> : IApiResult
        {
            public HttpStatusCode StatusCode { get; set; }

            public bool Success { get; set; }

            public ApiResultType Type { get; set; }

            public T Data { get; set; }
            //public object Data { get; set; }

            public string Path { get; set; }

            public string Message { get; set; }

            public ApiResult()
            {
                Type = ApiResultType.Error;
            }

            public ApiResult<T> SetMessage(string message, ApiResultType type)
            {
                Message = message;
                Type = type;
                return this;
            }

        }


        public class RequestCode
        {
            public HttpStatusCode StatusCode { get; set; }

            public bool Success { get; set; }

            public ApiResultType Type { get; set; }

            public int Data { get; set; }
            //public object Data { get; set; }

            public string Path { get; set; }

            public string Message { get; set; }
        }


        public class ApiResult : IApiResult
        {
            public HttpStatusCode StatusCode { get; set; }

            public bool Success { get; set; }

            public ApiResultType Type { get; set; }

            public string Path { get; set; }

            public string Message { get; set; }

            public ApiResult()
            {
                Type = ApiResultType.Error;
            }

            public ApiResult SetMessage(string message, ApiResultType type)
            {
                Message = message;
                Type = type;
                return this;
            }

        }

        public enum ApiResultType
        {
            Success,
            Info,
            Warning,
            Error,
            NotFound,
            BadRequest,
            InvalidCredentials,
            Conflict,
            Disabled
        }
    }

