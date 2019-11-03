using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirst
{
   public  class WeatherData:ISubject
    {
        List<IObserver> observers;
        float temperature;
        float humidity;
        float pressure;

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void Notify()
        {
            foreach(var observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void Register(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Unregister(IObserver observer)
        {
            observers.Remove(observer);
        }

         void measurementChanged()
        {
            Notify();
        }
        public void setMeasurements(float temp, float humidity,float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementChanged();
        }
    }
}
