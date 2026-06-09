using CitasApp.Domain.Models;
using CitasApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CitasApp.Controllers
{
    public class PacienteController : Controller
    {
        private readonly IPacienteRepository _repo;
        public PacienteController(IPacienteRepository repo) { _repo = repo; }

        public IActionResult Index() => View(_repo.GetAll());

        public IActionResult Detalle(int id)
        {
            var paciente = _repo.GetById(id);
            return paciente == null ? NotFound() : View(paciente);
        }
    }
}