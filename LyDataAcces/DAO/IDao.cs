using LyBussinesModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    /// <summary>
    /// Interfaz para controlar los errores de los daos
    /// </summary>
    public interface IDao
    {
        Exception Errores
        {
            get;
            set;
        }

        //bool RegistrarServicio(DTOServicios datos);
    }
}
