using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
    public class WeatherStation
    {
        public WeatherStation()
        {
            WeatherData weatherdata = new WeatherData();
            ConcurrentDisplay concurrentDisplay = new ConcurrentDisplay(weatherdata);
            ForcastDisplay forcastDisplay = new ForcastDisplay(weatherdata);

            weatherdata.setMeasurements(80, 65, 30);

            weatherdata.Unregister(forcastDisplay);
            weatherdata.setMeasurements(70, 42, 53);

            Console.ReadLine();
        }
     
    }
}
