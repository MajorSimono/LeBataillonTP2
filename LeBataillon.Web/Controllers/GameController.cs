using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeBataillon.Database.Context;
using LeBataillon.Database.Models;
using LeBataillon.Database.Repository;
using LeBataillon.Database.Exceptions;

namespace LeBataillon.Web.Controllers
{
    public class GameController : Controller
    {
        private readonly ILeBataillonRepo _repo;

        public GameController(ILeBataillonRepo repo)
        {
            _repo = repo;
        }

        // GET: Game
        public IActionResult Index()
        {
            return View(_repo.GetAllGames());
        }

        // GET: Game/Details/5
        public IActionResult Details(int? id)
        {
            try
            {
                var game = this._repo.GetGameById(id ?? 0);
                return View(game);
            }
            catch (NotFoundException)
            {

                return NotFound();
            }
        }

        // GET: Game/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Game/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,GameDateTime,TeamDefendantId,TeamAttackerId,status")] Game game)
        {
            try
            {
                _repo.Add(game);
                return RedirectToAction(nameof(Index));
            }
            catch (LeBataillonRepoException e)
            {

                this.ModelState.AddModelError(e.Property, e.Message);

            }
            return View(game);
        }


        // GET: Game/Edit/5
        public IActionResult Edit(int? id)
        {
            try
            {
                var game = this._repo.GetGameById(id);
                return View(game);
            }
            catch (NotFoundException)
            {

                return NotFound();
            }
        }

        // POST: Game/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,GameDateTime,TeamDefendantId,TeamAttackerId,status")] Game game)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Edit(game);
                    return RedirectToAction(nameof(Index));
                }
                catch (NotFoundException)
                {

                    return NotFound();
                }
                catch (LeBataillonRepoException e)
                {
                    this.ModelState.AddModelError(e.Property, e.Message);
                }
            }
            return View(game);
        }

        // GET: Game/Delete/5
        public IActionResult Delete(int? id)
        {
            try
            {
                var game = this._repo.GetGameById(id);
                return View(game);
            }
            catch (NotFoundException)
            {
                return NotFound();

            }
        }

        // POST: Game/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repo.RemoveGame(id);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {

                return NotFound();

            }
            catch (LeBataillonRepoException e)
            {
                this.ModelState.AddModelError(e.Property, e.Message);
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
