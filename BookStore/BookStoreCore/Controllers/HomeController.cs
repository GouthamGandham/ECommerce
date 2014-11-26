using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        BookStoreEntities storeDB = new BookStoreEntities();

        public ActionResult Index()
        {
            // Get most popular books
            var books = GetTopSellingBooks(5);

            return View(books);
        }

        private List<Book> GetTopSellingBooks(int count)
        {
            // Group the order details by book and return
            // the books with the highest count

            return storeDB.Books
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}