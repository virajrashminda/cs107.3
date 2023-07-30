// See https://aka.ms/new-console-template for more information
namespace Lab_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string name;
            float batch;

            Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            Console.WriteLine("Enter your batch: ");
                batch = float.Parse(Console.ReadLine());

            Console.WriteLine("Hello "+ name +" Your batch is " +  batch);
            Console.ReadKey();

            */
            
            /*
            double radius;
            double area;

            Console.WriteLine("Enter the radius");
                radius = Convert.ToInt32(Console.ReadLine());

            area = radius * radius * Math.PI;

            Console.WriteLine($"Area is: {area}");
            Console.ReadKey();
            */
            

            /*
            int a;
            int b;

            Console.WriteLine("Enter First Number");
                a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
                b = int.Parse(Console.ReadLine());

            int z = a + b;

            Console.WriteLine("Sum is: " + z);
            Console.ReadLine();*/

            

            float s;
            float t;

            Console.WriteLine("Enter Salary: ");
                s = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter tax Rate: ");
                t = float.Parse(Console.ReadLine());

            float tax = (s * t) / 100;
            float new_s = s-t;

            Console.WriteLine("Tax is: " + tax);
            Console.WriteLine("New Salary is: " + new_s);
            Console.ReadKey();
            
               
        }
    }
}
