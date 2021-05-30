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

        private int _Id;
        private String _NombreUsuario;
        private String _Nombre;
        private String _Apellidos;
        private int? _TiempoAcumulado;
        private String _Telefono;
        private String _Correo;
        private DateTime _UltimaFiechaAcceso;
        private int _HorasAcumuladas;


        
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellidos { get => _Apellidos; set => _Apellidos = value; }
        public int TiempoAcumulado { get => (int)_TiempoAcumulado; set => _TiempoAcumulado = value; }
        public string Telefono { get => _Telefono; set => _Telefono = value; }
        public string Correo { get => _Correo; set => _Correo = value; }
        public DateTime UltimaFiechaAcceso { get => _UltimaFiechaAcceso; set => _UltimaFiechaAcceso = value; }
        public List<Servicio> Servicios { get => _Servicios; set => _Servicios = value; }
        public List<Candidatura> Candidaturas { get => _Candidaturas; set => _Candidaturas = value; }
        public List<Categoria> Categorias { get => _Categorias; set => _Categorias = value; }
        public string NombreUsuario { get => _NombreUsuario; set => _NombreUsuario = value; }
        public int Id { get => _Id; set => _Id = value; }
        public int HorasAcumuladas { get => _HorasAcumuladas; set => _HorasAcumuladas = value; }

        public Usuario() { }


        public Usuario(int id,
                        String nombreUsuario,
                        String nombre,
                        String apellidos,
                        int? tiempoAcumulado,
                        String telefono,
                        String correo, int horasAcumuladas)
        {
            this._Id = id;
            this._NombreUsuario = nombreUsuario;
            this._Nombre = nombre;
            this._Apellidos = apellidos;
            this._TiempoAcumulado = tiempoAcumulado;
            this._Telefono = telefono;
            this._Correo = correo;
            this._HorasAcumuladas = horasAcumuladas;
        }


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
