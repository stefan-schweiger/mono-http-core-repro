public class Program
{
    public static void Main(string[] args)
    {
        var result = new System.Net.Http.HttpClient()
            .GetAsync("https://api.ipify.org/?format=json").Result;
    }
}
