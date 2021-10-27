using System;
using System.Collections.Generic;
using System.Linq;
using DALL;
using Entity;

namespace BLL
{
    public class AfiliadoService
    {
        private context _context;

        public AfiliadoService(context context)
        {
            _context = context;
        }

        public GuardarResponse GuardarAfiliado(Afiliado afiliado){
            GuardarResponse guardarResponse = new GuardarResponse();
            try{
                var response = _context.afiliados.Find(afiliado.CodigoAfiliado);
                if(response != null){
                    guardarResponse.Error=true;
                    guardarResponse.Afiliado=null;
                    guardarResponse.Mensaje="ya se encuentra un afiliado registrado con esa identificación";
                }else{
                    _context.afiliados.Add(afiliado);
                    _context.SaveChanges();
                    guardarResponse.Error=false;
                    guardarResponse.Afiliado=afiliado;
                    guardarResponse.Mensaje="Afiliado guardado";
                }
            } catch (Exception e){
                    guardarResponse.Error=true;
                    guardarResponse.Afiliado=null;
                    guardarResponse.Mensaje=$"error, {e.Message}";
            }
            return guardarResponse;
        }

        public ConsultarResponse ConsultarAfiliados(string estado){
            ConsultarResponse consultarResponse = new ConsultarResponse();
            try{
                   
                    consultarResponse.Error=false;
                    consultarResponse.Afiliados=_context.afiliados.Where(a=>a.EstadoAfiliado.Equals(estado)).ToList();
                    consultarResponse.Mensaje="consultado correctamente";
            } catch (Exception e){
                    consultarResponse.Error=true;
                    consultarResponse.Afiliados=null;
                    consultarResponse.Mensaje=$"error, {e.Message}";
            }
            return consultarResponse;
        }


        public class ConsultarResponse{
            public string Mensaje { get; set; }
            public bool Error { get; set; }
            public List<Afiliado> Afiliados { get; set; }
        }

        public class GuardarResponse{
            public string Mensaje { get; set; }
            public bool Error { get; set; }
            public Afiliado Afiliado { get; set; }
        }

    }
}
