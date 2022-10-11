using System;
namespace app
{
    class program
    {
        static void Main(string[] args)
        {

            Doller doller = new Doller(100);
            doller.SetAmount(1.99m);
            Console.WriteLine(doller.Amount);
            Console.WriteLine(doller.Is_Zero);

        }
    }

    public class Doller
    {
        private  decimal _amount;
        //properity
        public decimal Amount
        {
            get 
            { 
                return this._amount; 
            }
            private set 
            {
                this._amount=processValue(value);
            }
        }
        public bool Is_Zero
        {
            get 
            { 
                return  _amount==0; 
            }
        }
        //initilization
        public decimal ConvertionFactor{ get; set; } =1.99m;

        public void SetAmount(decimal value)
        {
            Amount=value; 
        }
        public Doller(decimal amount)
        {
            processValue(amount);
        }
        private decimal processValue(decimal value) => value <= 0 ? 0 : Math.Round(value);
        
    }
}