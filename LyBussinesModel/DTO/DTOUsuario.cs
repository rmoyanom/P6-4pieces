using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel.DTO
{
    public class DTOUsuario
    {
        public int id;
        public String NombreUsuario;
        public String Nombre;
        public String Apellidos;
        public String Telefono;
        public String Correo;
        public String HasContraseña;
        public int HorasAcumuladas;
        public List<DTOCategoria> Categorias;

        public DTOUsuario()
        {

        }
        public DTOUsuario(int id)
        {
            this.id = id;
        }


        public DTOUsuario(String nombreUsuario, String nombre, String apellidos, String telefono, String correo)
        {
            this.NombreUsuario = nombreUsuario;
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Telefono = telefono;
            this.Correo = correo;
        }

        public DTOUsuario(String nombreUsuario,
            String nombre,
            String apellidos,
            String telefono,
            String correo,
            String hasContraseña) : this(nombreUsuario, nombre, apellidos, telefono, correo)
        {
            this.HasContraseña = hasContraseña;
        }
        public DTOUsuario(String nombreUsuario, 
            String nombre,
            String apellidos,
            String telefono,
            String correo,
            int horasAcumulaas) : this(nombreUsuario, nombre, apellidos, telefono, correo)
        {
            this.HorasAcumuladas = horasAcumulaas;
        }

        public DTOUsuario(String nombreUsuario, 
            String nombre, 
            String apellidos, 
            String telefono, 
            String correo, 
            String hasContraseña,
            List<DTOCategoria> categorias) : this(nombreUsuario, nombre, apellidos, telefono, correo, hasContraseña)
        {
            
            this.HasContraseña = hasContraseña;
            this.Categorias = categorias;
        }
    }
}
