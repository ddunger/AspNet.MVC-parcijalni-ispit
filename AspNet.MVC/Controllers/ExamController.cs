using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        // GET: ExamController
        public ActionResult Index()
        {
            var authors = new List<Author>
            {
            new Author { Id = 1, FullName = "Miroslav Krleža", YearOfBirth = 1893 },
            new Author { Id = 2,  FullName = "Renato Barić", YearOfBirth = 1963 },
            new Author { Id = 3,  FullName = "Stephen King", YearOfBirth = 1947 }
            };

            var books = new List<Book>
            {
                new Book { Id = 1, Title = "Povratak Filipa Latinovicza", Author = authors[0] },
                new Book { Id = 2, Title = "Balade Petrice Kerempuha", Author = authors[0] },
                new Book { Id = 3, Title = "Osmi povjerenik", Author = authors[1] },
                new Book { Id = 4, Title = "Zelena milja", Author = authors[2]  },
                new Book { Id = 5,  Title = "Isijavanje",  Author = authors[2] },
            };
 
            return View(books);
        }

        // GET: ExamController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ExamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ExamController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ExamController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ExamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ExamController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
