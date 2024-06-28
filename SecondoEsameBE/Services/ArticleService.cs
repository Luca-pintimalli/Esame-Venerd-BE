using System.Collections.Generic;
using SecondoEsameBE.Entities;

namespace SecondoEsameBE.Services
{
    public class ArticleService : CrudService<Article>, IArticleService
    {
        public ArticleService()
        {
            if (entities.Count == 0)
            {
                entities.AddRange(new List<Article>
                {
                    new Article
                    {
                        Id = 1,
                        Name = "Scarpe da tennis professionali",
                        Price = 79.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                    new Article
                    {
                        Id = 2,
                        Name = "Scarpe da tennis per amatori",
                        Price = 59.99m,
                        Description = "Scarpe ideali per i giocatori amatoriali.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                     new Article
                    {
                        Id = 3,
                        Name = "Scarpe da tennis professionali",
                        Price = 99.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                      new Article
                    {
                        Id = 4,
                        Name = "Scarpe da tennis professionali",
                        Price = 19.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                       new Article
                    {
                        Id = 5,
                        Name = "Scarpe da tennis professionali",
                        Price = 79.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                        new Article
                    {
                        Id = 6,
                        Name = "Scarpe da tennis professionali",
                        Price = 59.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                         new Article
                    {
                        Id = 7,
                        Name = "Scarpe da tennis professionali",
                        Price = 9.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                          new Article
                    {
                        Id = 8,
                        Name = "Scarpe da tennis professionali",
                        Price = 39.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    }, new Article
                    {
                        Id = 9,
                        Name = "Scarpe da tennis professionali",
                        Price = 179.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                           new Article
                    {
                        Id = 10,
                        Name = "Scarpe da tennis professionali",
                        Price = 99.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://shop.globomoda.com/images/thumbs/0238322_adidas-scarpe-da-tennis-grand-court-lifestyle-lace-if2884-1800329_28818133_550.jpeg"
                    },
                });
            }
        }
    }
}
