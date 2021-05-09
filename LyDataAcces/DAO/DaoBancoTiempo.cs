using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyBussinesModel;

namespace LyDataAcces.DAO
{
    public class DaoBancoTiempo
    {
        private Exception _Errores;
        public Exception Errores { get => _Errores; set => _Errores = value; }


        //1 Registro de un usuario.
        public bool RegistrarUsuario(LyBussinesModel.DTO.DTORegistroUsuario datos)
        {
            try
            {
                using (ORM.EfBancoTiempo db = new ORM.EfBancoTiempo())
                {
                    ORM.Usuarios nuevoUsuario = new ORM.Usuarios();
                    nuevoUsuario.nombre = datos.Nombre;
                    nuevoUsuario.apellidos = datos.Apellidos;
                    nuevoUsuario.correo = datos.Correo;
                    nuevoUsuario.telefono = datos.Telefono;
                    db.Usuarios.Add(nuevoUsuario);
                    db.SaveChanges();
                    return true;
                }

            }catch(Exception ex)
            {
                _Errores = ex;
                return false;
            }
        }


    }
}
