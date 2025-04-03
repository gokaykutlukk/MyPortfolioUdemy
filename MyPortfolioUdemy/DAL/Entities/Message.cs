namespace MyPortfolioUdemy.DAL.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string Name { get; set; }
       
        public string Subject { get; set; }
        public string Email { get; set; }
        public string MessageDetail { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public bool IsRead { get; set; } = false;
    }
}
