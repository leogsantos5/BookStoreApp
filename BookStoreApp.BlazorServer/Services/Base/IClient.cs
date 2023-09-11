namespace BookStoreApp.BlazorServer.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
