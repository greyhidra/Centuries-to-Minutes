using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centuries_to_Minutes_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vekovi = int.Parse(Console.ReadLine());

            int godine = vekovi * 100;
            int dani = vekovi * 36524 + (vekovi / 4);
            long sati = dani * 24;
            long minuti = sati * 60;


            Console.WriteLine($"{vekovi} centuries = {godine} years = {dani} days = {sati} hours = {minuti} minutes");
        }
    }
}
