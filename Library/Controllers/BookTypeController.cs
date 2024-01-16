using Library.Models;
using Library.Utility;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class BookTypeController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public BookTypeController(AppDbContext context)
        {
            _appDbContext = context;
        }
        public IActionResult Index()
        {
            List<BookType> objBookTypeList = _appDbContext.BookTypes.ToList();
            return View(objBookTypeList);
        }
    }
}
