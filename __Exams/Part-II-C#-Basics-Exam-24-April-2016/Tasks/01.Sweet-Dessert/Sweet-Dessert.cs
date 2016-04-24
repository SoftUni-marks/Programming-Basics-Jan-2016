using System;

public class SweetDessert
{
    private static void Main()
    {
        decimal amountOfCash = decimal.Parse(Console.ReadLine());

        int numberOfGuests = int.Parse(Console.ReadLine());

        decimal priceOfBananas = decimal.Parse(Console.ReadLine());
        decimal priceOfEggs = decimal.Parse(Console.ReadLine());
        decimal priceOfBerries = decimal.Parse(Console.ReadLine());

        int portions = numberOfGuests % 6 == 0 ? numberOfGuests / 6 : (numberOfGuests / 6) + 1;

        decimal price = portions * ((2 * priceOfBananas) + (4 * priceOfEggs) + (0.2M * priceOfBerries));

        if (price <= amountOfCash)
        {
            Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", price);
        }
        else
        {
            Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", price - amountOfCash);
        }
    }
}
