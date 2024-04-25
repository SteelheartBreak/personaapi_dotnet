using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personaapi_dotnet.Models.Entities;
using personaapi_dotnet.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personaapi_dotnet.Controllers
{
    [Route("api/profesiones")]
    [ApiController]
    public class ProfesionsController : Controller
    {
        private readonly IProfesionRepository _profesionRepository;

        public ProfesionsController(IProfesionRepository profesionRepository)
        {
            _profesionRepository = profesionRepository;
        }

        // GET: api/profesiones
        [HttpGet("list")]
        public async Task<IActionResult> Index()
        {
            var profesiones = await _profesionRepository.GetAllProfesiones();
            return View(profesiones);
        }

        // GET: api/profesiones/details/{id}
        [HttpGet("details/{id}")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesion = await _profesionRepository.GetProfesionById(id.Value);
            if (profesion == null)
            {
                return NotFound();
            }

            return View(profesion);
        }

        // GET: api/profesiones/create
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: api/profesiones/create
        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nom,Des")] Profesion profesion)
        {
            if (ModelState.IsValid)
            {
                await _profesionRepository.AddProfesion(profesion);
                return RedirectToAction(nameof(Index));
            }
            return View(profesion);
        }

        // GET: api/profesiones/edit/{id}
        [HttpGet("edit/{id}")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesion = await _profesionRepository.GetProfesionById(id.Value);
            if (profesion == null)
            {
                return NotFound();
            }
            return View(profesion);
        }

        // POST: api/profesiones/edit/{id}
        [HttpPost("edit/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nom,Des")] Profesion profesion)
        {
            if (id != profesion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _profesionRepository.UpdateProfesion(profesion);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_profesionRepository.ProfesionExists(profesion.Id))
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
            return View(profesion);
        }

        // GET: api/profesiones/delete/{id}
        [HttpGet("delete/{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var profesion = await _profesionRepository.GetProfesionById(id.Value);
            if (profesion == null)
            {
                return NotFound();
            }

            return View(profesion);
        }

        // POST: api/profesiones/delete/{id}
        [HttpPost("delete/{id}")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _profesionRepository.DeleteProfesion(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
