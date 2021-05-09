﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOUsuario
    {
        public String NombreUsuario;
        public String Nombre;
        public String Apellidos;
        public String Telefono;
        public String Correo;
        public String HasContraseña;
        
        public DTOUsuario()
        {

        }

        public DTOUsuario(String nombreUsuario, String nombre,String apellidos,String telefono,String correo,String hasContraseña)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Correo = correo;
            this.HasContraseña = hasContraseña;
        }
    }
}