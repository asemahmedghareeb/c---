
using System;
namespace app
{
    class progarm
    {
        static void Main()
        {
            var ip = new Ip(119, 112, 24, 55);
            Console.WriteLine(ip.Address);
            
            var first_segment=ip[0];
            Console.WriteLine(first_segment);
        }
    } 
    public class Ip
    {
        private int[] segments=new int[4];

        public int this[int index]
        {
            get
            {
                return segments[index];
            }
            set
            {
                segments[index] = value;
            }

        }
        public Ip(int segment1,int segment2,int segment3,int segment4)
        {
            segments[0] = segment1;
            segments[1] = segment2;
            segments[2] = segment3;
            segments[3] = segment4;

        }


        public string Address => string.Join(".",segments);
    }
}
