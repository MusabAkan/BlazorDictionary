namespace BlazorDictionary.Common.Models.Responsies
{
    public class Response
    {
        public string? Message { get; set; }
        public Response() { }
        public Response(string message) => Message = message;
    }
}