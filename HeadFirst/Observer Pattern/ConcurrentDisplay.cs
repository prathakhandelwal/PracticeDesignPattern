using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public class ConcurrentDisplay : IObserver, IDisplay
    {
         float temperature;
         float humidity;
         float pressure;
         WeatherData weatherData;

        public ConcurrentDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.Register(this);
        }
        public void display()
        {
            Console.WriteLine("This is ConcurrentObserver-------" +
                "Humidity:" + this.humidity + "% Temperature: " + this.temperature + "F degree Pressure: " + this.pressure);
        }

        public void update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }
    }
}
