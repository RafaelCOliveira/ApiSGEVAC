using System.Collections.Generic;
using ApiSGEVAC.Models;
using ApiSGEVAC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiSGEVAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        [HttpGet]
        public IEnumerable<Funcionario> GetAll()
        {
            return _funcionarioRepository.List();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var _funcionario = _funcionarioRepository.GetById(id);
            if (_funcionario == null)
                return NotFound();

            return new ObjectResult(_funcionario);
        }
        
    }
}