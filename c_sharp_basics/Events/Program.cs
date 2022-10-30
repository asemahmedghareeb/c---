using System;
namespace CAEvent
{
    class program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("amazon");
            stock.Price = 100m;
            Console.WriteLine($"stock before changing : ${stock.Price}");
            stock.ChangeStockPriceBy(0.05m);
            Console.WriteLine($"stock after changing ${stock.Price}");

        }
    }
    public delegate void StockPriceChangeHander();

    public class Stock
    {
        private string name;
        private decimal price;

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
            this.Price += Math.Round(this.Price * percent);

        }
    }
}