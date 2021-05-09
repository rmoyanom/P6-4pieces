using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel
{
    public class Categoria
    {
        private int _Id;
        private String _Nombre;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public int Id { get => _Id; set => _Id = value; }
    }
}
