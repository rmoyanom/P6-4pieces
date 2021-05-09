using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LyBussinesModel
{
    public class Usuario
    {
       
        private List<Servicio> _Servicios;
        private List<Candidatura> _Candidaturas;
        private List<Categoria> _Categorias;
        private String _Nombre;
        private String _Apellidos;
        private int _TiempoAcumulado;
        private String _Telefono;
        private String _Correo;
        private String _HasContraseña;
        private DateTime _UltimaFiechaAcceso;

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public int TiempoAcumulado { get => _TiempoAcumulado; set => _TiempoAcumulado = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public string HasContraseña { get => _HasContraseña; set => _HasContraseña = value; }
        public DateTime UltimaFiechaAcceso { get => _UltimaFiechaAcceso; set => _UltimaFiechaAcceso = value; }
        internal List<Servicio> Servicios { get => _Servicios; set => _Servicios = value; }
        internal List<Candidatura> Candidaturas { get => _Candidaturas; set => _Candidaturas = value; }
        internal List<Categoria> Categorias { get => _Categorias; set => _Categorias = value; }


        public static String CreateHash(String usuario,string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(usuario+password));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }


}
