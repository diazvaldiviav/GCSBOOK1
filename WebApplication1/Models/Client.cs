namespace WebApplication1.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Company Company { get; set; }

    }
}
