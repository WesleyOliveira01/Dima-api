using System.Text.Json.Serialization;

namespace Dima.core.Responses;

public class Response<T>
{
    private readonly int _code;

    [JsonConstructor]
    public Response() => _code = Configuration.DefaultStatusCode;

    public Response(T? data, int code = 200, string? message = null)
    {
        Data = data;
        Message = message;
        _code = code;
    }

    public T? Data { get; set; }
    public string? Message { get; set; } = string.Empty;

    [JsonIgnore]
    public bool IsSuccess => _code >= 200 && _code <= 299;
}

