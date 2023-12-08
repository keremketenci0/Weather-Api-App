namespace WeatherApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var weatherService = new WeatherService();
            await weatherService.GetWeather("istanbul");
            await weatherService.GetWeather("izmir");
            await weatherService.GetWeather("ankara");
        }
    }
}
