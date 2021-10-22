namespace Uptick.Models
{
    public class BreakSlot
    {
        public string breakID { get; set; }
        public Asset card { get; set; }
        
        public User user { get; set; }    
        public int slotNum { get; set; }  
    }
}
