using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class CarParkCharge 
    {
       public int minimufee { get; set; }
        public int minimumHours { get; set; }
        public CarParkCharge(int _minimufee = 2, int _minimumHours=3)
        {
            Console.WriteLine("I am the carparkcharge");
            minimufee = _minimufee;
            minimumHours = _minimumHours;
        }
        public override string ToString()
        {
            return "I am the carparkcharge";
        }

        public int CalculateCharge(int hoursParked)
        {
           
            int calculatedfee = hoursParked < minimumHours ? minimufee : hoursParked * minimufee;
            return calculatedfee;
        }
    }
}
