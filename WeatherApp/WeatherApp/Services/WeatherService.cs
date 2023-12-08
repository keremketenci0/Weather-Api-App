using Newtonsoft.Json;

namespace WeatherApp
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;

        public WeatherService()
        {
            _httpClient = new HttpClient();
        }

        public async Task GetWeather(string city)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"https://goweather.herokuapp.com/weather/{city}");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                Weather weather = JsonConvert.DeserializeObject<Weather>(responseBody);

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"*** {city.ToUpper()} Weather ***");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Temperature: {weather.Temperature}");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Wind: {weather.Wind}");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Description: {weather.Description}");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Forecast:");
                

                foreach (var forecast in weather.Forecast)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write($"Day: {forecast.Day}, ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"Temperature: {forecast.Temperature}, ");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"Wind: {forecast.Wind}");
                    Console.WriteLine();

                }
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"An error occurred while fetching {city} weather data: {e.Message}");
            }
        }
    }
}
