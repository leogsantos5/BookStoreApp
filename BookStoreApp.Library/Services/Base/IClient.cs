namespace BookStoreApp.Library.Services.Base
{
    public partial interface IClient
    {
        public HttpClient HttpClient { get; }
    }
}
