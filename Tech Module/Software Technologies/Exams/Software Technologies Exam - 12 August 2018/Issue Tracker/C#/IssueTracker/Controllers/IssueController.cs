namespace IssueTracker.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using IssueTracker.Models;
    using System.Linq;
    using Models;

    public class IssueController : Controller
    {
        private readonly IssueDbContext context;

        public IssueController(IssueDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            var issues = context.Issues.ToList();
            return View(issues);
        }

        [HttpGet]
        [Route("/create")]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Route("/create")]
        public ActionResult Create(Issue issue)
        {
            context.Issues.Add(issue);
            context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int id)
        {
            Issue issue = context.Issues.FirstOrDefault(i => i.Id == id);
            return View(issue);
        }

        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult EditConfirm(int id, Issue issueModel)
        {
            context.Update(issueModel);
            context.SaveChanges();
            return Redirect("/");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int id)
        {
            Issue issue = context.Issues.Find(id);
            return View(issue);
        }

        [HttpPost]
        [Route("delete/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirm(int id, Issue issueModel)
        {
            context.Update(issueModel);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
