using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asset_Mangment
{
    public class Book
    {
        List<Book> books = new List<Book>();

        public string Serialnumber;
        public string Name;
        public string Authorname;
        public DateTime Dateofissue;   
        public Book() { }
        public Book(string serialnumber, string name, string authorname, DateTime dateofissue)
        {
            this.Serialnumber = serialnumber;
            this.Name = name;
            this.Authorname = authorname;
            this.Dateofissue = dateofissue;
        }

        public void addbook() 
        {            
            Console.WriteLine("Enter the serial number:");
            string serialnumber = Console.ReadLine();

            Console.WriteLine("Enter the name of book:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the Author name:");
            string authorname = Console.ReadLine();

            Console.WriteLine("Enter the date of isuue");
            DateTime dateofissue = DateTime.Parse(Console.ReadLine());

            books.Add(new Book(serialnumber, name, authorname, dateofissue));

            Console.WriteLine("Book is successfully Added.");
            Console.ReadLine();
        }
        public void listofbook()
        {
            for (int i = 0; i < books.Count(); i++)
            {
                Console.WriteLine($"{books[i].Serialnumber} {books[i].Authorname} {books[i].Name} {books[i].Dateofissue}");
            }
        }

        public void searchbook()
        {
            Console.WriteLine("Enter the serial number:-");
            string serialnumbertosearch = Console.ReadLine();

           for (int i = 0;i < books.Count;i++)
           {
                if (books[i].Serialnumber == serialnumbertosearch)
                {
                    Console.WriteLine($"Book found successfully - serial number: {books[i].Serialnumber}, AuthorName: {books[i].Authorname}, Name: {books[i].Name}, dateof issue : {books[i].Dateofissue}");
                    return;
                }
                else
                {
                    Console.WriteLine("Asset not found :");
                }
            }
        }

        public void updatebook()
        {
            Console.WriteLine("Enter the serial number of asset :");
            string serialnumbertoupdate = Console.ReadLine();

            Book booktoupdate = books.Find(books => books.Serialnumber == serialnumbertoupdate);
            if (booktoupdate != null)
            {
                Console.WriteLine("Enter the New Update Name :");
                string newname = Console.ReadLine();

                booktoupdate.Name = newname;

                Console.WriteLine("Enter The New update Author Name:- ");
                string newauthorname = Console.ReadLine();

                booktoupdate.Authorname = newauthorname;

                Console.WriteLine("Enter The New Date Of Issue");
                DateTime newdateofissue = DateTime.Parse(Console.ReadLine());

                booktoupdate.Dateofissue = newdateofissue;

                Console.WriteLine("Book updated successfully :-");
            }
        }

        public void deletebook()
        {
            Console.WriteLine("Enter the serial number of delete asset");
            string serialnumbertodelete = Console.ReadLine();

            Book booktodelete = books.Find(books => books.Serialnumber == serialnumbertodelete);

            books.Remove(booktodelete);

            Console.WriteLine("Asset was Deleted successfully");
        }
    }      
}
