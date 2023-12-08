using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class CarUI
    {
        public void ShowMessage(object? sender, CarEventArgs args)
        {
            Console.WriteLine(args.EventMessage);
            
        }
        public void ShowWarningMessage(object? sender, CarEventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Warning! {args.EventMessage}");
            Console.ResetColor();
        }
    }
}
