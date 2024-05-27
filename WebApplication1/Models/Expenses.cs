using WebApplication1.Tools;

namespace WebApplication1.Models
{
    public class Expenses
    {
        public int Id { get; set; }
        public Category category { get; set; }
        public int CompanyId { get; set; }
        public DateOnly date { get; set; }
        public string Description { get; set; }
        public string imageUrl { get; set; }
        public long price { get; set; }

    }
}
