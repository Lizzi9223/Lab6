﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    enum Days
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    struct Users
    {
        public string name;
        public byte age;
        public void Show()
        {
            Console.WriteLine($"Имя пользователя - {name}, возраст - {age}.");
        }
    }
    interface Info
    {
        bool WannaBuy();
    }
    interface VehicleDoes
    {
        void Sailing(bool a);
    }
    abstract class Vehicle : VehicleDoes
    {
        public byte CaptainAge;
        public abstract bool WannaBuy();
        public string captain { get; set; }
        public sbyte speed { get; set; }
        public virtual void Display()
        {
            Console.WriteLine($"This vehicle captain's name is {captain}, speed is {speed} km/h.");
        }
        public bool sailing;
        public virtual void Sailing(bool a)
        {
            if (a) Console.WriteLine("Сейчас судно находится в плавании.");
            else Console.WriteLine("Сейчас судно НЕ находится в плавании.");
        }
    }
    partial class Ship : Vehicle, Info
    {
        public bool battle_ship;
        public int length;
        public Ship(bool a = false, int b = 0)
        {
            battle_ship = a;
            length = b;
        }        
    }
    sealed class Steamer : Vehicle
    {
        public int year_of_creation;
        public int SeatsQuant;
        public Steamer(int a = 0, int b = 0)
        {
            year_of_creation = a;
            SeatsQuant = b;
        }
        class Steam_engine
        {
            public string type;
        }
        public override bool WannaBuy()
        {
            return false;
        }
        public override string ToString()
        {
            return ($"Тип объекта = {this.GetType()}; Имя капитана = {captain}; Скорость судна = {speed}; Судно сейчас находится в плавании? {sailing}; " +
                        $"\nГод создания -  {year_of_creation}; Кол-во посадочных мест - {SeatsQuant}.");
        }
    }
    class Boat : Vehicle
    {
        public bool engine;
        public byte capacity;
        public Boat(bool a = false, byte b = 0)
        {
            engine = a;
            capacity = b;
        }
        public override string ToString()
        {
            return ($"Тип объекта = {this.GetType()}; Имя капитана = {captain}; Скорость судна = {speed}; Судно сейчас находится в плавании? {sailing}; " +
                        $"Эта лодка имеет двигатель? {engine}. Вместимоть это лодки равна {capacity} людей.");
        }
        public override bool Equals(object obj)
        {
            if (this.GetType() != obj.GetType())
                return false;
            Boat boat = (Boat)obj;
            if ((this.engine == boat.engine) && (this.capacity == boat.capacity))
                return true;
            else return false;
        }
        public override int GetHashCode()
        {
            return engine.GetHashCode();
        }
        public override bool WannaBuy()
        {
            return false;
        }
    }
    class Sailboat : Ship
    {
        public string sail_color;
        public string sail_material;
        public int water;
        public Sailboat(string a = "", string b = "", int c = 0)
        {
            sail_color = a;
            sail_material = b;
            water = c;
        }
        public override string ToString()
        {
            return ($"Тип объекта = {this.GetType()}; Имя капитана = {captain}; Скорость судна = {speed}; Судно сейчас находится в плавании? {sailing}; " +
                         $"\nЭто боевое судно? {battle_ship}; Длина судна = {length}м. Цвет парусов - {sail_color}; Материал парусов - {sail_material}. Водоизмещение - {water}");
        }
    }
    class Corvette : Ship
    {
        public string type;
        public Corvette(string s)
        {
            type = s;
        }
        public override string ToString()
        {
            return ($"Тип объекта = {this.GetType()}; Имя капитана = {captain}; Скорость судна = {speed}; Судно сейчас находится в плавании? {sailing}; " +
                        $"\nЭто боевое судно? {battle_ship}; Длина судна = {length}м. Тип корвета - {type}.");
        }
    }
    class Printer
    {
        public void IAmPrinting(Vehicle obj)
        {
            Console.WriteLine();
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj.ToString());
            Console.WriteLine();
        }
    }
}
