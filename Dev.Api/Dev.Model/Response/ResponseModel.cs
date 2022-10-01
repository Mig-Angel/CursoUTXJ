using Dev.Enum.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Model.Response
{
    /// <summary>
    /// Clase general para las respuestas a los 
    /// Endpoints del API
    /// </summary>
    /// <typeparam name="T">Clase del objeto se almacenara</typeparam>
    public class ResponseModel<T>
    {
        public StatusCodeEnum Code { get; set; }
        public string Message { get; set; }
        public T Result { get; set; }

    }
}
