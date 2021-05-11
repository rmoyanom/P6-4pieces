using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LyBussinesModel.Candidatura;

namespace LyBussinesModel.DTO
{
    public class DTOCandidatura
    {
        public int Id;
        public Usuario Candidato;
        public Servicio Servicio;
        public EstadoCandidatura Estado;

        public DateTime FechaInscripcion;
        public int HorasRequeridas;

        //Valores de finalización
        public int Valoracion;
        public String Comentarios;
        public int HorasGanadas;

        //Valores de Aceptación
        public DateTime FechaAceptacion;
        public DateTime FechaAcordadaServicio;
        public int HorasAcordadas;

        //Valores de Cancelacion
        public DateTime FechaDeCancelacion;
        public String MotivoCancelacíon;
        public CanceladoPor AutorCancelado;

        public DTOCandidatura()
        {

        }

        public DTOCandidatura(int id)
        {
            Id = id;
        }

        public DTOCandidatura(int id, Usuario candidato, Servicio servicio, EstadoCandidatura estado, DateTime fechaInscripcion, int horasRequeridas, int valoracion, string comentarios, int horasGanadas, DateTime fechaAceptacion, DateTime fechaAcordadaServicio, int horasAcordadas, DateTime fechaDeCancelacion, string motivoCancelacíon, CanceladoPor autorCancelado) : this(id)
        {
            Candidato = candidato;
            Servicio = servicio;
            Estado = estado;
            FechaInscripcion = fechaInscripcion;
            HorasRequeridas = horasRequeridas;
            Valoracion = valoracion;
            Comentarios = comentarios;
            HorasGanadas = horasGanadas;
            FechaAceptacion = fechaAceptacion;
            FechaAcordadaServicio = fechaAcordadaServicio;
            HorasAcordadas = horasAcordadas;
            FechaDeCancelacion = fechaDeCancelacion;
            MotivoCancelacíon = motivoCancelacíon;
            AutorCancelado = autorCancelado;
        }
    }
}
