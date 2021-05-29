using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOServiciosDetalles
    {
        private int _id;
        private DTOUsuario Creador;
        private int CantidadSolicitudes;
        private String _Titulo;
        private String _Descripcion;
        private DateTime? _FechaDeInicio;
        private bool _Finalizado;

        public DTOServiciosDetalles(int id, DTOUsuario creador, int cantidadSolicitudes, string titulo, string descripcion, DateTime? fechaDeInicio, bool finalizado)
        {
            _id = id;
            Creador = creador;
            CantidadSolicitudes = cantidadSolicitudes;
            _Titulo = titulo;
            _Descripcion = descripcion;
            _FechaDeInicio = fechaDeInicio;
            _Finalizado = finalizado;
        }
        public DTOServiciosDetalles() { }

        public int Id { get => _id; set => _id = value; }
        public DTOUsuario Creador1 { get => Creador; set => Creador = value; }
        public int CantidadSolicitudes1 { get => CantidadSolicitudes; set => CantidadSolicitudes = value; }
        public string Titulo { get => _Titulo; set => _Titulo = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public DateTime? FechaDeInicio { get => _FechaDeInicio; set => _FechaDeInicio = value; }
        public bool Finalizado { get => _Finalizado; set => _Finalizado = value; }
    }
}
