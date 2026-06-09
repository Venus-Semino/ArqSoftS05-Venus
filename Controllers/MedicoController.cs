using CitasApp.Domain.Models;
using CitasApp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CitasApp.Controllers
{
    public class MedicoController : Controller
    {
        private readonly IMedicoRepository _repo;
        public MedicoController(IMedicoRepository repo) { _repo = repo; }

        public IActionResult Index() => View(_repo.GetAll());

        public IActionResult Detalle(int id)
        {
            var medico = _repo.GetById(id);
            return medico == null ? NotFound() : View(medico);
        }
    }
}