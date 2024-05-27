using WebApplication1.Models;
using WebApplication1.Tools;

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UsertId { get; set; }
        public int ClientId { get; set; }
        public int IncomeId { get; set; }
        public Invoice Invoice { get; set; }
        public Expenses Expenses { get; set; }

        //table
        public Income income { get; set; }
        public string serviceTime { get; set; }

        //enum
        public CollectionMethod collectionMethod { get; set; }

        public string Description { get; set; }


    }

