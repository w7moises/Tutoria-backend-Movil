using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TutoFinder.Commons;
using TutoFinder.Dto;
using TutoFinder.Service;

namespace TutoFinder.Controllers
{
    [ApiController]
    [Route("tutorias")]
    public class TutoriaController : ControllerBase
    {
        private readonly TutoriaService _TutoriaService;

        public TutoriaController(TutoriaService TutoriaService)
        {
            _TutoriaService = TutoriaService;
        }
        [HttpGet]
        public async Task<ActionResult<DataCollection<TutoriaDto>>> GetAll(int page, int take)
        {
            return await _TutoriaService.GetAll(page, take);
        }

        [HttpGet]
        [Route("api/id/{id}")]
        public async Task<ActionResult<TutoriaDto>> GetById(int id)
        {
            if (_TutoriaService.Existencia(id) == true)
            {
                return await _TutoriaService.GetById(id);
            }
            else
                return NotFound();
        }

        [HttpGet]
        [Route("api/filtro-curso/{curso}")]
        public async Task<ActionResult<DataCollection<TutoriaDto>>> FiltroCurso(string curso, int page, int take)
        {
            return await _TutoriaService.FiltroCurso(curso, page, take);
        }
        [HttpGet]
        [Route("api/filtro-grado-academico/{grado}")]
        public async Task<ActionResult<DataCollection<TutoriaDto>>> FiltroGradoAcademico(string grado, int page, int take)
        {
            return await _TutoriaService.FiltroGradoAcademico(grado, page, take);
        }
        [HttpGet]
        [Route("api/filtro-membresia/{membresia}")]
        public async Task<DataCollection<TutoriaDto>> FiltroMembresia(bool membresia, int page, int take)
        {
            return await _TutoriaService.FiltroMembresia(membresia, page, take);
        }
        [HttpGet]
        [Route("api/filtro-costo-maximo/{costo}")]
        public async Task<DataCollection<TutoriaDto>> FiltroCostoMaximo(double costo, int page, int take)
        {
            return await _TutoriaService.FiltroCostoMaximo(costo, page, take);
        }
        [HttpPost]
        public ActionResult Create(TutoriaCreateDto Tutoria)
        {
            _TutoriaService.Create(Tutoria);
            return Ok();
        }
        [HttpPut("{id}")]
        public ActionResult Update(int id, TutoriaUpdateDto model)
        {
            if (_TutoriaService.Existencia(id) == true)
            {
                _TutoriaService.Update(id, model);
                return NoContent();
            }
            else
                return NotFound();
        }
        [HttpDelete("{id}")]
        public ActionResult Remove(int id)
        {
            if (_TutoriaService.Existencia(id) == true)
            {
                _TutoriaService.Remove(id);
                return NoContent();
            }
            else
                return NotFound();
        }
    }
}
