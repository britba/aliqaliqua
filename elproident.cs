using System.Threading.Tasks;

public interface IAsyncPostMethod2 {
    // Asynchronously sends a POST request
    Task<HttpResponseMessage> SendPostRequestAsync(string url, string payload);

    // Handles the response from the asynchronous POST request
    void HandleResponse(HttpResponseMessage response);
}
