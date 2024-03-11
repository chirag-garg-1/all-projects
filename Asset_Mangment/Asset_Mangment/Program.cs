using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Asset_Mangment;

namespace Asset_Managment
{
    public enum AssetType
    {
        AddAsset = 1,
        SearchAsset = 2,
        UpdateAsset = 3,
        DeleteAsset = 4,
        ListAsset = 5,
        Exit = 6
    }

    public class Program
    {
        static void Main(string[] args)
        {
            AssetManager assetManager = new AssetManager();

            while (true)
            {
                Console.WriteLine("Welcome to Asset Management System");
                Console.WriteLine();
                Console.WriteLine("Please select your choice:");
                Console.WriteLine("1. Add an Asset");
                Console.WriteLine("2. Search an Asset");
                Console.WriteLine("3. Update an Asset");
                Console.WriteLine("4. Delete an Asset");
                Console.WriteLine("5. List all available Assets");
                Console.WriteLine("6. Exit");
                Console.WriteLine();
                Console.Write("Enter your choice: ");
                                
                if (!Enum.TryParse(Console.ReadLine(), out AssetType choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 6.");
                    continue;
                }
                                
                switch (choice)
                {
                    case AssetType.AddAsset:
                        assetManager.AddAsset();
                        break;

                    case AssetType.SearchAsset:
                        assetManager.searchofasset();
                        break;

                    case AssetType.UpdateAsset:
                        assetManager.updateofassets();
                        break;

                    case AssetType.DeleteAsset:
                        assetManager.deleteasset();
                        break;

                    case AssetType.ListAsset:
                        assetManager.Listofassets();
                        break;

                    case AssetType.Exit:
                        Console.WriteLine("Exiting the program...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please select a valid option.");
                        break;
                }

                Console.WriteLine(); 
            }
        }
    }
}
