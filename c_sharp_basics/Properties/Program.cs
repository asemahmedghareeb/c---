using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {

        Doller doller = new Doller(100);
            

        }
    }

    public class Doller
    {
        private decimal _amount;

        public Doller(decimal amount)
        {
            if(amount <= 0)
            {

                this._amount= 0;
            }
            _amount = amount;    
        }
    }
}