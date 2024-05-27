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
            client.GetAsync("")
                
            Product product = null;
            HttpResponseMessage response = await client.GetAsync(path);
            if (response.IsSuccessStatusCode)
            {
                product = await response.Content.ReadAsAsync<List<memeM>>();
            }
            return product;
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
            throw;
        }
        return result;
    }
}