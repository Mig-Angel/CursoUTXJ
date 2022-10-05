using Dev.Business.IBusiness;
using Dev.Model.Response;
using Dev.Enum.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        IProductoBusiness productoBusiness;

        public ProductosController(IProductoBusiness _producto)
        {
            productoBusiness = _producto;
        }

        [HttpGet]
        public ResponseModel<object> getProductos()
        {
            return productoBusiness.getProductos();
        }

        [HttpGet]
        [Route("{id:int:min(1)}")]
        public ResponseModel<object> TestMaskedURLParameter(int id)
        {
            return new ResponseModel<object>()
            {
                Code = StatusCodeEnum.Ok,
                Message = "Ok",
                Result = id
            };
        }

        [HttpGet]
        [Route("{year:int:min(1900)}/{month}")]
        public ResponseModel<object> TestMaskedURLParameter(int year, string month)
        {
            return new ResponseModel<object>() { 
                Code = StatusCodeEnum.Ok,
                Message = "Ok",
                Result = new { 
                    Year = year,
                    Month = month,
                }
            };
        }
    }
}
