using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOCategoria
    {
        public int idCategoria;
        public String nombre;

        public DTOCategoria()
        {
        }

        public DTOCategoria(int id)
        {
            idCategoria = id;
        }

        public DTOCategoria(string nombre)
        {
            this.nombre = nombre;
        }

        public DTOCategoria(int idCategoria, string nombre)
        {
            this.idCategoria = idCategoria;
            this.nombre = nombre;
        }

        public List<Categoria> ListConverter(List<DTOCategoria> lista)
        {
            var convertedList = new List<Categoria>();
            foreach (var categoria in lista)
            {
                convertedList.Add(new Categoria(categoria.idCategoria, categoria.nombre));
            }
            return convertedList;
        }
    }
}
