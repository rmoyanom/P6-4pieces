using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    class DaoServicios
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


        //Crear servicio
        //Listar N servicios
        //Listar servicios de un usuario
        //Modificar un servicio
        //Dar de baja un servicio
    }
}
