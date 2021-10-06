using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_lesson_4_parking.Models
{
    public class CarPark 
    {

        public List<Customer> listOfCustomers = new List<Customer>();
        public CarParkCharge CarParkCharge = new CarParkCharge();
        public CarPark()
        {
            Console.WriteLine("I am the carpark");  //ctro double tab
        }
        public override string ToString()
        {
            return "I am the carpark";
        }

        public void CalculateCharges()
        {
            foreach(Customer customer in listOfCustomers)
            {
                int calculatedCharge = CarParkCharge.CalculateCharge(customer.hoursParked);
                Console.WriteLine($"Calculating charge for customers : cost is {calculatedCharge} for registration {customer.Registration}");
            }
        }
    }
}
