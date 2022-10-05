using Dev.Business.IBusiness;
using Dev.Data.IRepository;
using Dev.Model.Response;
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

        public ResponseModel<object> getProductos()
        {
            ResponseModel<object> response = new ResponseModel<object>();
            try
            {
                response.Result = repository.GetList("sps_productos");
                response.Code = StatusCodeEnum.Ok;
                response.Message = "";
            }
            catch (Exception e)
            {
                response.Code = StatusCodeEnum.Bad_Request;
                response.Message = e.Message;
            }
            return response;
        }
    }
}
