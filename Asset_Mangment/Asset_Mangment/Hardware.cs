using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Asset_Managment;

namespace Asset_Mangment
{
    public class Hardware 
    {
        List<Hardware> hardware = new List<Hardware>();

        public string Serialnumber;

        public string Name;

        public DateTime Dateofissue;

        public Hardware() { }

        public Hardware(string serialnumber, string name, DateTime dateofissue)
        {
            this.Serialnumber = serialnumber;
            this.Name = name;
            this.Dateofissue = dateofissue;
        }

        public void addhardware() 
        {            
            Console.WriteLine("Enter The Serial Number:");
            string serialnumber = Console.ReadLine();

            Console.WriteLine("Enter The Name Of Hardware:");
            string name = Console.ReadLine();
                        
            Console.WriteLine("Enter the Date of issue:");
            DateTime dateofissue = DateTime.Parse(Console.ReadLine());

            hardware.Add(new Hardware(serialnumber, name, dateofissue));

            Console.WriteLine("Hardware is successfully Added.");
            Console.ReadLine();
        }

        public void listofhardware()
        {
            for (int i = 0; i < hardware.Count(); i++)
            {
                Console.WriteLine($"{hardware[i].Serialnumber},{hardware[i].Name} , {hardware[i].Dateofissue}");
            }
        }

        public void searchHardware()
        {
            Console.WriteLine("Enter the serial number:-");
            string serialnumbertosearch = Console.ReadLine();

            for (int i = 0; i < hardware.Count; i++)
            {
                if (hardware[i].Serialnumber == serialnumbertosearch)
                {
                    Console.WriteLine($"Hardware found successfully - serial number: {hardware[i].Serialnumber}, Name : {hardware[i].Name}, Date of issue : {hardware[i].Dateofissue}");
                    return;
                }
                else
                {
                    Console.WriteLine("Asset not found :");
                }
            }
        }
                
        public void updatehardware()
        {
            Console.WriteLine("Enter the serial number of asset :");
            string serialnumbertoupdate = Console.ReadLine();

            Hardware hardwaretoupdate = hardware.Find(hardware => hardware.Serialnumber == serialnumbertoupdate);
            if (hardwaretoupdate != null)
            {
                Console.WriteLine("Enter the New Update Name :");
                string newname = Console.ReadLine();

                hardwaretoupdate.Name = newname;
                                
                Console.WriteLine("Enter The New Date Of Issue");
                DateTime newdateofissue = DateTime.Parse(Console.ReadLine());

                hardwaretoupdate.Dateofissue = newdateofissue;

                Console.WriteLine("Hardware updated successfully :-");
            }
        }

        public void deletehardware()
        {
            Console.WriteLine("Enter the serial number of delete asset");
            string serialnumbertodelete = Console.ReadLine();

            Hardware hardwaretodelete = hardware.Find(hardware => hardware.Serialnumber == serialnumbertodelete);

            hardware.Remove(hardwaretodelete);

            Console.WriteLine("Asset was Deleted successfully");
        }
    }
}
