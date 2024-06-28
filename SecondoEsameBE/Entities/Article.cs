using System;
namespace SecondoEsameBE.Entities
{
	public class Article
	{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string CoverImage { get; set; }
    }
}


