using Microsoft.EntityFrameworkCore;

namespace CerasWorkshop.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using var context = new AppDbContext(serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>());

        if (context.Products.Any())
        {
            return;
        }

        List<Product> products = new List<Product>
        {
            new Product {Name = "Baby Axolotl", Description = "Bring a splash of whimsy to your collection with this adorable Baby Axolotl! Handmade with soft, high-quality yarn, this little aquatic friend features vibrant blue hues, tiny legs, and cute frilly gills. Perfect for aquatic animal lovers or as a unique gift for someone special.", Price = 10, ImageURL = "img/BabyAxolotl.png"},
            new Product {Name = "Fat Cat", Description = "Meet your new cuddly companion! This Fat Cat is full of charm with its plump, round body, sweet face, and tiny paws. Its warm golden-yellow tone makes it a cozy addition to any room or a delightful gift for cat lovers.", Price = 25, ImageURL = "img/FatCat.png"},
            new Product {Name = "Red Panda", Description = "Add a touch of the wild to your life with this adorable handmade Red Panda! Featuring detailed stripes on the tail, soft rust-red and brown tones, and a charming face, this Red Panda is perfect for nature enthusiasts and plush collectors alike.", Price = 30, ImageURL = "img/RedPanda.png"},
            new Product {Name = "Bowtie Bat", Description = "Say hello to your spooky-yet-sweet companion! This grey bat Amigurumi is irresistibly cute, complete with soft wings, an orange-and-black bowtie, and pink blush accents for added charm. Perfect for Halloween lovers or anyone who enjoys a touch of the whimsical and adorable.", Price = 20, ImageURL = "img/BowtieBat.png"},
            new Product {Name = "Friendly Ghost", Description = "Boo! This adorable ghost Amigurumi is here to haunt your heart (in the best way)! Made with ultra-soft white blanket yarn, it features big, soulful safety eyes and rosy pink blush accents for an irresistibly cute look. Perfect for spooky season or year-round charm.", Price = 20, ImageURL = "img/FriendlyGhost.png"},
            new Product {Name = "Mini Dino", Description = "Meet the cuddliest dino around! This Mini Dino Amigurumi is as adorable as it is squishy, featuring a soft purple body, pink spines, and a rounded shape. With black safety eyes and rosy pink blush, this little dino is perfect for hugs, decor, or gifting.", Price = 15, ImageURL = "img/MiniDino.png"},
            new Product {Name = "Silly Spider", Description = "Crawl into cuteness with this Silly Spider Amigurumi! Handmade with soft purple yarn, this little arachnid features eight playful legs, big black safety eyes, and a charming design perfect for Halloween or year-round fun. It’s an ideal gift for spooky season lovers or anyone who adores quirky, handmade treasures.", Price = 15, ImageURL = "img/SillySpider.png"},
            new Product {Name = "Festive Pumpkin", Description = "Welcome the cozy vibes of fall with this handmade Crocheted Pumpkin! Crafted with soft brown yarn and topped with a vibrant green stem, this beautifully textured piece captures the essence of autumn. Perfect as seasonal decor or a thoughtful gift, this pumpkin adds warmth and charm to any space.", Price = 15, ImageURL = "img/FestivePumpkin.png"}

        };
        context.AddRange(products);
        context.SaveChanges();

        List<Order> orders = new List<Order>
        {
            new Order {FirstName = "Sarah", LastName = "Johnson"},
            new Order {FirstName = "James", LastName = "Peterson"},
            new Order {FirstName = "Emily", LastName = "Rogers"},
            new Order {FirstName = "Michael", LastName = "Smith"},
            new Order {FirstName = "Olivia", LastName = "Brown"},
            new Order {FirstName = "Matthew", LastName = "Davis"},
            new Order {FirstName = "Jessica", LastName = "Wilson"},
            new Order {FirstName = "Ethan", LastName = "Anderson"},
            new Order {FirstName = "Emma", LastName = "Taylor"},
            new Order {FirstName = "Daniel", LastName = "Martinez"},
            new Order {FirstName = "Chloe", LastName = "Lee"},
            new Order {FirstName = "Jacob", LastName = "Thomas"},
            new Order {FirstName = "Mia", LastName = "White"},
            new Order {FirstName = "Abigail", LastName = "Harris"},
            new Order {FirstName = "Liam", LastName = "Clark"},
            new Order {FirstName = "Natalie", LastName = "Lewis"},
            new Order {FirstName = "Alexander", LastName = "Hill"},
            new Order {FirstName = "Sophia", LastName = "Walker"},
            new Order {FirstName = "Noah", LastName = "Hall"},
            new Order {FirstName = "Grace", LastName = "Young"},
            new Order {FirstName = "Benjamin", LastName = "King"},
            new Order {FirstName = "Isabella", LastName = "Scott"},
            new Order {FirstName = "Elijah", LastName = "Adams"},
            new Order {FirstName = "Amelia", LastName = "Campbell"},
            new Order {FirstName = "Lucas", LastName = "Parker"},
            new Order {FirstName = "Lily", LastName = "Mitchell"},
            new Order {FirstName = "Logan", LastName = "Carter"},
            new Order {FirstName = "Victoria", LastName = "Roberts"},
            new Order {FirstName = "Owen", LastName = "Phillips"},
            new Order {FirstName = "Ella", LastName = "Green"},
            new Order {FirstName = "William", LastName = "Evans"},
            new Order {FirstName = "Ava", LastName = "Baker"},
            new Order {FirstName = "Mason", LastName = "Gonzalez"},
            new Order {FirstName = "Harper", LastName = "Turner"},
            new Order {FirstName = "Jackson", LastName = "Ramirez"}
        };
        context.AddRange(orders);
        context.SaveChanges();

        List<ProductOrder> productOrders = new List<ProductOrder>
        {
            new ProductOrder { OrderID = 1, ProductID = 1 },
            new ProductOrder { OrderID = 1, ProductID = 3 },

            new ProductOrder { OrderID = 2, ProductID = 2 },
            new ProductOrder { OrderID = 2, ProductID = 4 },
            new ProductOrder { OrderID = 2, ProductID = 5 },

            new ProductOrder { OrderID = 3, ProductID = 7 },

            new ProductOrder { OrderID = 4, ProductID = 3 },
            new ProductOrder { OrderID = 4, ProductID = 6 },

            new ProductOrder { OrderID = 5, ProductID = 1 },
            new ProductOrder { OrderID = 5, ProductID = 4 },

            new ProductOrder { OrderID = 6, ProductID = 2 },

            new ProductOrder { OrderID = 7, ProductID = 5 },
            new ProductOrder { OrderID = 7, ProductID = 7 },
            new ProductOrder { OrderID = 7, ProductID = 3 },

            new ProductOrder { OrderID = 8, ProductID = 6 },
            new ProductOrder { OrderID = 8, ProductID = 1 },

            new ProductOrder { OrderID = 9, ProductID = 4 },

            new ProductOrder { OrderID = 10, ProductID = 5 },
            new ProductOrder { OrderID = 10, ProductID = 7 },
            new ProductOrder { OrderID = 10, ProductID = 3 },
            new ProductOrder { OrderID = 10, ProductID = 2 },

            new ProductOrder { OrderID = 11, ProductID = 6 },
            new ProductOrder { OrderID = 11, ProductID = 4 },

            new ProductOrder { OrderID = 12, ProductID = 1 },
            new ProductOrder { OrderID = 12, ProductID = 3 },
            new ProductOrder { OrderID = 12, ProductID = 7 },
            new ProductOrder { OrderID = 12, ProductID = 2 },
            new ProductOrder { OrderID = 12, ProductID = 5 },

            new ProductOrder { OrderID = 13, ProductID = 4 },

            new ProductOrder { OrderID = 14, ProductID = 6 },
            new ProductOrder { OrderID = 14, ProductID = 7 },

            new ProductOrder { OrderID = 15, ProductID = 2 },
            new ProductOrder { OrderID = 15, ProductID = 3 },

            new ProductOrder { OrderID = 16, ProductID = 1 },
            new ProductOrder { OrderID = 16, ProductID = 5 },

            new ProductOrder { OrderID = 17, ProductID = 4 },

            new ProductOrder { OrderID = 18, ProductID = 2 },
            new ProductOrder { OrderID = 18, ProductID = 6 },
            new ProductOrder { OrderID = 18, ProductID = 1 },

            new ProductOrder { OrderID = 19, ProductID = 7 },
            new ProductOrder { OrderID = 19, ProductID = 3 },

            new ProductOrder { OrderID = 20, ProductID = 4 },
            new ProductOrder { OrderID = 20, ProductID = 5 },
            new ProductOrder { OrderID = 20, ProductID = 6 },

            new ProductOrder { OrderID = 21, ProductID = 2 },

            new ProductOrder { OrderID = 22, ProductID = 3 },
            new ProductOrder { OrderID = 22, ProductID = 1 },
            new ProductOrder { OrderID = 22, ProductID = 7 },

            new ProductOrder { OrderID = 23, ProductID = 5 },

            new ProductOrder { OrderID = 24, ProductID = 4 },
            new ProductOrder { OrderID = 24, ProductID = 6 },

            new ProductOrder { OrderID = 25, ProductID = 2 },
            new ProductOrder { OrderID = 25, ProductID = 3 },
            new ProductOrder { OrderID = 25, ProductID = 1 },

            new ProductOrder { OrderID = 26, ProductID = 7 },
            new ProductOrder { OrderID = 26, ProductID = 5 },

            new ProductOrder { OrderID = 27, ProductID = 6 },

            new ProductOrder { OrderID = 28, ProductID = 4 },
            new ProductOrder { OrderID = 28, ProductID = 2 },
            new ProductOrder { OrderID = 28, ProductID = 7 },

            new ProductOrder { OrderID = 29, ProductID = 1 },
            new ProductOrder { OrderID = 29, ProductID = 3 },

            new ProductOrder { OrderID = 30, ProductID = 5 },
            new ProductOrder { OrderID = 30, ProductID = 6 },
            new ProductOrder { OrderID = 30, ProductID = 2 },
            new ProductOrder { OrderID = 30, ProductID = 4 },

            new ProductOrder { OrderID = 31, ProductID = 7 },
            new ProductOrder { OrderID = 31, ProductID = 3 },

            new ProductOrder { OrderID = 32, ProductID = 5 },

            new ProductOrder { OrderID = 33, ProductID = 1 },
            new ProductOrder { OrderID = 33, ProductID = 4 },
            new ProductOrder { OrderID = 33, ProductID = 6 },

            new ProductOrder { OrderID = 34, ProductID = 2 },
            new ProductOrder { OrderID = 34, ProductID = 3 },
            new ProductOrder { OrderID = 34, ProductID = 7 },

            new ProductOrder { OrderID = 35, ProductID = 4 },
            new ProductOrder { OrderID = 35, ProductID = 1 },
            new ProductOrder { OrderID = 35, ProductID = 5 },
            new ProductOrder { OrderID = 35, ProductID = 2 }
        };
        context.AddRange(productOrders);
        context.SaveChanges();
    }
}