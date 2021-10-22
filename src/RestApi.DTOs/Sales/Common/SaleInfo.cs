namespace RestApi.DTOs.Sales.Common
{
    public class SaleInfo
    {
        public int ProductId { get; set; }
        public decimal QuantitySold { get; set; }
        public string OperatorCode { get; set; }
        public string Note { get; set; }
    }
}
