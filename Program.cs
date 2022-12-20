using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Nasljedivanje_samostalni_rad
{
    class Brojevi
    {
        double broj;

        public double Broj { get => broj; set => broj = value; }

        public virtual double ApsVrijednost() { return 0; }

    }
    class Cijeli : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }
    }
    class Decimalni : Brojevi
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }

    }
    class Pozitivni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }

    }
    class Negativni : Cijeli
    {
        public override double ApsVrijednost()
        {
            return Math.Abs(Broj);
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Pozitivni x = new Pozitivni();
            Negativni y = new Negativni();
            Decimalni z = new Decimalni();

            x.Broj = 100;
            y.Broj = -100;
            z.Broj = 100.45;

            Console.WriteLine(x.ApsVrijednost());
            Console.WriteLine(y.ApsVrijednost());
            Console.WriteLine(z.ApsVrijednost());

            Console.ReadKey();

        }
    }
}