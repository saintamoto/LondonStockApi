using Microsoft.EntityFrameworkCore;
using StockApi.Models;
namespace StockApi.Data
{
    public class LondonStockContext : DbContext
    {
        public LondonStockContext(DbContextOptions<LondonStockContext> options):base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Stock>().HasData(
                new Stock
                {
                    Id = 1,
                    Value = "£197.11",
                    Ticker = "AAPL",
                    StockName = "Apple Inc.",
                    Share = 33
                },

            new Stock
            {
                Id = 2,
                Value = "£307.70",
                Ticker = "TSLA",
                StockName = "Apple Inc.",
                Share = 82
            },

             new Stock
             {
                 Id = 3,
                 Value = "£309.37",
                 Ticker = "MSFT",
                 StockName = "Microsoft Corp.",
                 Share = 12
             },

              new Stock
              {
                  Id = 4,
                  Value = "£135.51",
                  Ticker = "NVDA",
                  StockName = "Nvidia Corp.",
                  Share = 41
              },

               new Stock
               {
                   Id = 5,
                   Value = "£12.90",
                   Ticker = "RSI",
                   StockName = "Rush Street Interactive.",
                   Share = 166
               }
               );
        }
        public DbSet<Stock> Stocks { get; set; }
    }
}
