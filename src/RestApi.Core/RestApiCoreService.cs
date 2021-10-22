using RestApi.Core.ApplicationServices;
using RestApi.DTOs.Sales.Requests;
using RestApi.DTOs.Sales.Responses;

namespace RestApi.Core
{
    public class RestApiCoreService
    {
        public SaleProductResponse SaleProduct(SaleProductRequest request)
        {
            var service = new RestApiAplicationService();
            return service.SaleProduct(request);
        }
    }
}
