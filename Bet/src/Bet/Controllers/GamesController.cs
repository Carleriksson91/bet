using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using Bet.Entities;
using Bet.Models;
using Bet.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Bet.Controllers
{
    public class GamesController : Controller
    {
        private ApplicationDbContext _context;
        private IGameRepository gameRepo;

        public GamesController(ApplicationDbContext context, IGameRepository gameRepository)
        {
            _context = context;
            gameRepo = gameRepository;  
        }

        // GET: Games
        public IActionResult Index()
        {
            return View(_context.Games.Include(x => x.TeamGames).ToList());
        }

        public IEnumerable<Game> GetAllGames()
        {
            return gameRepo.GetAll();
        }

        // GET: Games/Details/5
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Game game = _context.Games.Single(m => m.Id == id);
            if (game == null)
            {
                return HttpNotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Games/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Game game)
        {
            if (ModelState.IsValid)
            {
                game.Id = Guid.NewGuid();
                _context.Games.Add(game);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Games/Edit/5
        public IActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Game game = _context.Games.Single(m => m.Id == id);
            if (game == null)
            {
                return HttpNotFound();
            }
            return View(game);
        }

        // POST: Games/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Update(game);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(game);
        }

        // GET: Games/Delete/5
        [ActionName("Delete")]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Game game = _context.Games.Single(m => m.Id == id);
            if (game == null)
            {
                return HttpNotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            Game game = _context.Games.Single(m => m.Id == id);
            _context.Games.Remove(game);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
