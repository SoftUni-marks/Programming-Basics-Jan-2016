using System;
using System.Linq;

public class Nacepin
{
    private static void Main()
    {
        string[] storeNames = new string[]
        {
            "US",
            "UK",
            "Chinese"
        };

        /*
         * Currency Rates:
         * 
         * 1 BGN = 0.58 USD
         * 1 BGN = 0.41 GBP
         * 0.27 BGN = 1 CNY
         */

        decimal bgnPerUsd = 1 / 0.58M;
        decimal bgnPerGbp = 1 / 0.41M;
        decimal bgnPerCny = 0.27M;

        // 0 -> US store, 1 -> UK store, 2 -> Chinese store
        decimal[] pricesPerKgInLv = new decimal[3];

        decimal priceUsStore = decimal.Parse(Console.ReadLine());
        uint boxWeightUsStore = uint.Parse(Console.ReadLine());
        pricesPerKgInLv[0] = (priceUsStore / boxWeightUsStore) * bgnPerUsd;

        decimal priceUkStore = decimal.Parse(Console.ReadLine());
        uint boxWeightUkStore = uint.Parse(Console.ReadLine());
        pricesPerKgInLv[1] = (priceUkStore / boxWeightUkStore) * bgnPerGbp;

        decimal priceChineseStore = decimal.Parse(Console.ReadLine());
        uint boxWeightChineseStore = uint.Parse(Console.ReadLine());
        pricesPerKgInLv[2] = (priceChineseStore / boxWeightChineseStore) * bgnPerCny;

        decimal lowestPricePerKgInLv = pricesPerKgInLv.Min();
        decimal highestPricePerKgInLv = pricesPerKgInLv.Max();

        int idxOfStoreWithMinPrice = Array.IndexOf(pricesPerKgInLv, lowestPricePerKgInLv);

        Console.WriteLine("{0} store. {1:F2} lv/kg", storeNames[idxOfStoreWithMinPrice], lowestPricePerKgInLv);
        Console.WriteLine("Difference {0:F2} lv/kg", highestPricePerKgInLv - lowestPricePerKgInLv);
    }
}
