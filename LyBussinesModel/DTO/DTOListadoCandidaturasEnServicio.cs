using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOListadoCandidaturasEnServicio
    {
        private int id;
        private String usuario;
        private String nombre;
        private String apellido;
        private DateTime fecha_Inscripcion;
        private String telefono;
        private String correo;
        private int horas_Solicitadas;
        private int horas_Ganadas;
        private EstadoCandidatura estado;

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public DateTime Fecha_Inscripcion { get => fecha_Inscripcion; set => fecha_Inscripcion = value; }

        public int Horas_Solicitadas { get => horas_Solicitadas; set => horas_Solicitadas = value; }
        public int Horas_Ganadas { get => horas_Ganadas; set => horas_Ganadas = value; }
        public EstadoCandidatura Estado { get => estado; set => estado = value; }

    }
}
