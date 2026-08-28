namespace BackEndApi.Services
{
    public interface IAiService
    {
        Task<string> AskAsync(string question);
    }
}
