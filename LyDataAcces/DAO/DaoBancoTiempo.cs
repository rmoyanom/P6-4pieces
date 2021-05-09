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
        /// <summary>
        /// Registra un usuario en la base de datos
        /// </summary>
        /// <param name="datos">DTOUsuario con toda la información del usuario</param>
        /// <returns>Si la operación ha sido correcta true, de lo contrario false y se puede consultar el error desde la propiedad Errores</returns>
        public bool RegistrarUsuario(LyBussinesModel.DTO.DTOUsuario datos)
        {
            try
            {
                using (ORM.EfBancoTiempo db = new ORM.EfBancoTiempo())
                {
                    //Se realiza una busqueda del nombre en BD
                    var usuario = from b in db.Usuarios
                                  where b.nombreUsuario == datos.NombreUsuario
                                  select b;

                    //Impeide registrar un usuario que ya existe.
                    if(usuario != null)
                    {
                        throw new Exception("El usuario ya existe, escoja otro nombre");
                    }
                    
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
