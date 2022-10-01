using Dev.Enum.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Business.IBusiness
{
    public interface IProductoBusiness
    {
        Response<object> getProductos();
    }
}
