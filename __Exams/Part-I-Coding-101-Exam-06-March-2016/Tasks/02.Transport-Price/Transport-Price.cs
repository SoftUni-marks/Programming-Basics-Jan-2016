using System;

public class TransportPrice
{
    private static void Main()
    {
        var km = int.Parse(Console.ReadLine());
        var dayOrNight = Console.ReadLine().ToLower();

        var priceTaxi = double.MaxValue;
        var priceBus = double.MaxValue;
        var priceTrain = double.MaxValue;

        if (dayOrNight == "day")
        {
            priceTaxi = 0.70 + (0.79 * km);
        }
        else
        {
            priceTaxi = 0.70 + (0.90 * km);
        }

        if (km >= 20.0)
        {
            priceBus = 0.09 * km;
        }

        if (km >= 100.0)
        {
            priceTrain = 0.06 * km;
        }

        double minPrice = priceTaxi;

        if (priceBus < minPrice)
        {
            minPrice = priceBus;
        }

        if (priceTrain < minPrice)
        {
            minPrice = priceTrain;
        }

        Console.WriteLine("{0}", minPrice);
    }
}
