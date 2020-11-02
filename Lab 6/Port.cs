using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void ShowCertain (int i)
        {
            Vehicle buf;
            if (vehicles[i] is Steamer)
            {
                buf = vehicles[i] as Steamer;
                Console.WriteLine(buf.ToString());
            }
            if (vehicles[i] is Boat)
            {
                buf = vehicles[i] as Boat;
                Console.WriteLine(buf.ToString());
            }
            if (vehicles[i] is Sailboat)
            {
                buf = vehicles[i] as Sailboat;
                Console.WriteLine(buf.ToString());
                return;
            }
            if (vehicles[i] is Corvette)
            {
                buf = vehicles[i] as Corvette;
                Console.WriteLine(buf.ToString());
                return;
            }
            if (vehicles[i] is Ship)
            {
                buf = vehicles[i] as Ship;
                Console.WriteLine(buf.ToString());
            }
        }
    }

    class PortControl
    {
        public int AverageWater(Port port)
        {
            int average = 0;
            Sailboat buf = new Sailboat();
            for (var i = 0; i < port.vehicles.Count; i++)
            {
                if (port.vehicles[i] is Sailboat)
                {
                    buf = port.vehicles[i] as Sailboat;
                    average += buf.water;
                }
            } 
            return average;
        }

        public int AverageSeatsCount(Port port)
        {
            int seats = 0, SteamersQuant = 0;
            Steamer buf = new Steamer();
            for (var i = 0; i < port.vehicles.Count; i++)
            {
                if (port.vehicles[i] is Steamer)
                {
                    buf = port.vehicles[i] as Steamer;
                    seats += buf.SeatsQuant;
                    SteamersQuant++;
                }
            }
            return (int)(seats / SteamersQuant);
        }

        public void CaptainsBelow35 (Port port)
        {
            Vehicle buf;
            for (var i = 0; i < port.vehicles.Count; i++)
            {
                if (port.vehicles[i] is Vehicle)
                {
                    buf = port.vehicles[i] as Vehicle;
                    if (buf.CaptainAge < 35 && buf.CaptainAge > 0)
                    {
                        Console.WriteLine("\n");
                        port.ShowCertain(i);                        
                    }                        
                }
            }
        }
    }
}
