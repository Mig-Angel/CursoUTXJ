using Dev.Business.IBusiness;
using Dev.Data.IRepository;
using Dev.Enum.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.Business
{
    public class ProductoBusiness : IProductoBusiness
    {
        IGeneralRepository<object> repository;

        public ProductoBusiness(IGeneralRepository<object> _repository)
        {
            repository = _repository;
        }

        public Response<object> getProductos()
        {
            Response<object> response = new Response<object>();
            try
            {
                response.Result = repository.GetList("sps_productos");
                response.Code = StatusCodeEnum.Ok;
                response.Menssage = "";
            }
            catch (Exception e)
            {
                response.Code = StatusCodeEnum.Bad_Request;
                response.Menssage = e.Message;
            }
            return response;
        }
    }
}
