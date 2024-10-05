namespace lek06exercise3.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        public short Published { get; set; }
        public string ISBN { get; set; }

    }
}
