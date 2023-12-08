using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Car
    {
        public int MaxPermissibleSpeed { get; set; } = 60;
        public int CurrentSpeed { get; set; } = 0;
        public Car() { }
        public event EventHandler<CarEventArgs> OverSpeeding;
        public event EventHandler<CarEventArgs> CarEvent;

        private void StartMoving() 
        {
            OnCarEvent("Your car has started moving!");               
        }

        public void Move(int timeSeconds)
        {
            StartMoving();
            do
            {
                CurrentSpeed += 10;
                OnCarEvent($"Your speed is: {CurrentSpeed}");
                Thread.Sleep(1000);
                timeSeconds -= 1;

                if (CurrentSpeed >= MaxPermissibleSpeed) { OnOverSpeeding(); }
            } while (CurrentSpeed <= 210 && timeSeconds > 0);
            StopMoving();
        }

        public void StopMoving() 
        {
            CurrentSpeed = 0;
            OnCarEvent("Your car has stopped!");
        }


        private void OnCarEvent(string message)
        {
            CarEvent?.Invoke(this, new CarEventArgs(message));
        }
        private void OnOverSpeeding()
        {
            OverSpeeding?.Invoke(this, new CarEventArgs("You are overspeeding!"));
        }
    }
}
