using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001DelegateApp
{
    public class FactoryOfCar
    {
        public delegate void CarHandler(string message);
        CarHandler _carHandler;
        public void RegisterHandler(CarHandler carHandler)
        {
            _carHandler = carHandler;
        }

        int _count;
        string CarName { get; set; }
        string CarColor { get; set; }
        public FactoryOfCar(int count,string carName,string carColor)
        {
            _count = count;
            CarColor = carColor;
            CarName = carName;
        }
        public int CurrentCount
        {
            get { return _count; }
        }
        public void Add(int count,string carName,string carColor)
        {
            if (carName!=null && carColor!=null)
            {
                _count += count;
            }
        }
        public void Sell(int count)
        {
            if (count<=_count)
            {
                _count -= count;
                if (_carHandler!=null)
                {
                    _carHandler($"The number of cars sold is : {count}");
                }
            }
            else
            {
                if (_carHandler!=null)
                {
                    _carHandler($"There is no car in warehouse");
                }
            }
        }
        
    }
}
