namespace RestApi.DTOs.Common
{
    public interface IBasicResponse
    {
        string ReturnCode { get; set; }

        string Message { get; set; }

        string Description { get; set; }
    }
}
