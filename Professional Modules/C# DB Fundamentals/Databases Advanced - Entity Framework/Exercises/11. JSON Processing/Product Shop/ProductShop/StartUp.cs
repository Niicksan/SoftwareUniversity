namespace ProductShop
{
    using System.IO;
    using Newtonsoft.Json;
    using ProductShop.Data;
    using ProductShop.Models;
    using System.Collections.Generic;
    using System.Linq;
    using System;
    using ProductShop.Dtos.Export;
    using Newtonsoft.Json.Serialization;

    public class StartUp
    {
        private const string ImportMessage = "Successfully imported {0}";

        public static void Main(string[] args)
        {
            var context = new ProductShopContext();

            // 01. mport Users 
            // var usersJason = File.ReadAllText(@"C:\Users\Nik\Desktop\Product Shop\ProductShop\Datasets\users.json");
            // var result = ImportUsers(context, usersJason);
            // Console.WriteLine(result);

            // 02. Import Products
            // var productsJason = File.ReadAllText(@"C:\Users\Nik\Desktop\Product Shop\ProductShop\Datasets\products.json");
            // Console.WriteLine(ImportProducts(context, productsJason));

            // 03. Import Categories
            // var categoriesJason = File.ReadAllText(@"C:\Users\Nik\Desktop\Product Shop\ProductShop\Datasets\categories.json");
            // WriteLine(ImportCategories(context, categoriesJason));

            // 04. Import Categories and Products
            // var categoriesProductsJason = File.ReadAllText(@"C:\Users\Nik\Desktop\Product Shop\ProductShop\Datasets\categories-products.json");
            // Console.WriteLine(ImportCategoryProducts(context, categoriesProductsJason));

            // 05. Export Products In Range
            // Console.WriteLine(GetProductsInRange(context));

            // 06. Export Sold Products
            // Console.WriteLine(GetSoldProducts(context));

            // 08.Export Users and Products
            // Console.WriteLine(GetUsersWithProducts(context));

            // 07. Export Categories By Products Count 
            Console.WriteLine(GetCategoriesByProductsCount(context));
        }

        // 01. Import Users 
        public static string ImportUsers(ProductShopContext context, string inputJson)
        {
            List<User> users = JsonConvert.DeserializeObject<List<User>>(inputJson);
            //.Where(u => u.LastName != null && u.LastName.Length <  3)
            //.ToList();

            var validUsers = new List<User>();

            foreach (var user in users)
            {
                if (user.LastName == null || user.LastName.Length < 3)
                {
                    continue;
                }

                validUsers.Add(user);
            }

            context.AddRange(validUsers);
            context.SaveChanges();

            return string.Format(ImportMessage, validUsers.Count);
        }

        // 02. Import Products
        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            List<Product> products = JsonConvert.DeserializeObject<List<Product>>(inputJson)
                .Where(p => p.Name != null &&
                            p.Name.Trim().Length >= 3)
                .ToList();

            context.Products.AddRange(products);
            context.SaveChanges();

            return string.Format(ImportMessage, products.Count);
        }

        // 03. Import Categories
        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            List<Category> categories = JsonConvert.DeserializeObject<List<Category>>(inputJson)
                .Where(c => c.Name != null &&
                            c.Name.Length >= 3 &&
                            c.Name.Length <= 15)
                .ToList();

            //var validCategories = new List<Category>();

            //foreach (var category in categories)
            //{
            //    if (category.Name == null ||
            //        category.Name.Length < 3 ||
            //        category.Name.Length > 15)
            //    {
            //        continue;
            //    }

            //    validCategories.Add(category);
            //}

            context.Categories.AddRange(categories);
            context.SaveChanges();

            return string.Format(ImportMessage, categories.Count);
        }

        // 04. Import Categories and Products
        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            //var validCategoruIds = context
            //    .Categories
            //    .Select(c => c.Id)
            //    .ToHashSet();

            var validCategoryIds = new HashSet<int>(
                context
                    .Categories
                    .Select(c => c.Id));

            var validProductIds = new HashSet<int>(
                context
                    .Products
                    .Select(p => p.Id));

            var categoriesProducts = JsonConvert.DeserializeObject<CategoryProduct[]>(inputJson);
            var validEntities = new List<CategoryProduct>();

            foreach (var categoryProduct in categoriesProducts)
            {
                //bool isValid = validCategoryIds.Contains(categoryProduct.CategoryId) &&
                //               validProductIds.Contains(categoryProduct.ProductId);

                //if (isValid)
                //{
                //    validEntities.Add(categoryProduct);
                //}

                validEntities.Add(categoryProduct);
            }

            context.CategoryProducts.AddRange(validEntities);
            context.SaveChanges();

            return string.Format(ImportMessage, validEntities.Count);
        }

        // 05. Export Products In Range
        public static string GetProductsInRange(ProductShopContext context)
        {
            var productsInRange = context
                .Products
                .Where(p => p.Price >= 500 && p.Price <= 1000)
                .Select(p => new ProductDto
                {
                    Name = p.Name,
                    Price = p.Price,
                    Seller = $"{p.Seller.FirstName} {p.Seller.LastName}"
                })
                .OrderBy(p => p.Price)
                .ToList();

            var json = JsonConvert.SerializeObject(productsInRange, Formatting.Indented);

            return json;
        }

        // 06. Export Sold Products
        public static string GetSoldProducts(ProductShopContext context)
        {
            var filteredUsers = context
                .Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderBy(u => u.LastName)
                .ThenBy(u => u.FirstName)
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    SoldProducts = u.ProductsSold
                        .Where(ps => ps.Buyer != null)
                        .Select(ps => new
                        {
                            Name = ps.Name,
                            Price = ps.Price,
                            BuyerFirstName = ps.Buyer.FirstName,
                            BuyerLastName = ps.Buyer.LastName
                        })
                        .ToArray()
                })
                .ToArray();

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };


            var json = JsonConvert.SerializeObject(
                filteredUsers,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = contractResolver
                });

            return json;
        }

        // 07. Export Categories By Products Count 
        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var filteredCategories = context
                .Categories
                .OrderByDescending(c => c.CategoryProducts.Count())
                .Select(c => new CategoriesByProductsCountDto
                {
                    Name = c.Name,
                    ProductsCount = c.CategoryProducts.Count,
                    AveragePrice = Math.Round(c.CategoryProducts
                            .Select(pc => pc.Product.Price)
                            .Average(), 2),
                    TotalRevenue = Math.Round(c.CategoryProducts
                            .Select(pc => pc.Product.Price)
                            .Sum(), 2)
                })
                .ToArray();

            var json = JsonConvert.SerializeObject(filteredCategories, Formatting.Indented);

            return json;
        }

        // 08. Export Users and Products
        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var filteredUsers = context
                .Users
                .Where(u => u.ProductsSold.Any(ps => ps.Buyer != null))
                .OrderByDescending(u => u.ProductsSold.Count(ps => ps.Buyer != null))
                .Select(u => new
                {
                    FirstName = u.FirstName,
                    LastName = u.LastName,
                    Age = u.Age,
                    SoldProducts = new
                    {
                        Count = u.ProductsSold
                            .Count(ps => ps.Buyer != null),
                        Products = u.ProductsSold
                            .Where(ps => ps.Buyer != null)
                            .Select(ps => new
                            {
                                Name = ps.Name,
                                Price = ps.Price
                            })
                        .ToArray()
                    }
                })
                .ToArray();

            var result = new
            {
                UsersCount = filteredUsers.Length,
                Users = filteredUsers
            };

            DefaultContractResolver contractResolver = new DefaultContractResolver()
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            };


            var json = JsonConvert.SerializeObject(
                result,
                new JsonSerializerSettings
                {
                    Formatting = Formatting.Indented,
                    ContractResolver = contractResolver,
                    NullValueHandling = NullValueHandling.Ignore
                });

            return json;
        }
    }
}