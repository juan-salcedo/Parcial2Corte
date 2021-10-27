using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using DALL;
using Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Parcial.models;

namespace Parcial2Corte.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AfiliadosController : ControllerBase
    {
        private AfiliadoService _service;

        public AfiliadosController(context context) 
        {
            _service= new AfiliadoService(context);
        }

        [HttpPost]
        public ActionResult<AfiliadoViewModel> GuardarAfiliado(AfiliadoInputModel afiliadoInput){
            Afiliado afiliado = Mapear(afiliadoInput);
            var response = _service.GuardarAfiliado(afiliado);
            if(response.Error){
                ModelState.AddModelError("Error al guardar al afiliado", response.Mensaje);
                var detalleProblemas = new ValidationProblemDetails(ModelState);
            
                 detalleProblemas.Status=StatusCodes.Status500InternalServerError;

                return BadRequest(detalleProblemas);
            }
            response.Mensaje="Afiliado Guardado";
            return Ok(response);
        }

        [HttpGet]
        public ActionResult<AfiliadoViewModel> ConsultarAfiliados(string estado ){
            var Response = _service.ConsultarAfiliados(estado);
            return Ok(Response);
        }

        private Afiliado Mapear(AfiliadoInputModel input){
            var afiliado = new Afiliado{
                CodigoAfiliado = input.CodigoAfiliado,
                Nombre= input.Nombre,
                Tipo = input.Tipo,
                FechaNacimiento= input.FechaNacimiento,
                FechaAfilacion = input.FechaAfilacion,
                EstadoAfiliado = input.EstadoAfiliado,
            };
            return afiliado;
        }

        

        
    }
}
