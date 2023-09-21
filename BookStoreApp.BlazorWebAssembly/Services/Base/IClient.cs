namespace BookStoreApp.BlazorWebAssembly.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
