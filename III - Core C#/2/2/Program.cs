using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Input distance in meters:");
        double distanceMeters = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input time - hours:");
        double timeHours = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input time - minutes:");
        double timeMinutes = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Input time - seconds:");
        double timeSeconds = Convert.ToDouble(Console.ReadLine());

        double totalTimeSeconds = (timeHours * 3600) + (timeMinutes * 60) + timeSeconds;
        double speedMeterSec = distanceMeters / totalTimeSeconds;
        double speedKmHr = (distanceMeters / 1000.0) / (totalTimeSeconds / 3600.0);
        double speedMilesHr = speedKmHr / 1.609;

        Console.WriteLine($"Your speed in meters/sec is {speedMeterSec}");
        Console.WriteLine($"Your speed in km/h is {speedKmHr}");
        Console.WriteLine($"Your speed in miles/h is {speedMilesHr}");
    }
}
