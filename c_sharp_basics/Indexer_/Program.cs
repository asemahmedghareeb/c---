
using System;
using System.Runtime.InteropServices;

namespace app
{
    class progarm
    {
        static void Main()
        {
            //var ip = new Ip(119, 112, 24, 55);
            var ip = new Ip("199.122.24.33");
            var first_segment=ip[0];
            Console.WriteLine($"IP adderess : {ip.Address}");
            Console.WriteLine($"first segment : {first_segment}");
            int[,] inputs = new int[,]
            {
                {1, 2, 3,4,5},
                {1, 2, 3,4,5},
                {1, 2, 3,4,5},
                {1, 2, 3,4,5},
                {1, 2, 3,4,5}

    
            };
            var suduko=new Suduko(inputs);
            suduko[4, 4] = 6;
            Console.WriteLine(suduko[4, 4]);
        }
    } 
    public class Suduko
    {
        private int[,] _matrix;

        //indexer
        public int this[int row,int col]
        {
            get
            {

                //getlength[0] return the number of rows
                if (row < 0||row>_matrix.GetLength(0)) return -1;
                //getlength[1] return the number of cols
                if (col < 0 || row > _matrix.GetLength(1)) return -1;
                return _matrix[row,col]; 
            }    
            set
            {
                if(value < 1||value>_matrix.GetLength(0)) return;
                
                _matrix[row,col] = value;
            }
                  
        }
        public Suduko(int [,] matrix)
        {
            _matrix = matrix;
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

        public Ip(string IPAddress)
        {
            var segs = IPAddress.Split(".");
            for(int i = 0; i < segs.Length; i++)
            {
                segments[i] =Convert.ToInt32(segs[i]);
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
