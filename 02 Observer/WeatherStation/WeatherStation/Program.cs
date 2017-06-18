using WeatherStation.Implementations;

using static System.Console;

namespace WeatherStation
{
    class WeatherStationConsole
    {
        static void Main(string[] args)
        {
            // Erzeuge Publisher:
            WeatherData weatherData = new WeatherData();

            // Erzeuge Anzeige:
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            // Simuliere die Verfügbarkeit neuer Meswerte:
            weatherData.setMeasurements(15.0f, 44.2f, 1020.0f);
            weatherData.setMeasurements(16.5f, 48.9f, 1015.0f);
            weatherData.setMeasurements(16.2f, 47.3f, 1025.0f);

            // Halte Konsolenfenster offen:
            ReadLine();

        } // Main.

    } // class WeatherStationConsole.

} // namespace WeatherStation.