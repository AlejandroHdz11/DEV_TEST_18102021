using RestApi.Core;
using RestApi.DTOs.Sales.Requests;
using RestApi.DTOs.Sales.Responses;
using Swashbuckle.Swagger.Annotations;
using System.Web.Http;

namespace RestApi.Controllers
{
    [RoutePrefix("Sales")]
    public class SalesController : ApiController
    {
        [HttpPost]
        [Route("SaleProduct")]
        [SwaggerResponse(200, Type = typeof(SaleProductResponse), Description = "Sale Product")]
        public SaleProductResponse SaleProduct(SaleProductRequest request)
        {
            var service = new RestApiCoreService();
            return service.SaleProduct(request);
        }
    }
}
