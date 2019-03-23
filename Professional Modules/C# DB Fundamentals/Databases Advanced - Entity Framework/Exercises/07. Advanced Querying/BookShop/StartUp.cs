namespace BookShop
{
    using BookShop.Data;
    using BookShop.Models.Enums;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Globalization;
    using System.Linq;
    using System.Text;

    public class StartUp
    {
        public static void Main()
        {
            using (var db = new BookShopContext())
            {
                //DbInitializer.ResetDatabase(db);

                // 1. Age Restriction
                string ageRestrict = Console.ReadLine();
                Console.WriteLine(GetBooksByAgeRestriction(db, ageRestrict));

                // 2. Golden Books
                Console.WriteLine(GetGoldenBooks(db));

                // 3. Books by Price
                Console.WriteLine(GetBooksByPrice(db));

                // 4. Not Released In
                int releasedYear = int.Parse(Console.ReadLine());
                Console.WriteLine(GetBooksNotReleasedIn(db, releasedYear));

                // 5. Book Titles by Category
                string catecories = Console.ReadLine();
                Console.WriteLine(GetBooksByCategory(db, catecories));

                // 6. Released Before Date
                string date = Console.ReadLine();
                Console.WriteLine(GetBooksReleasedBefore(db, date));

                // 7. Author Search
                string input = Console.ReadLine();
                Console.WriteLine(GetAuthorNamesEndingIn(db, input));

                // 8. Book Search
                string bookTitleEndWith = Console.ReadLine();
                Console.WriteLine(GetBookTitlesContaining(db, bookTitleEndWith));

                // 9. GetBookTitlesContaining
                string authorStartWith = Console.ReadLine();
                Console.WriteLine(GetBooksByAuthor(db, authorStartWith));

                // 10. Count Books
                int titleLength = int.Parse(Console.ReadLine());
                Console.WriteLine(CountBooks(db, titleLength));

                // 11.Total Book Copies
                Console.WriteLine(CountCopiesByAuthor(db));

                // 12. Profit by Category 
                Console.WriteLine(GetTotalProfitByCategory(db));

                // 13.Most Recent Books
                Console.WriteLine(GetMostRecentBooks(db));

                // 14. Increase Prices
                IncreasePrices(db);

                // 15. Remove Books
                Console.WriteLine(RemoveBooks(db));
            }
        }

        // 1. Age Restriction
        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder sb = new StringBuilder();

            var ageRestriction = Enum.Parse(typeof(AgeRestriction), command, true);

            var bookTitles = context.Books
                    .Where(b => b.AgeRestriction.Equals(ageRestriction))
                    .Select(b => b.Title)
                    .OrderBy(b => b)
                    .ToList();

            foreach (var bookTitle in bookTitles)
            {
                sb.AppendLine(bookTitle);
            }

            return sb.ToString();
        }

        // 2. Golden Books
        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var goldenBookTitles = context.Books
                .Where(b => b.Copies < 5000 && b.EditionType.Equals(EditionType.Gold))
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            foreach (var goldenBookTitle in goldenBookTitles)
            {
                sb.AppendLine(goldenBookTitle);
            }

            return sb.ToString();
        }

        // 3.Books by Price
        public static string GetBooksByPrice(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var booksWithPrice = context.Books
                .Where(b => b.Price > 40.00m)
                .Select(b => new
                {
                    b.Title,
                    b.Price
                })
                .OrderByDescending(b => b.Price)
                .ToList();

            foreach (var bookWithPrice in booksWithPrice)
            {
                sb.AppendLine($"{bookWithPrice.Title} - ${bookWithPrice.Price:f2}");
            }

            return sb.ToString();
        }

        // 4. Not Released In 
        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
            StringBuilder sb = new StringBuilder();

            var goldenBookTitles = context.Books
                .Where(b => b.ReleaseDate.HasValue && b.ReleaseDate.GetValueOrDefault().Year != year)
                .OrderBy(b => b.BookId)
                .Select(b => b.Title)
                .ToList();

            foreach (var goldenBookTitle in goldenBookTitles)
            {
                sb.AppendLine(goldenBookTitle);
            }

            return sb.ToString();
        }

        // 5. Book Titles by Category
        public static string GetBooksByCategory(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            string[] categoryNames = input.ToLower().Split();

            var bookTitles = context.Books
                .Include(b => b.BookCategories)
                .Where(b => b.BookCategories.Any(c => categoryNames.Contains(c.Category.Name.ToLower())))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            foreach (var bookTitle in bookTitles)
            {
                sb.AppendLine(bookTitle);
            }

            return sb.ToString();
        }

        // 6. Released Before Date
        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            StringBuilder sb = new StringBuilder();

            var format = "dd-MM-yyyy";
            CultureInfo provider = CultureInfo.InvariantCulture;
            var currentDate = DateTime.ParseExact(date, format, provider);

            var books = context.Books
                .Where(b => b.ReleaseDate != null && b.ReleaseDate.Value < currentDate)
                .OrderByDescending(b => b.ReleaseDate.Value)
                .Select(b => new
                {
                    b.Title,
                    b.EditionType,
                    b.Price
                })
                .ToList();

            foreach (var book in books)
            {
                sb.AppendLine($"{book.Title} - {book.EditionType} - ${book.Price:f2}");
            }

            return sb.ToString();
        }

        // 7. Author Search
        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var authors = context.Authors
                .Where(a => a.FirstName.EndsWith(input))
                .Select(a => new
                {
                    FullName = $"{a.FirstName} {a.LastName}"
                })
                .OrderBy(a => a.FullName)
                .ToList();

            authors.ForEach(a => sb.AppendLine(a.FullName));

            return sb.ToString();
        }

        // 8. Book Search
        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var booktitles = context.Books
                .Where(b => b.Title.ToLower().Contains(input.ToLower()))
                .Select(b => b.Title)
                .OrderBy(b => b)
                .ToList();

            foreach (var booktitle in booktitles)
            {
                sb.AppendLine(booktitle);
            }       

            return sb.ToString();
        }

        // 9. GetBookTitlesContaining
        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
            StringBuilder sb = new StringBuilder();

            var titles = context.Books
                .Include(b => b.Author)
                .OrderBy(b => b.BookId)
                .Where(b => b.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .Select(b => new
                {
                    Title = b.Title,
                    AuthorName = $"{b.Author.FirstName} {b.Author.LastName}"
                })
                .ToList();

            foreach (var title in titles)
            {
                sb.AppendLine($"{title.Title} ({title.AuthorName})");
            }

            return sb.ToString();
        }

        // 10. Count Books
        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            int booksCount = context.Books
                .Where(b => b.Title.Length > lengthCheck)
                .Count();

            return booksCount;
        }

        // 11. Total Book Copies 
        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var copies = context.Authors
                .Include(a => a.Books)
                .Select(a => new
                {
                    AuthorName = $"{a.FirstName} {a.LastName}",
                    TotalCopies = a.Books.Sum(b => b.Copies)
                })
                .OrderByDescending(a => a.TotalCopies)
                .ToList();

            foreach (var copy in copies)
            {
                sb.AppendLine($"{copy.AuthorName} - {copy.TotalCopies}");
            }

            return sb.ToString();
        }

        // 12. Profit by Category 
        public static string GetTotalProfitByCategory(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categoryProfits = context.Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .Select(c => new
                {
                    Name = c.Name,
                    Profit = c.CategoryBooks.Sum(b => b.Book.Copies * b.Book.Price)
                })
                .OrderByDescending(c => c.Profit)
                .ThenBy(c => c.Name)
                .ToList();

            foreach (var categoryProfit in categoryProfits)
            {
                sb.AppendLine($"{categoryProfit.Name} ${categoryProfit.Profit}");
            }

            return sb.ToString();
        }

        // 13. Most Recent Books 
        public static string GetMostRecentBooks(BookShopContext context)
        {
            StringBuilder sb = new StringBuilder();

            var categories = context
                .Categories
                .Include(c => c.CategoryBooks)
                .ThenInclude(cb => cb.Book)
                .OrderBy(c => c.CategoryBooks.Count)
                .ThenBy(c => c.Name)
                .Select(c => new
                {
                    CategoryName = c.Name,
                    Book = c.CategoryBooks
                    .OrderByDescending(b => b.Book.ReleaseDate)
                    .Take(3)
                    .Select(b => new
                    {
                        BookTitle = b.Book.Title,
                        ReleaseYear = b.Book.ReleaseDate.Value.Year
                    })
                    .ToList()
                })
                .ToList();

            foreach (var category in categories)
            {
                sb.AppendLine($"--{category.CategoryName}");
                category.Book.ForEach(b => sb.AppendLine($"{b.BookTitle} ({b.ReleaseYear})"));
            }

            return sb.ToString();
        }

        // 14. Increase Prices
        public static void IncreasePrices(BookShopContext context)
        {
            var currentBooks = context.Books
                .Where(b => b.ReleaseDate.Value.Year < 2010)
                .ToList();

            foreach (var currentBook in currentBooks)
            {
                currentBook.Price += 5;
            }

            context.SaveChanges();
        }

        // 15. Remove Books 
        public static int RemoveBooks(BookShopContext context)
        {
            var currentBooks = context.Books
                .Where(b => b.Copies < 4200)
                .ToList();

            context.Books.RemoveRange(currentBooks);
            context.SaveChanges();
            return currentBooks.Count;
        }
    }
}