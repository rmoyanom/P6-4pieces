using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel
{
    /// <summary>
    /// Enumera los posibles estados en los que puede estar una candidatura en un momento determinado
    /// </summary>
    public enum EstadoCandidatura { PENDIENTE, ACEPTADA, CANCELADA, FINALIZADA }
   
    /// <summary>
    /// Enumerado que indica quien fue el autor de la cancelación de una candidatura
    /// </summary>
    public enum CanceladoPor { CANDIDATO, OFERTANTE }

    /// <summary>
    /// Está entidad representa la solicitud que hace un usuario cuando se suscribe a un anucio.
    /// </summary>
    public class Candidatura
    {


        private int _Id;
        private Usuario _Candidato;
        private Servicio _Servicio;
        private EstadoCandidatura _Estado;
        private DateTime _FechaInscripcion;
        private int _HorasRequeridas;
        private int _HorasGanadas;
        private DateTime _FechaAceptacion;
        private DateTime _FechaAcordadaServicio;
        private DateTime _FechaDeCancelacion;

        public Candidatura() { }
        public Candidatura(int id, Usuario candidato, Servicio servicio, EstadoCandidatura estado, DateTime fechaInscripcion, int horasRequeridas)
        {
            _Id = id;
            _Candidato = candidato;
            _Servicio = servicio;
            _Estado = estado;
            _FechaInscripcion = fechaInscripcion;
            _HorasRequeridas = horasRequeridas;
        }
        public int Id { get => _Id; set => _Id = value; }
        public Usuario Candidato { get => _Candidato; set => _Candidato = value; }
        public Servicio Servicio { get => _Servicio; set => _Servicio = value; }
        public EstadoCandidatura Estado { get => _Estado; set => _Estado = value; }
        public DateTime FechaInscripcion { get => _FechaInscripcion; set => _FechaInscripcion = value; }
        public int HorasRequeridas { get => _HorasRequeridas; set => _HorasRequeridas = value; }
        public int HorasGanadas { get => _HorasGanadas; set => _HorasGanadas = value; }
        public DateTime FechaAceptacion { get => _FechaAceptacion; set => _FechaAceptacion = value; }
        public DateTime FechaAcordadaServicio { get => _FechaAcordadaServicio; set => _FechaAcordadaServicio = value; }
        public DateTime FechaDeCancelacion { get => _FechaDeCancelacion; set => _FechaDeCancelacion = value; }

    }
}
