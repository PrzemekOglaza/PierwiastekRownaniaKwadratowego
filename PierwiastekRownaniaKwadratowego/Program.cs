using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierwiastekRownaniaKwadratowego
{    //  Napisz program, który z wykorzystaniem instrukcji if oblicza pierwiastki równania kwadratowego ax2+bx+c = 0, w którym zmienne a, b, c to liczby rzeczywiste
     // wprowadzane z klawiatury.Wszystkie zmienne wyświetlamy na ekranie z dokadnością do dwóch miejsc po przecinku
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;
            Console.WriteLine("Program obliczy pierwiastki równania ax2 + bx + c = 0.");
            Console.WriteLine("Podaj liczbę a:  ");
            a = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("Niedozwolona wartość, zacznij od początku");
            }
            else
            {
                Console.WriteLine("Podaj b:  ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj c:  ");
                c = double.Parse(Console.ReadLine());

                delta = b * b - 4 * a * c;

                if (delta<0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Dla liczb: ");
                    Console.WriteLine("a = {0}, " ,a);
                    Console.WriteLine("b = {0}, ", b);
                    Console.WriteLine("c = {0}, ", c);
                    Console.WriteLine("brak pierwiastków rzeczywistych");
                }
                else
                {
                    if (delta == 0)
                    {
                        x1 = -b / (2 * a);
                        Console.WriteLine();
                        Console.WriteLine("Dla liczb: ");
                        Console.WriteLine("a = {0}, ", a);
                        Console.WriteLine("b = {0}, ", b);
                        Console.WriteLine("c = {0}, ", c);
                        Console.WriteLine("jest jeden pierwiastek podwójny x1 = {0:##.##}.", x1);
                    }
                    else
                    {
                        x1 = (-b - Math.Sqrt(delta)) / (2 * a);
                        x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                        Console.WriteLine();
                        Console.WriteLine("Dla liczb: ");
                        Console.WriteLine("a = {0}, ", a);
                        Console.WriteLine("b = {0}, ", b);
                        Console.WriteLine("c = {0}, ", c);
                        Console.WriteLine("są dwa pierwiastki: x1 = {0:##.##}, x2= {1:##.##}.", x1,x2);
                    }
                }
        
            }
            Console.Read();
        }
    }
}
