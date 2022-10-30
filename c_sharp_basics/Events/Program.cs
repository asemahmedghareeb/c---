using System;
namespace CAEvent
{
    class program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("amazon");
            stock.Price = 100m;
            stock.OnPriceChanged += Stock_OnPriceChanged;
            //Console.WriteLine($"stock before changing : ${stock.Price}");
            //stock.ChangeStockPriceBy(0.05m);
            //Console.WriteLine($"stock after changing ${stock.Price}");
            stock.ChangeStockPriceBy(0.05m);
            stock.ChangeStockPriceBy(-0.02m);
            stock.ChangeStockPriceBy(0.00m);
        }

        private static void Stock_OnPriceChanged(Stock stock, decimal oldprice)
        {
            if (stock.Price > oldprice)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (oldprice > stock.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
                Console.WriteLine($"{stock.Name} price is {stock.Price}");
        }
    }
    public delegate void StockPriceChangeHander(Stock stock,decimal oldprice);

    public class Stock
    {
        private string name;
        private decimal price;

        public event StockPriceChangeHander OnPriceChanged;
        public string Name => this.name;
        public decimal Price
        {
            get => this.price;
            set => this.price = value;
        }

        public Stock(string stockname)
        {
            this.name = stockname;

        }

        public void ChangeStockPriceBy(decimal percent)
        {
            decimal Oldprice=this.price;

            this.Price += Math.Round(this.Price * percent);
            if(OnPriceChanged != null)//make sure there is subscribers
            {
                OnPriceChanged(this, Oldprice);
            }

        }
    }
}