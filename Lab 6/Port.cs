using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    class Port
    {
        public ArrayList vehicles;
        public ArrayList Vehicles
        {
            get
            {
                return vehicles;
            }
            set
            {
                vehicles = Vehicles;
            }
        }
        public void AddVehicle (object obj)
        {
            vehicles.Add(obj);
        }
        public void RemoveVehicle (object obj)
        {
            for (var i = 0; i < vehicles.Count; i++)
                vehicles.Remove(obj);
        }
        public void Show()
        {
            Console.WriteLine("//////////////////////////////");
            for (var i = 0; i < vehicles.Count; i++)
            {
                Console.WriteLine($"{vehicles[i]}\t");
                if (i != vehicles.Count - 1)
                    Console.WriteLine("->");
            }
            Console.WriteLine("//////////////////////////////");
        }
    }

    class PortControl
    {

    }
}
