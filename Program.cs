using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("TASK 1");
        Console.WriteLine(value: "Мир" + " Труд" + " Май");
        Console.WriteLine("Мир");
        Console.WriteLine("  Труд");
        Console.WriteLine("      Май");

        Console.WriteLine("TASK 2");
        Console.WriteLine("Enter first number :");
        var num1 = Console.ReadLine();
        Console.WriteLine("Enter second number :");
        var num2 = Console.ReadLine();
        Console.WriteLine($"{num2} {num1}");

        Console.WriteLine("TASK 3 LEN AND SPACE");
        Console.WriteLine("Enter circle radius :");
        double radius = double.Parse(s: Console.ReadLine());
        double len = 2 * radius * 3.14;
        double space = 3.14 * radius*radius;
        Console.WriteLine($"Length is {len}, Space is {space}");

        Console.WriteLine("TASK 4 Y = COS(X)");
        Console.WriteLine("Enter value for x in rads :");
        double x = double.Parse(s: Console.ReadLine());
        double COSx = Math.Cos(x);
        Console.WriteLine($"Cos(x) = {COSx}");

        Console.WriteLine("TASK 5 ax^2 + bx + c = 0"); 
        Console.Write("Enter value for a: ");
        var a = double.Parse(Console.ReadLine());
        Console.Write("Enter value for b: ");
        var b = double.Parse(Console.ReadLine());
        Console.Write("Enter value for c: ");
        var c = double.Parse(Console.ReadLine());
        double x1, x2;
        var D = Math.Pow(b,2) - 4 * a * c; /// discriminant
        if (D < 0)
        {
            Console.WriteLine("no solutions");
        }
        else
        {
            if (D == 0)
            {
                x1 = -b / (2 * a);
                x2 = x1;
            }
            else
            {
                x1 = (-b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b - Math.Sqrt(D)) / (2 * a);
            }
            Console.WriteLine($" x1 = {x1} x2 = {x2}");
        }

        Console.WriteLine("TASK 7 RANDOM");
        var rnd = new Random();         
        for (int i = 0; i < 4; i++)     /// указываем сколько чисел сгенерировать
        {
            Console.WriteLine(rnd.Next(-1000000,1000001));
            
        }

        Console.WriteLine("TASK 8");
        Console.WriteLine("Enter three-digit number :");
        string number = Console.ReadLine();
        Console.WriteLine(number[2] + number.Remove(2)); ///удаляем 3-й элемент из строки

      
        



        ///спасибо за проверку уважаемая Екатерина Владимировна)
















    }
}