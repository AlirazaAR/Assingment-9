using System;

namespace Assingment_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Circle();
            data.getRadius(6.4F);
            float area = data.area();
            float cf = data.circumference(); // circumference
            Console.WriteLine("The radius of the circle is " + data.rad);
            Console.WriteLine("The area of the circle is " + area );
            Console.WriteLine("The circumference of the circle is " + cf );

        }
    }
}
