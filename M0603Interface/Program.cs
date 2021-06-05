using System;
using System.Collections.Generic;

namespace M0603Interface
{
    // Interface is a contract
    // Classes implement interfaces
    class Program
    {
        static void Main(string[] args)
        {
            List<IComputerController> controllers = new List<IComputerController>();
            Keyboard keyboard = new Keyboard();
            GameController gameController = new GameController();
            BattertyPoweredGameController battery = new BattertyPoweredGameController();
            BatteryPoweredKeyboard batteryKeyboard = new BatteryPoweredKeyboard();

            controllers.Add(keyboard);
            controllers.Add(gameController);
            controllers.Add(battery);
            controllers.Add(batteryKeyboard);

            foreach (IComputerController controller in controllers)
            {
                if (controller is GameController gc)
                {
                    
                }
                if(controller is IBatteryPowered powered){
                    
                }
            }

            using (GameController gc = new GameController())
            {

            }

            List<IBatteryPowered> powereds = new List<IBatteryPowered>();

            powereds.Add(battery);
            powereds.Add(batteryKeyboard);


            Console.ReadLine();
        }
    }

    public interface IComputerController: IDisposable
    {
        void Connect();
        void CurrentKeyPressed();

    }

    public class Keyboard : IComputerController
    {
        public void Connect() { }
        public void CurrentKeyPressed() { }

        public void Dispose()
        {
        }

        public string ConnectionType { get; set; }
    }
    public class BatteryPoweredKeyboard: Keyboard,IBatteryPowered
    {
        public int BatteryLevel {get; set;}
    }
    public interface IBatteryPowered{
        int BatteryLevel{get;set;}
    }
    public class GameController : IComputerController, IDisposable
    {
        public void Connect()
        {
        }

        public void CurrentKeyPressed()
        {
        }

        public void Dispose()
        {
            // do whatever shutdown tasks needed
        }

    }

    public class BattertyPoweredGameController: GameController,IBatteryPowered
    {
        public int BatteryLevel { get; set; }

    }
    // Homework : Create an IRun interface and apply it to a Person class
    // and an Animal class. Store both types in a List<IRun> object.

    public interface IRun{
        void Run();
    }
    public class Person : IRun
    {
        public void Run()
        {
        }
    }
    public class Animal : IRun
    {
        public void Run()
        {
        }
    }
}
