using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public enum ResultadoDetalleServicioPuedeSolicitarse : int
    {
        PUEDE, HORAS_INSUFICIENTES, YA_SOLICITADA
    }

    public class DTOServiciosDetalles
    {
        public int id;
        public DTOUsuario Creador;
        public int CantidadSolicitudes;
        public String Titulo;
        public String Descripcion;
        public DateTime? FechaDeInicio;
        public bool Finalizado;
        public int Puntuacion;
        public int HorasEstimadas;
        public List<DTOCategoria> Categorias;
        public ResultadoDetalleServicioPuedeSolicitarse SePuedeSolicitar; 

        public DTOServiciosDetalles()
        {

        }

        public DTOServiciosDetalles(int id, DTOUsuario creador, int cantidadSolicitudes, string titulo, string descripcion, DateTime? fechaDeInicio, bool finalizado)
        {
            this.id = id;
            Creador = creador;
            CantidadSolicitudes = cantidadSolicitudes;
            Titulo = titulo;
            Descripcion = descripcion;
            FechaDeInicio = fechaDeInicio;
            Finalizado = finalizado;
        }

    }
}
