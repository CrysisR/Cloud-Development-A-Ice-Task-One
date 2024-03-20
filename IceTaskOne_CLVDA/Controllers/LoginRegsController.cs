using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IceTaskOne_CLVDA.Data;
using IceTaskOne_CLVDA.Models.Login;

namespace IceTaskOne_CLVDA.Controllers
{
    public class LoginRegsController : Controller
    {
        private readonly IceTaskOne_CLVDAContext _context;

        public LoginRegsController(IceTaskOne_CLVDAContext context)
        {
            _context = context;
        }

        // GET: LoginRegs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginReg.ToListAsync());
        }

        // GET: LoginRegs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginReg = await _context.LoginReg
                .FirstOrDefaultAsync(m => m.userId == id);
            if (loginReg == null)
            {
                return NotFound();
            }

            return View(loginReg);
        }

        // GET: LoginRegs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginRegs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("userId,username,password,tempUser,TempPass,TempConfPass")] LoginReg loginReg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginReg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginReg);
        }

        //creation for registration

        public IActionResult CreateReg()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateReg(LoginReg loginReg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginReg);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginReg);
        }

        // GET: LoginRegs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginReg = await _context.LoginReg.FindAsync(id);
            if (loginReg == null)
            {
                return NotFound();
            }
            return View(loginReg);
        }

        // POST: LoginRegs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("userId,username,password,tempUser,TempPass,TempConfPass")] LoginReg loginReg)
        {
            if (id != loginReg.userId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginReg);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginRegExists(loginReg.userId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(loginReg);
        }

        // GET: LoginRegs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginReg = await _context.LoginReg
                .FirstOrDefaultAsync(m => m.userId == id);
            if (loginReg == null)
            {
                return NotFound();
            }

            return View(loginReg);
        }

        // POST: LoginRegs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var loginReg = await _context.LoginReg.FindAsync(id);
            if (loginReg != null)
            {
                _context.LoginReg.Remove(loginReg);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginRegExists(int id)
        {
            return _context.LoginReg.Any(e => e.userId == id);
        }
    }
}
