using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    class DaoCategoria: IDao
    {
        private Exception _Errores;
        Exception IDao.Errores
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
