using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    class DaoCategoria
    {
        private Exception _Errores;
        public Exception Errores
        {
            get
            {
                Exception ex = _Errores;
                _Errores = null;
                return ex;
            }
            set => _Errores = value;
        }

        //Mostrar Categorias
        //Mostrar Categorias de un usuario
        //Crear Categoria
        //Eliminar Categoria
    }
}
