using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTORegistroUsuario
    {
        public String Nombre;
        public String Apellidos;
        public String Telefono;
        public String Correo;
        public String HasContraseña;

        public DTORegistroUsuario()
        {

        }

        public DTORegistroUsuario(String nombre,String apellidos,String telefono,String correo,String hasContraseña)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Correo = correo;
            this.HasContraseña = hasContraseña;
        }
    }
}
