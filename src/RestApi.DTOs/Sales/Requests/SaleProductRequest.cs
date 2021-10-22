using RestApi.DTOs.Sales.Common;

namespace RestApi.DTOs.Sales.Requests
{
    public class SaleProductRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public SaleInfo SaleInfo { get; set; }
    }
}
