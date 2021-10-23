namespace Uptick.Models
{
    public class Asset
    {
        public string breakID { get; set; }
        public string cardId { get; set; }
        public string Player { get; set; }
        public decimal Grade { get; set; }
        public string Grader { get; set; }
        public string CardName { get; set; }
        public decimal Price { get; set; }
        public int NumberedTo { get; set; }
        public string CardURL { get; set; }
        public string CardImageURL { get; set; }
        public string AssetClass { get; set; }
        public bool isVideo { get; set; }
    }
}
