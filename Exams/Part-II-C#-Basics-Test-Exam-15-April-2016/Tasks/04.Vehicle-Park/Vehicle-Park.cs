using System;
using System.Collections.Generic;
using System.Linq;

public class VehiclePark
{
    public static string GetPrice(string vehicle)
    {
        char type = vehicle[0];

        int amountOfSeats = int.Parse(vehicle.Substring(1));

        return string.Empty + ((int)type * amountOfSeats);
    }

    private static void Main()
    {
        List<string> availableVehicles = new List<string>();

        int vehiclesSold = 0;

        string input = Console.ReadLine();

        // vehicles that are available for selling
        availableVehicles = input
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        string line;

        // list with vehicle requests
        List<string> requestedVehicles = new List<string>();

        // process a sequence of incoming requests
        while (!string.IsNullOrEmpty(line = Console.ReadLine()) && line != "End of customers!")
        {
            string[] items = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            char type = char.ToLower(items[0][0]);
            int amountOfSeats = int.Parse(items[2]);

            requestedVehicles.Add(string.Empty + type + amountOfSeats);
        }

        // iterate through buy requests
        foreach (var requestedVehicle in requestedVehicles)
        {
            if (availableVehicles.Contains(requestedVehicle))
            {
                Console.WriteLine("Yes, sold for {0}$", GetPrice(requestedVehicle));

                vehiclesSold++;

                availableVehicles.Remove(requestedVehicle);
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        Console.WriteLine("Vehicles left: {0}", string.Join(", ", availableVehicles));
        Console.WriteLine("Vehicles sold: {0}", vehiclesSold);
    }
}
