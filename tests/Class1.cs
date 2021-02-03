using System;

namespace tests
{
    public class tests
    {
        public double equal(double x, double a, double b, double c)
        {
            if ((x < 0) && (b != 0))
            {
                return a * Math.Pow(x, 2) + b;
            }
            else if ((x > 0) && (b == 0))
            {
                return (x - a) / (x - c);
            }
            else
            {
                return x / c;
            }

        }
        public bool owo(bool Kurisu)
        {
            if (Kurisu == true)
            {
                return true;

            }
            else return false;

        }
        public string uwu(string Kurisu)
        {
            if (Kurisu == null)
            {
                return null;

            }
            else return "a";
        }

        public T Maki<T>(T Kurisu)
        {
            T Maki = Kurisu;
            return Maki;
        }

        public string saddd(string Kurisu)
        {
            try
            {
                try
                {
                   
                    if (Kurisu.Length > 6)
                    {
                        return Kurisu;
                    }
                }
                catch
                {
                    Console.WriteLine("Возникло исключение");
                    throw;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return "0";
        }
       
    }
}
