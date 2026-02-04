namespace StockApi.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Share {  get; set; }
        public string StockName { get; set; } = null!;
        public string Ticker { get; set; } = null!;
        public string Value { get; set; } = null!;


    }
}
