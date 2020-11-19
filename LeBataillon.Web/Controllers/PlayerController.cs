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
    public class PlayerController : Controller
    {
        private readonly ILeBataillonRepo _repo;

        public PlayerController(ILeBataillonRepo repo)
        {
            _repo = repo;
        }

        // GET: Player
        public IActionResult Index()
        {
            return View(_repo.GetAllPlayers());
        }

        // GET: Player/Details/5
        public IActionResult Details(int? id)
        {

            try
            {

                var player = this._repo.GetPlayerById(id ?? 0);
                return View(player);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }



        }

        // GET: Player/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Player/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,NickName,Email,PhoneNumber,FirstName,LastName,Level,TeamId")] Player player)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Add(player);
                    return RedirectToAction(nameof(Index));
                }
                catch (LeBataillonRepoException e)
                {
                    this.ModelState.AddModelError(e.Property, e.Message);
                }
            }
            return View(player);
        }

        // GET: Player/Edit/5
        public IActionResult Edit(int? id)
        {

            try
            {
                var player = this._repo.GetPlayerById(id);
                return View(player);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }




        }

        // POST: Player/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,NickName,Email,PhoneNumber,FirstName,LastName,Level,TeamId")] Player player)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _repo.Edit(player);
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
            return View(player);
        }

        // GET: Player/Delete/5
        public IActionResult Delete(int? id)
        {
            try
            {
                var player = this._repo.GetPlayerById(id);
                return View(player);
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
        }

        // POST: Player/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            try
            {
                _repo.RemovePlayer(id);
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
