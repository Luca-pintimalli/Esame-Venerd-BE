using System;
namespace SecondoEsameBE.Models
{
	public class ArticleInput
	{
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public IFormFile Immagine { get; set; }
    }
}
