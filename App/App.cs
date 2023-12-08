using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class App
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            CarUI carUI = new CarUI();
            car.OverSpeeding += carUI.ShowWarningMessage;
            car.CarEvent += carUI.ShowMessage;

            car.Move(10);
        }
    }
}
