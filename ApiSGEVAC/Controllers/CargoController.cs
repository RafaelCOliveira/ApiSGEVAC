using System.Collections.Generic;
using ApiSGEVAC.Models;
using ApiSGEVAC.Repository;
using Microsoft.AspNetCore.Mvc;

namespace ApiSGEVAC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CargoController : Controller
    {

        private readonly ICargoRepository _cargoRepository;
        public CargoController(ICargoRepository cargoRepository)
        {
            _cargoRepository = cargoRepository;
        }

        [HttpGet]
        public IEnumerable<Cargo> GetAll()
        {
            return _cargoRepository.List();
        }

        [HttpGet("{id}")]
        public ActionResult GetById(int id)
        {
            var _cargo = _cargoRepository.GetById(id);
            if (_cargo == null)
                return NotFound();

            return new ObjectResult(_cargo);
        }
         
        [HttpPost]
        public ActionResult Create([FromBody] Cargo cargo)
        {

            _cargoRepository.Add(cargo);
            return new ObjectResult(cargo);       
            // return CreatedAtRoute("GetUsuario", new { id = usuario.IdCargo }, usuario);

        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] Cargo cargo)
        {
            if (cargo == null || id != cargo.IdCargo)
                 return BadRequest();

            var _cargo = _cargoRepository.GetById(id);
            if (_cargo == null)
                return NotFound();

            _cargo.DescCargo = cargo.DescCargo;
            _cargoRepository.Edit(_cargo);
            return new NoContentResult();
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var _cargo = _cargoRepository.GetById(id);
            if (_cargo == null)
                return NotFound();

            _cargoRepository.Delete(id);
            return new NoContentResult();
        }
        


    }
}