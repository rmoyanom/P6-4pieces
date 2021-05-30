using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOServicios
    {
        public int id;
        public int idCreador;
        public String titulo;
        public String descripcion;
        public DateTime? fechaCreacion;
        public bool finalizado;
        public String nombreCreador;
        public List<DTOCategoria> Categorias;

        public DTOServicios()
        {

        }

        public DTOServicios(int id)
        {
            this.id = id;
        }

        public DTOServicios(int idCreador, string titulo, string descripcion, bool finalizado, DateTime fechaCreacion)
        {
            this.idCreador = idCreador;
            this.titulo = titulo;
            this.descripcion = descripcion;
            this.fechaCreacion = fechaCreacion;
            this.finalizado = finalizado;
        }
    }

}