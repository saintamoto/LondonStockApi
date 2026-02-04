using StockApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StockApi.Data;
using Microsoft.EntityFrameworkCore;

namespace StockApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase
    {
        /*static private List<Stock> stocks = new List<Stock>
        {
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
            },
        }; */

        private readonly LondonStockContext _context;
        public StocksController(LondonStockContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Stock>>> GetStocks()
        {
            return Ok(await _context.Stocks.ToListAsync());
        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStockById(int id)
        {
            var stock = await _context.Stocks.FindAsync(id);
            if (stock == null)
                return Ok(null);

            return Ok(stock);
        }
    }
}
