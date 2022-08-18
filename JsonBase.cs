using System.Text.Json
using System.Collections.Generic;


namespace ConsoleApp1
{
    internal class JsonBase
    {
        public List<Project> Projects { get; set; }
        public void WriteJson(List<Project> Projects) 
        {
            string fileName = "WeatherForecast.json";
            string jsonString = JsonSerializer.Serialize(weatherForecast);
            File.WriteAllText(fileName, jsonString);

        }
    }
}
