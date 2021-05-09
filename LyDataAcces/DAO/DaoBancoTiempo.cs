﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyBussinesModel;

namespace LyDataAcces.DAO
{
    public class DaoBancoTiempo
    {
        private Exception _Errores;
        public Exception Errores {
            get
            {
                Exception ex = _Errores;
                _Errores = null;
                return ex;
            }
            set => _Errores = value; 
        }


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
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda del nombre en BD
                    var query = from b in db.Usuarios
                                  where b.nombreUsuario == datos.NombreUsuario
                                  select b;



                    //Impide registrar un usuario que ya existe.
                    Debug.Write(query.Count().ToString());

                  
                    if (query.Count() > 0)
                    {
                        throw new Exception("El usuario ya existe, escoja otro nombre");
                    }
                    
                    ORM.Usuarios nuevoUsuario = new ORM.Usuarios();
                    nuevoUsuario.nombreUsuario = datos.NombreUsuario;
                    nuevoUsuario.nombre = datos.Nombre;
                    nuevoUsuario.apellidos = datos.Apellidos;
                    nuevoUsuario.correo = datos.Correo;
                    nuevoUsuario.telefono = datos.Telefono;
                    nuevoUsuario.hasPassword = datos.HasContraseña;
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

        /// <summary>
        /// Verificar usuario y clave para loguear usuario.
        /// </summary>
        /// <param name="usuario">Usuario.</param>
        /// <param name="password"> Clave en texto claro</param>
        /// <returns>Devuelve Usuario, que coincida con la clave introducida, en el caso de que sea erroneo el acceso, la funcion devuelve null</returns>
        public Usuario IniciarSesion(String usuario, String password)
        {
            Usuario userLogueado = new Usuario();
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    String hash = Usuario.CreateHash(usuario, password);
                    ORM.Usuarios userEncontrado;
                    //Se realiza una busqueda del nombre en BD
                    var query = from b in db.Usuarios
                                  where b.hasPassword == hash
                                select b;

                  

                    //Impide registrar un usuario que ya existe.
                    if (!(query.Count() > 0))
                    {
                        return null;
                    }
                    else
                    {
                        userEncontrado = (ORM.Usuarios)query.First();

                        if(userEncontrado != null)
                        {
                            return new Usuario(userEncontrado.id,
                                            userEncontrado.nombreUsuario,
                                             userEncontrado.nombre,
                                             userEncontrado.apellidos,
                                             userEncontrado.tiempoAcumulado,
                                             userEncontrado.telefono,
                                             userEncontrado.correo);
                        }else{
                            return null;
                        }
                        

                    }
                    
                    

 
                }

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return null;
            }

        }
    }
}
