using System;
using System.Buffers;

namespace Delegate
{
    public delegate void RecDelegate(decimal width, decimal height);
    class program
    {
        static void Main(string[] args)
        {

            var rec = new rectangle();
            RecDelegate rect;

            rect=rec.GetArea;
            rect += rec.Getprimeter;
            rect(10,10);
            Console.WriteLine("after unsubcribing rect.getarea");
            rect -= rec.GetArea;
            rect(10, 10);
            
        }
    }
    public class rectangle
    {
        public void GetArea(decimal width,decimal height)
        {
            var result = width * height;
            Console.WriteLine($"area : {width} X {height} = {result}");
        }
        public void Getprimeter(decimal width,decimal height)
        {
            var result=2*(width*height);
            Console.WriteLine($"perimeter : 2 * ( {width} X {height} ) = {result}");

        }

    }
}