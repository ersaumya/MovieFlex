using MovieFlex.Models;
using MovieFlex.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieFlex.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            var movies = _context.Movies.Include(m =>m.Genre).ToList();
            return View(movies);
        }
        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(m =>m.Genre).SingleOrDefault(c => c.Id == id);
            if (movies == null)
                return HttpNotFound();
            return View(movies);
        }
        

    }
}
