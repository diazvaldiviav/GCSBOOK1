using WebApplication1.Models;
using WebApplication1.Tools;

    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //table
        public Income income { get; set; }
        public string serviceTime { get; set; }

        //enum
        public CollectionMethod collectionMethod { get; set; }

        public string Description { get; set; }


    }

