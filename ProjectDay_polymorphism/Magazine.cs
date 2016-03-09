﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDay_polymorphism
{
    class Magazine:Resource
    {
        public override void CheckOut()
        {
            DateTime checkout = DateTime.Now;
            Status = 0;
            DateTime dueDate = checkout.AddDays(2);
            Console.WriteLine($"{Title} has been checked out. It is due back on {dueDate}.");
        }
    }
}
