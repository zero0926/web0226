using WebApplication0226.Models;

namespace WebApplication0226.Services;

public class memeService
{
    public List<memeM> List()
    {
        List<memeM> result = new List<memeM>();
        try
        {
            HttpClient client = new HttpClient();
            
            HttpResponseMessage response = await client.GetAsync("https://meme.tw/wtf/api");
            if (response.IsSuccessStatusCode)
            {
                result = await response.Content.ReadFromJsonAsync<List<memeM>>();
            }
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }

        return result;
    }
}