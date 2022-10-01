using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Enum.Response
{
    /// <summary>
    /// Enum general para las respuestas a los 
    /// Endpoints del API
    /// </summary>
    public enum StatusCodeEnum
    {
        Ok = 200,
        Found = 302,
        Bad_Request = 400,
        Unauthorized = 401,
        Not_Found = 404
    }
}
