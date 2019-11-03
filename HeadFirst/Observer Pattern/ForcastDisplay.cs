using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public class ForcastDisplay : IDisplay, IObserver
    {
        float temperature;
        float humidity;
        float pressure;
        WeatherData weatherData;

        public ForcastDisplay(WeatherData weatherdatas)
        {
            this.weatherData = weatherdatas;
            weatherdatas.Register(this);
        }
       
        public void display()
        {
            Console.WriteLine("This is ForcastDisplayObserver-------" +
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
