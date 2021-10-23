using System;

namespace Uptick.Models
{
    public class HighSale
    {
        public int AdjustedPrice { get; set; }
        public int OriginalPrice { get; set; }
        public string Player { get; set; }
        public string Year { get; set; }
        public string Card { get; set; }
        public string Population { get; set; }
        public string Grade { get; set; }
        public string DateOfSale { get; set; }

        public DateTime SaleDate { get; set; }
        public string AuctionHouse { get; set; }
    }

    public class Sale
    {
        public string CardName { get; set; }
        public int Price { get; set; }
        public string DateSold { get; set; }
    }

}
