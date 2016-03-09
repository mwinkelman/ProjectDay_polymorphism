using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_polymorphism
{
    class DVD:Resource
    {
        public override void ViewTitle()
        {
            string availability = "";
            if (Status == 0)
                availability = "Checked Out";
            if (Status == 1)
                availability = "Available";

            Console.WriteLine($"Title: {Title}\nISBN: {ISBN}\nLength: {Length} Minutes\nStatus: {availability}");
        }
        public override void AddTitle()
        {
            Console.WriteLine("Enter the Title of the resource you are adding: ");
            Title = Console.ReadLine();
            Console.WriteLine("Enter the ISBN of the resource you are adding: ");
            ISBN = Console.ReadLine();
            Console.WriteLine("Enter the length, in minutes, of the resource you are adding: ");
            int pages;
            bool valid = int.TryParse(Console.ReadLine(), out pages);
            Length = pages;
            Status = 1;
        }
    }
}
