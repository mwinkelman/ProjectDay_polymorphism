using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_polymorphism
{
    abstract class Resource
    {
        #region fields
        private string title;
        private string isbn;
        private int length;
        private int status;
        #endregion
        
        #region properties
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public int Length
        {
            get { return length; }
            set
            {
                if(value>0)
                    length = value;
                else
                    Console.WriteLine("Length must be greater than zero pages.");
            }
        }
        public int Status
        {
            get { return status; }
            set
            {
                if (value==0||value==1)
                    status = value;
                else
                    Console.WriteLine("Enter 1 for available or 0 for unavailable");
            }          
        }
        #endregion

        #region constructors
        public Resource()
        { }
        public Resource(string title, string isbn, int length, int status)
        {
            Title = title;
            ISBN = isbn;
            Length = length;
            Status = status;
        }
        #endregion

        #region method
        public virtual void ViewTitle()
        {
            string availability = "";
            if (Status == 0)
                availability = "Checked Out";
            if (Status == 1)
                availability = "Available";

            Console.WriteLine($"Title: {Title}\nISBN: {ISBN}\nLength: {Length} Pages\nStatus: {availability}");
        }
        public virtual void AddTitle()
        {
            Console.WriteLine("Enter the Title of the resource you are adding: ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the ISBN of the resource you are adding: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter the length, in pages, of the resource you are adding: ");
            Status = 1;
            int pages;
            bool valid = int.TryParse(Console.ReadLine(), out pages);
            if (valid)
                Length = pages;
            else
                Console.WriteLine("Not a valid length");
        }
        public virtual void CheckOut()
        {            
            DateTime checkout = DateTime.Now;
            Status = 0;
            DateTime dueDate = checkout.AddDays(3);
            Console.WriteLine($"{Title} has been checked out. It is due back on {dueDate}.");
        }
        public virtual void CheckIn()
        {
            Status = 1;
        }
        #endregion

    }
}
