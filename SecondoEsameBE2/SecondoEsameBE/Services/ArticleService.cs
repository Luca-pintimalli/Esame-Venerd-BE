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
                        CoverImage = "https://d2mn3puas3vzda.cloudfront.net/img/p/6/8/9/0/8/68908-large_default.jpg"
                    },
                    new Article
                    {
                        Id = 2,
                        Name = "Scarpe da tennis per amatori",
                        Price = 59.99m,
                        Description = "Scarpe ideali per i giocatori amatoriali.",
                        CoverImage = "https://garesiosport.it/cdn/shop/products/Scarpe_da_tennis_Multi-court_Bianco_FZ3650_01_standard.jpg?v=1617893945"
                    },
                     new Article
                    {
                        Id = 3,
                        Name = "Scarpe da tennis professionali",
                        Price = 99.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://www.sportlandweb.it/147236-tm_thickbox_default/nike-air-zoom-pro-clay-sundial-arancio-bianco-scarpe-da-tennis-uomo.jpg"
                    },
                      new Article
                    {
                        Id = 4,
                        Name = "Scarpe da tennis professionali",
                        Price = 19.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://www.sportlandweb.it/110582-tm_thickbox_default/nike-air-zoom-vapor-pro-cc-nero-rosso-scarpe-da-tennis-donna.jpg"
                    },
                       new Article
                    {
                        Id = 5,
                        Name = "Scarpe da tennis professionali",
                        Price = 79.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://staticfanpage.akamaized.net/wp-content/uploads/sites/27/2022/01/migliori-scarpe-da-tennis-2022-adidas-per-giocatori-amatoriali.jpg"
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
                        CoverImage = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQoil7It2F3UafG0AFMk1aIr_roFeAEBwSqNA&s"
                         },
                         new Article
                    { 
                        Id = 8,
                        Name = "Scarpe da tennis professionali",
                        Price = 39.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://m.media-amazon.com/images/I/5188P3vWh6L._AC_UY900_.jpg"
                    }, new Article
                    {
                        Id = 9,
                        Name = "Scarpe da tennis professionali",
                        Price = 179.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://images.asics.com/is/image/asics/1042A237_101_SR_RT_GLB?$sfcc-product$"
                    },
                           new Article
                    {
                        Id = 10,
                        Name = "Scarpe da tennis professionali",
                        Price = 99.99m,
                        Description = "Scarpe ideali per i giocatori professionisti.",
                        CoverImage = "https://maxiprod.b-cdn.net/media/catalog/product/cache/2/image/324x311/9df78eab33525d08d6e5fb8d27136e95/j/o/joma-tpoints22-t_point_roma-scarpe-tennis-uomo-046695401_52t_2.jpg"
                    },
                });
            }
        }
    }
}
