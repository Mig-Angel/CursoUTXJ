using Dev.Business.IBusiness;
using Dev.Enum.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        IProductoBusiness productoBusiness;

        public ProductosController(IProductoBusiness _producto)
        {
            productoBusiness = _producto;
        }
        [HttpGet, Route("getProductos")]
        public Response<object> getProductos()
        {
            return productoBusiness.getProductos();
        }
    }
}
