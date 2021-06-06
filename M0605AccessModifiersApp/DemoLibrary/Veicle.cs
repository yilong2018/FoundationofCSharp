using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Veicle
    {
        public string Name { get; set; }
        public decimal Cost { get; set; }

        private string _id;

        public string Id
        {
            get { return $"***{_id.Substring(_id.Length-2)}"; }
            set { _id = value; }
        }

        protected void StartEngine() { }

    }

    public class Car: Veicle
    {
        public void OpenSkyWindow() { }
        public void SetVeicleID(string id)
        {
            Id = id;
        }
        public void AutoStart()
        {
            StartEngine();
        }
    }

    public class Trunk : Veicle
    {
        public void TurnOnFourWheelMode() { }

    }
}
