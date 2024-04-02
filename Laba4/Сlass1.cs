using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{

    public class Petal
    {
        public string Color { get; set; }

        public Petal(string color)
        {
            Color = color;
        }
        public override bool Equals(object? obj)
        {
            if (obj is Petal petal)
                return Color == petal.Color;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Petal color: {Color}";
        }
    }

    public class Bud
    {
        public string Color { get; set; }
        public bool IsOpen { get; set; }

        public Bud(string color, bool isOpen)
        {
            Color = color;
            IsOpen = isOpen;
        }
        public override bool Equals(object? obj)
        {
            if(obj is Bud bud)
                return Color == bud.Color && IsOpen == bud.IsOpen;
            return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Bud color: {Color}, IsOpen: {IsOpen}";
        }
    }

    public class Flower
    {
        Petal petal;
        Bud bud;

        public Flower(string petalColor, string budColor, bool isBudOpen)
        {
            petal = new Petal(petalColor);
            bud = new Bud(budColor, isBudOpen);
        }

        public void Blossom()
        {
            if (bud.IsOpen == true)
            {
                Console.WriteLine("The flower is blossoming.");
            }
            else
            {
                Wither();
            }
        }

        public void Wither()
        {
            Console.WriteLine("The flower withered.");
        }

        public void PrintBudColor()
        {
            Console.WriteLine(bud);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override string ToString()
        {
            return $"Flower with {petal.Color} petals and a {bud.Color} bud.";
        }
    }
}


