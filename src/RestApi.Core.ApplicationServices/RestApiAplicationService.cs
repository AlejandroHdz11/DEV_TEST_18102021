using RestApi.DTOs.Sales.Requests;
using RestApi.DTOs.Sales.Responses;
using System;

namespace RestApi.Core.ApplicationServices
{
    public class RestApiAplicationService
    {
        public SaleProductResponse SaleProduct(SaleProductRequest request)
        {
            try
            {
                return (new SaleProductResponse
                {
                    ReturnCode = "1000",
                    Message = "Operation Succesfully Completed"
                });
            }
            catch (Exception e)
            {
                return (new SaleProductResponse
                {
                    ReturnCode = "9999",
                    Message = "A general system error occurred. Please try again later. If the problem persits please contact customer service 1800 555 6 555",
                    Description = e.ToString()

                });

            }
        }
    }
}
