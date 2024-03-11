using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset_Mangment;

namespace Asset_Managment
{
    public class AssetManager
    {
        Book book = new Book();
        SoftwareLicense softwareLicense = new SoftwareLicense();
        Hardware hardware = new Hardware();

        

        public void AddAsset()
        {
            Console.WriteLine("What You Want TO Add.");
            Console.WriteLine("1.Books");
            Console.WriteLine("2.Software Licence");
            Console.WriteLine("3.Hardware");

            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    book.addbook();
                    break;

                case "2":
                     softwareLicense.addsoftwarelicense();
                    break;

                case "3":
                    hardware.addhardware();
                    break;  
            }            
        }

        public void Listofassets()
        {
            Console.WriteLine("Books:");
            book.listofbook();
            Console.WriteLine();
            Console.WriteLine("Software License:");
            softwareLicense.listofsoftwareLicense();
            Console.WriteLine();
            Console.WriteLine("Hardware:");
            hardware.listofhardware();
            Console.WriteLine();
        }

        public void searchofasset()
        {
            book.searchbook();
            softwareLicense.searchsoftwarelicense();
            hardware.searchHardware();
        }

        public void updateofassets()
        {
            book.updatebook();
            hardware.updatehardware();
            softwareLicense.updatesoftwareLicenses();
        }

        public void deleteasset()
        {
            book.deletebook();
            hardware.deletehardware();
            softwareLicense.deleteSoftwarelicense();
        }
    }
}
