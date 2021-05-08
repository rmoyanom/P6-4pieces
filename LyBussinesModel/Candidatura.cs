using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel
{
    public enum EstadoCandidatura 
    {
        ADJUDICADA, 
        CANCELADA, 
        EN_CURSO, 
        FINALIZADA
    }

    class Candidatura
    {
        private Usuario _Candidato;
        private Servicio _Servicio;
        private EstadoCandidatura _Estado;
        private DateTime _FechaDelServicio;
        private int _Valoracion;
        private String _Comentarios;
        private int _HorasGanadas;

        public EstadoCandidatura Estado { get => _Estado; set => _Estado = value; }
        public DateTime FechaDelServicio { get => _FechaDelServicio; set => _FechaDelServicio = value; }
        public int Valoracion { get => _Valoracion; set => _Valoracion = value; }
        public string Comentarios { get => _Comentarios; set => _Comentarios = value; }
        public int HorasGanadas { get => _HorasGanadas; set => _HorasGanadas = value; }
        internal Usuario Candidato { get => _Candidato; set => _Candidato = value; }
        internal Servicio Servicio { get => _Servicio; set => _Servicio = value; }
    }
}
