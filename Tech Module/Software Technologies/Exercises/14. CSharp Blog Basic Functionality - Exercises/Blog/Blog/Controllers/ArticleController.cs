using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Blog.Data;
using Blog.Models;
using Microsoft.AspNetCore.Authorization;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ArticleController(ApplicationDbContext context)
        {
            _context = context;
        }


        //
        // GET: Article
        public IActionResult Index()
        {
            return RedirectToAction("List", "Article");
        }


        // GET: Article/List
        public IActionResult List()
        {
            List<Article> articles = _context.Articles
                .Include(a => a.Author)
                .ToList();

            return View(articles);
        }


        //
        // GET: Article/Details
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return StatusCode(404);
            }

            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            if (article == null)
            {
                return StatusCode(404);
            }

            return View(article);
        }


        //
        // GET: Article/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }


        //
        // Post: Article/Create
        [HttpPost]
        [Authorize]
        public IActionResult Create(Article article)
        {
            if (ModelState.IsValid)
            {
                // get user id
                var authorId = _context.Users
                    .Where(u => u.UserName == this.User.Identity.Name)
                    .First()
                    .Id;

                // ser article author
                article.AuthorId = authorId;

                // save article author
                _context.Articles.Add(article);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(article);
        }


        //
        // GET: Article/Edit/id
        [Authorize]
        public IActionResult Edit(int? id)
        {
            // Check if id exists
            if (id == null)
            {
                return StatusCode(404);
            }

            // Get article from databases
            var article = _context.Articles
                .Where(a => a.Id == id)
                .First();

            


            // Check if article exists
            if (article == null)
            {
                return StatusCode(404);
            }

            // Create the view model
            var model = new ArticleViewModel();
            model.Id = article.Id;
            model.Title = article.Title;
            model.Content = article.Content;

            // Past the view model to view
            return View(model);
        }


        //
        // Post: Article/Edit/id
        [HttpPost]
        [Authorize]
        public IActionResult Edit(ArticleViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Get the article
                var article = _context.Articles
                    .FirstOrDefault(a => a.Id == model.Id);

                // Set new properties
                article.Title = model.Title;
                article.Content = model.Content;

                // Save changes
                _context.Update(article);
                _context.SaveChanges();

                //
                return RedirectToAction("Index");
            }
            // If model is invalid return the same view
            return View(model);
        }


        //
        // GET: Article/Delete
        [Authorize]
        public IActionResult Delete(int? id)
        {
            // Check if id exists
            if (id == null)
            {
                return StatusCode(404);
            }

            // Get Article
            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            // Check if the user is the author if the article
            if (!IsAuthorOrAdmin(article))
            {
                return Forbid();
            }

            // Check if article exists
            if (article == null)
            {
                return StatusCode(404);
            }

            return View(article);
        }


        //
        // POST: Article/Delete/id
        [Authorize]
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int? id)
        {
            // Get Article
            var article = _context.Articles
                .Include(a => a.Author)
                .First(m => m.Id == id);

            // Check if article exists
            if (article == null)
            {
                return StatusCode(404);
            }

            // Delete Article
            _context.Articles.Remove(article);
            _context.SaveChanges();

            // Redirect to index page
            return RedirectToAction("Index");
        }

        private bool IsAuthorOrAdmin(Article article)
        {
            bool isAuthor = article.IsAuthor(this.User.Identity.Name);
            bool isAdmin = this.User.IsInRole("Admin");

            return isAuthor || isAdmin;
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Id == id);
        }
    }
}
