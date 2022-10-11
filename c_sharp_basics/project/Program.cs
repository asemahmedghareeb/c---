namespace sales
{
    class app
    {
        static void Main()
        {
            int ch, num; string answer;int total = 0;
            do
            {

                Console.WriteLine("welcome , enter number from list\n"+
                    "1- to buy product L and price 70$ \n"+
                    "2- to buy product p and price 80$\n"+
                    "3- to buy produt  D and price 100$\n");
                ch =Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter number of product "+ch);
                num = Convert.ToInt32(Console.ReadLine());
                if(ch == 1)
                {
                    total += (num * 70);
                    Console.WriteLine("the total price is "+ total+"$");
                }
                else if(ch==2){
                    total += (num * 80);

                    Console.WriteLine("the total price is " + total + "$") ;
                }
                else if (ch == 3)
                {
                    total += (num * 100);
                    Console.WriteLine("the total price is "+total+"$");
                }
                else
                {
                    Console.WriteLine("error");
                }
                Console.WriteLine("do you want anthor product ? ( y or n )\n");
                 answer =(Console.ReadLine());
            }while(answer=="y");
            Console.WriteLine("the total price is " + total);

        }
    }
}