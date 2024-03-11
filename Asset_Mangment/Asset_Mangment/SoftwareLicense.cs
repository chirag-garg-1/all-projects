using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Mangment
{
    public class SoftwareLicense
    {
        List<SoftwareLicense> softwareLicenses = new List<SoftwareLicense>();

        public string Serialnumber;

        public string Name;

        public string Model;

        public DateTime Dateofissue;

        public SoftwareLicense() { }

        public SoftwareLicense(string serialnumber,string name, string model, DateTime dateofissue)
        {
            this.Serialnumber = serialnumber;
            this.Name = name;
            Model = model;
            Dateofissue = dateofissue;
        }

        public void addsoftwarelicense()
        {
            Console.WriteLine("Enter The Serial Number:");
            string serialnumber = Console.ReadLine();

            Console.WriteLine("Enter The Name Of Software:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter The Model No:");
            string model = Console.ReadLine();

            Console.WriteLine("Enter the Date of issue:");
            DateTime dateofissue = DateTime.Parse(Console.ReadLine()).Date;

            softwareLicenses.Add(new SoftwareLicense(serialnumber,name, model, dateofissue));

            Console.WriteLine("SoftwareLicence is successfully Added.");
            Console.ReadLine();
        }

        public void listofsoftwareLicense()
        {
            for (int i = 0; i < softwareLicenses.Count(); i++)
            {
                Console.WriteLine($"{softwareLicenses[i].Serialnumber} {softwareLicenses[i].Name} {softwareLicenses[i].Model} {softwareLicenses[i].Dateofissue}");
            }
        }
        public void searchsoftwarelicense()
        {
            Console.WriteLine("Enter the serial number:-");
            string serialnumbertosearch = Console.ReadLine();

            for (int i = 0; i < softwareLicenses.Count; i++)
            {
                if (softwareLicenses[i].Serialnumber == serialnumbertosearch)
                {
                    Console.WriteLine($"SoftwareLicense found successfully - serial number: {softwareLicenses[i].Serialnumber}, Name : {softwareLicenses[i].Name}, Model : {softwareLicenses[i].Model}, Dateofissue : {softwareLicenses[i].Dateofissue.Date}");
                    return;
                }
                else
                {
                    Console.WriteLine("Asset not found :");
                }
            }
        }

        public void updatesoftwareLicenses()
        {
            Console.WriteLine("Enter the serial number of asset :");
            string serialnumbertoupdate = Console.ReadLine();

            SoftwareLicense softwarelicensetoupdate = softwareLicenses.Find(softwareLicenses => softwareLicenses.Serialnumber == serialnumbertoupdate);
            if (softwarelicensetoupdate != null)
            {
                Console.WriteLine("Enter the New Update Name :");
                string newname = Console.ReadLine();

                softwarelicensetoupdate.Name = newname;

                Console.WriteLine("Enter The New Date Of Issue");
                DateTime newdateofissue = DateTime.Parse(Console.ReadLine());

                softwarelicensetoupdate.Dateofissue = newdateofissue;

                Console.WriteLine("softwarelicense updated successfully :-");
            }
        }

        public void deleteSoftwarelicense()
        {
            Console.WriteLine("Enter the serial number of delete asset");
            string serialnumbertodelete = Console.ReadLine();

            SoftwareLicense Softwarelicensetodelete = softwareLicenses.Find(softwareLicenses => softwareLicenses.Serialnumber == serialnumbertodelete);

            softwareLicenses.Remove(Softwarelicensetodelete);

            Console.WriteLine("Asset was Deleted successfully");
        }
    }
}
