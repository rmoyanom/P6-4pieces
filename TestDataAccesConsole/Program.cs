using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyDataAcces;
using LyBussinesModel;


namespace TestDataAccesConsole
{
    class Program
    {



        static void Main(string[] args)
        {
            bool resultados = false;
            LyDataAcces.DAO.DaoUsuario _DaoUsuario = new LyDataAcces.DAO.DaoUsuario();
            LyDataAcces.DAO.DaoCategoria _DaoCategoria = new LyDataAcces.DAO.DaoCategoria();
   

            const int ESPACIOS_LINEAS = 45;
            //Inicio de Aplicación de test
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*"+"Iniciando Test de Persistencia de datos".PadRight(ESPACIOS_LINEAS, '-')+"*");
            Console.ForegroundColor = ConsoleColor.White;

            #region "Admin"
            VerificarOperacion("Crear Categoría Informática",
                _DaoCategoria.CrearCategoria("Informática"),
                _DaoCategoria);


            VerificarOperacion("Crear Categoría Electricista",
                _DaoCategoria.CrearCategoria("Electricista"),
                _DaoCategoria);


            VerificarOperacion("Crear Categoría Voluntariado",
                _DaoCategoria.CrearCategoria("Voluntariado"),
                _DaoCategoria);


            List<Categoria> categorias = new List<Categoria>();
            categorias=_DaoCategoria.GetAllCategorias();

            VerificarOperacion("Descarga todas las Categorías",
               categorias.Count() > 0,
               _DaoCategoria);

            if(categorias.Count() > 0)
                VerificarOperacion("Eliminar Categoría Voluntariado",
               _DaoCategoria.EliminarCategoria(categorias[categorias.Count()-1]),
               _DaoCategoria);
 
            VerificarOperacion("Obtener todos los usuarios",
                _DaoUsuario.GetAllUsuarios().Count>0,
                _DaoCategoria);
            #endregion

            #region "Aplicación inicial"
            //1.Registrar Usuario
            Console.WriteLine("Registrando un nuevo usuario");


            

            resultados = _DaoUsuario.RegistrarUsuario( new LyBussinesModel.DTO.DTOUsuario("Usuario2",
                                                                                            "nuevoUser", 
                                                                                            "prueba", 
                                                                                            "123456789", 
                                                                                            "correofalso@falso.com", 
                                                                                            Usuario.CreateHash("Usuario2","1234")));

            VerificarOperacion("RegistroUsuario",resultados, _DaoUsuario);


            //2.Iniciar Sesión
            int idUsuario = _DaoUsuario.IniciarSesion("Usuario2", "1234");
            resultados = idUsuario > -1;
            VerificarOperacion("IniciarSesion",resultados, _DaoUsuario);

            if(resultados)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t"+"Inicio de sesión correcta");
                Console.ResetColor();
            }else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t"+"Fallo al iniciar sesión");
                Console.ResetColor();
            }
            #endregion



            #region "Mi Perfil"
            //3.Visualizar perfil de usuario.
            Console.WriteLine("Visualizando perfil:");
            Usuario user = _DaoUsuario.GetPerfilUsuario(idUsuario);
            VerificarOperacion("Visualizando perfil usuario", user != null, _DaoUsuario);

            //4.Modificar perfil de usuario.
            Console.WriteLine("Modificando datos de usuario:");
            VerificarOperacion("Modificación datos",resultados, _DaoUsuario);

            VerificarOperacion("Descargando Categorias de Usuario",_DaoCategoria.LoadCategoriaUsuario(user),_DaoUsuario);

            //5.Asignar Categorias.
            List<LyBussinesModel.DTO.DTOCategoria> categoriasApuntadas = new List<LyBussinesModel.DTO.DTOCategoria>();

            //Se añaden las 2 primeras categorias
            Console.WriteLine("Modificando categorías del usuario:");
            categoriasApuntadas.Add(new LyBussinesModel.DTO.DTOCategoria(1));
            categoriasApuntadas.Add(new LyBussinesModel.DTO.DTOCategoria(2));

            LyBussinesModel.DTO.DTOUsuario cambioUsuario = new LyBussinesModel.DTO.DTOUsuario(user.Id);
            VerificarOperacion("Asignacion de categorias", _DaoUsuario.ModificarUsuario(cambioUsuario), _DaoUsuario);
            #endregion

            #region "Mi Cuenta"
            //6.Visualizar historial de Operaciones.
            //7.Visualizar detalles de operaciones
            //8.Visualizar Saldo.
            //9.Acceder a Anuncios propios
            //9.1 Visualizar


            //9.2 Modificar
            #endregion

            #region "Tablón de anuncios"
            //10. Visualizar todos los anuncios
            //11. Publicar un Servicio.
            //12. Anular un servicio.
            #endregion

            #region "Anuncios activos"
            //13 Editar anuncio
            //14 Visualizar perfil de candidatos.
            //15 Selección candidatura
            //16 Asignar tiempo empleado de servicio
            //17 Valorar a usuario
            //18 Eliminar anuncio
            #endregion

            #region "Candidatura Activas"
            //19 Visualizar anuncio
            //20 visualizar numero de candidatos.
            //21 Enviar Consulta.
            //22 Anular candadatura
            #endregion

            //Fin de aplicació, para no salir y permitir que se lean los datos.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*" + "Test Finalizado".PadRight(ESPACIOS_LINEAS, '-') + "*");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Pulse ENTER para finalizar...");
            Console.ReadLine();
        }
        static void VerificarOperacion(String funcion,bool resultados, LyDataAcces.DAO.IDao dao)
        {
            if (resultados)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\t"+funcion+" realizado con Exito");
                Console.ResetColor();
            }else{
                Exception error = dao.Errores;
                if (error != null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t"+"Error al procesar " + funcion +":"+ error.Message);
                    Console.ResetColor();
                }
            }
        }



    }
}
