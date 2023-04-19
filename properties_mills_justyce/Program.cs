using System;

namespace properties_mills_justyce
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars c = new Cars();//creates c object for Cars
            {
                ///gives value to Make and Model
                c.Model = "el camino";
                c.Make = "chevrolet";

                Console.WriteLine($"make - {c.Make}, model - {c.Model}");//prints results of Cars object c
            }
            Cars c2 = new Cars();//creates c2 object for Cars
            {
                ///gives value to Make and Model
                c2.Model = "duster";
                c2.Make = "plymouth";

                Console.WriteLine($"make - {c2.Make}, model - {c2.Model}");//prints results of Cars object c2
            }
        }
    }
}
