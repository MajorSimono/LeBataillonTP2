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
    public class TeamController : Controller
    {
        private readonly ILeBataillonRepo _repo;

        public TeamController(ILeBataillonRepo repo)
        {
            _repo = repo;
        }

        // GET: Team
        public IActionResult Index()
        {
            return View(_repo.GetAllTeams());
        }

        // GET: Team/Details/5
        public IActionResult Details(int? id)
        {
            try
            {
                var team = this._repo.GetTeamById(id ?? 0);
                return View(team);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
        }

        // GET: Team/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Team/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,TeamName,Captain.Id,JoueurMaximum")] Team team)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    TempData["message"] = "added";
                    _repo.Add(team);
                    return RedirectToAction(nameof(Index));
                }
                catch (LeBataillonRepoException e)
                {

                    this.ModelState.AddModelError(e.Property, e.Message);
                }
            }
            return View(team);
        }

        // GET: Team/Edit/5
        public IActionResult Edit(int? id)
        {
            try
            {
                var team = this._repo.GetTeamById(id);
                return View(team);
            }
            catch (NotFoundException)
            {

                return NotFound();
            }
        }

        // POST: Team/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,TeamName,Captain.Id,JoueurMaximum")] Team team)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    TempData["message"] = "edit";
                    _repo.Edit(team);
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
            return View(team);
        }

        // GET: Team/Delete/5
        public IActionResult Delete(int? id)
        {
            try
            {
                var team = this._repo.GetTeamById(id);
                return View(team);
            }
            catch (NotFoundException)
            {

                return NotFound();
            }
        }

        // POST: Team/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repo.RemoveTeam(id);
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

        public IActionResult GetAll()
        {
            return Json(new { data = _repo.GetAllTeams() });
        }
    }
}
