using System;

namespace Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input coordinates of 3 points
            // For dot A
            Console.WriteLine("Enter coordinate x of dot A:");
            double ax = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot A:");
            double ay = double.Parse(Console.ReadLine());

            // For dot B
            Console.WriteLine("Enter coordinate x of dot B:");
            double bx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot B:");
            double by = double.Parse(Console.ReadLine());

            // For dot c
            Console.WriteLine("Enter coordinate x of dot C:");
            double cx = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of dot C:");
            double cy = double.Parse(Console.ReadLine());


            //calculate lenght of triangle
            double ab = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2));
            double bc = Math.Sqrt(Math.Pow(cx - bx, 2) + Math.Pow(cy - by, 2));
            double ac = Math.Sqrt(Math.Pow(ax - cx, 2) + Math.Pow(ay - cy, 2));


            Console.WriteLine(" ");

            //output lenght of triangle sides
            Console.WriteLine($"Lenght of AB is: '{ab}'");
            Console.WriteLine($"Lenght of BC is: '{bc}'");
            Console.WriteLine($"Lenght of AC is: '{ac}'");

            Console.WriteLine(" ");

            // Is it equilateral triangle?
            bool equilateral = ab == bc && bc == ac;

            string result;

            if (equilateral == true)
            {
                result = "Equilateral";
            }
            else
            {
                result = "NOT Equilateral";
            }

            Console.WriteLine($"Triangle IS '{result}'");

            // Is it isosceles triangle?

            bool isosceles = ab == bc || bc == ac || ac == ab;

            if (isosceles == true)
            {
                result = "Isosceles";
            }
            else
            {
                result = "NOT Isosceles";
            }

            Console.WriteLine($"Triangle IS '{result}'");

            // Is it right triangle?

            double cosA = (bc * bc + ac * ac - ab * ab) / (2 * bc * ac);
            double cosB = (ac * ac + ab * ab - bc * bc) / (2 * ac * ab);
            double cosC = (ab * ab + bc * bc - ac * ac) / (2 * ab * bc);

            cosA = Math.Abs(cosA);
            cosB = Math.Abs(cosB);
            cosC = Math.Abs(cosC);

            //Console.WriteLine($" {cosA}");
            //Console.WriteLine($" {cosB}");
            //Console.WriteLine($" {cosC}\n");

            bool right = cosA <= 0.0001 || cosB <= 0.0001 || cosC <= 0.0001;

            if (right == true)
            {
                result = "Right";
            }
            else
            {
                result = "NOT Right";
            }

            Console.WriteLine($"Triangle IS '{result}'");

            Console.WriteLine(" ");

            //the perimeter of the triangle ab+bc+ac

            double perimeter = ab + bc + ac;

            Console.WriteLine($"Perimeter: '{perimeter}'\n");
            Console.WriteLine($"Parity numbers in range from 0 to triangle perimeter:");

            for (int i = 0; i <= perimeter; i += 2)
            {
                Console.WriteLine($"{i}");
            }

            Console.ReadLine();
        }
    }
}
