using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6
{
    partial class Ship
    {
        public override void Display()
        {
            Console.WriteLine($"Is this ship battle? {battle_ship}. Its length is {length}m.");
        }
        public override void Sailing(bool a)
        {
            if (a) Console.WriteLine("В пути.");
            else Console.WriteLine("Дома.");
        }
        bool Info.WannaBuy()
        {
            return true;
        }
        public override bool WannaBuy()
        {
            return false;
        }
        public override string ToString()
        {
            return ($"Тип объекта = {this.GetType()}; Имя капитана = {captain}; Скорость судна = {speed}; Судно сейчас находится в плавании? {sailing}; " +
                        $"\nЭто боевое судно? {battle_ship}; Длина судна = {length}м.");
        }
    }
}
