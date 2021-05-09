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
            LyDataAcces.DAO.DaoBancoTiempo _Dao = new LyDataAcces.DAO.DaoBancoTiempo();
            
            const int ESPACIOS_LINEAS = 45;
            //Inicio de Aplicación de test
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("*"+"Iniciando Test de Persistencia de datos".PadRight(ESPACIOS_LINEAS, '-')+"*");
            Console.ForegroundColor = ConsoleColor.White;


            //Prueba..



            #region "Aplicación inicial"
            //1.Registrar Usuario
            Console.WriteLine("Registrando un nuevo usuario");

            resultados = _Dao.RegistrarUsuario( new LyBussinesModel.DTO.DTORegistroUsuario("nuevoUser", 
                                                                                                "prueba", 
                                                                                                "123456789", 
                                                                                                "correofalso@falso.com", 
                                                                                                "ninguna"));

            VerificarOperacion(resultados, _Dao);


            //2.Iniciar Sesión

            #endregion


            #region "Mi Perfil"
            //3.Visualizar perfil de usuario.
            //4.Modificar perfil de usuario.
            //5.Asignar Categorias.
            #endregion

            #region "Mi Cuenta"
            //6.Visualziar historial de Operaciones.
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
        static void VerificarOperacion(bool resultados, LyDataAcces.DAO.DaoBancoTiempo dao)
        {
            if (resultados)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Registrado con Exito");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se ha producido un error:");
                Console.ResetColor();
                Console.WriteLine(dao.Errores.Message);
            }
        }

    }
}
