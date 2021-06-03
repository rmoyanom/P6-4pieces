using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LyBussinesModel.Candidatura;

namespace LyBussinesModel.DTO
{
    /// <summary>
    /// DTO para compartir los datos de Candidatura. se usa para crear y modificar y visualizar
    /// </summary>
    public class DTOCandidatura
    {
        public int Id;
        public int IdUsuario;
        public int IdServicio;
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

        public DTOCandidatura(int idUsuario,int idServicio,int horasRequeridas, DateTime fechaInscripcion)
        {
            IdUsuario = idUsuario;
            IdServicio = idServicio;
            this.HorasRequeridas= horasRequeridas;
            this.FechaInscripcion = fechaInscripcion;
        }

        public DTOCandidatura(int id, 
                                int idUsuario, 
                                int idServicio, 
                                EstadoCandidatura 
                                estado, 
                                DateTime fechaInscripcion, 
                                int horasRequeridas, 
                                int valoracion, 
                                string comentarios, 
                                int horasGanadas, 
                                DateTime fechaAceptacion, 
                                DateTime fechaAcordadaServicio, 
                                int horasAcordadas, 
                                DateTime fechaDeCancelacion, 
                                string motivoCancelacíon, 
                                CanceladoPor autorCancelado) : this(id)
        {
            IdUsuario = idUsuario;
            IdServicio = idServicio;
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
