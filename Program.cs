using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001DelegateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryOfCar car = new FactoryOfCar(5, "Sedan", "Red");
            car.RegisterHandler(new FactoryOfCar.CarHandler(Show));
            car.Sell(4);
            car.Sell(2);
            car.Sell(1);
            Console.ReadLine();
        }

        private static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
