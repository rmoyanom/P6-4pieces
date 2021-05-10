using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyBussinesModel;

namespace LyDataAcces.DAO
{
    class DaoServicios : IDao
    {

        private Exception _Errores;
        Exception IDao.Errores
        {
            get
            {
                Exception ex = _Errores;
                _Errores = null;
                return ex;
            }
            set => _Errores = value;
        }

        /// <summary>
        /// Registra un Servicio en la base de datos
        /// </summary>
        /// <param name="datos">DTOServicios con toda la información del servicio</param>
        /// <returns>Si la operación ha sido correcta true, de lo contrario false y se puede consultar el error desde la propiedad Errores</returns>
        public bool RegistrarServicio(LyBussinesModel.DTO.DTOServicios datos)
        {
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    
                    ORM.Servicios nuevoServicio = new ORM.Servicios();
                    nuevoServicio.idCreador = datos.idCreador;
                    nuevoServicio.titulo = datos.titulo;
                    nuevoServicio.descripcion = datos.descripcion;
                    nuevoServicio.fechaCreacion = DateTime.Now;
                    nuevoServicio.finalizado = false;
                    db.Servicios.Add(nuevoServicio);
                    db.SaveChanges();
                    return true;
                }

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return false;
            }

        }

        //Listar servicios (sólo activos)
        /// <summary>
        /// Petición del listado de Servicios no finalizados
        /// </summary>
        /// <returns>List<Servicio></returns>
        public List<Servicio> ListadoServicios()
        {
            try
            {
                List<Servicio> allServicios = new List<Servicio>();
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    var queryServicios = from b in db.Servicios where b.finalizado == false select b;

                    if(queryServicios.Count() > 0)
                    {
                        return peticionListado(queryServicios.ToList());

                    }
                    else { return null; }

                }

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return null;
            }
        }

        //Listar N servicios (sólo activos)
        /// <summary>
        /// Devuelve N Servicios. Si p != null devuelve N servicios a partir de la página p
        /// NOTA: La p equivale a la página a mostrar, por lo que en la función siempre se le restará 1 
        /// porque para la página 1 se muestran los N primeros y no se salta ningún resultado.
        /// </summary>
        /// <param name="n">Número de servicios a mostrar</param>
        /// <param name="p">Página Actual del registro</param>
        /// <returns>Listado de Servicios </returns>
        public List<Servicio> ListadoServicios(int n, int? p)
        {
            try
            {
                List<Servicio> allServicios = new List<Servicio>();
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    var queryServicios = from b in db.Servicios where b.finalizado == false select b;

                    if (queryServicios.Count() > 0)
                    {

                        int page = p == null || p < 0 ? 0 : (int) p - 1;
                        var queryResult = page == 0 ? queryServicios.Take(n).ToList() : queryServicios.Skip(n * page).Take(n).ToList();

                        return peticionListado(queryResult);
                    }
                    else { return null; }

                }

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return null;
            }
        }
        //Listar servicios de un usuario (Todos)
        /// <summary>
        /// Listado de Servicios de un usuario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public List<Servicio> ListadoServiciosUsuario(Usuario usuario)
        {
            try
            {
                List<Servicio> allServicios = new List<Servicio>();
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    var queryServicios = from b in db.Servicios where b.idCreador == usuario.Id select b;

                    if (queryServicios.Count() > 0)
                    {
                        return peticionListado(queryServicios.ToList());
                    }
                    else { return null; }

                }

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return null;
            }
        }

        /// <summary>
        /// Método para realizar la petición del listado que se repite en los métodos para listar todos o listar de user
        /// </summary>
        /// <param name="queryServicios"></param>
        /// <returns></returns>
        internal List<Servicio> peticionListado(List<ORM.Servicios> queryResult)
        {
            List<Servicio> allServicios = new List<Servicio>();
            DaoUsuario _DaoUsuario = new DaoUsuario();
            DaoCategoria _DaoCategoria = new DaoCategoria();
            // Faltan CATEGORIAS
            //DaoCandidaturas _DaoCandidatura = new DaoCandidaturas();
            try
            {

                foreach (ORM.Servicios dbservicios in queryResult)
                {
                    Usuario user = _DaoUsuario.GetPerfilUsuario((int)dbservicios.idCreador);

                    Servicio servicio = new Servicio(dbservicios.titulo,
                        dbservicios.descripcion,
                        dbservicios.fechaCreacion,
                        dbservicios.id,
                        user,
                        (bool)dbservicios.finalizado);
                    

                    //Recogida de las categorias
                    /*
                     * # Categorias no tiene el método correcto para devolver el listado de categorias de un servicio.
                    servicio.Categorias = new List<Categoria>();
                    List<Categoria> categorias = _DaoCategoria.LoadCategoriaServicio(servicio);
                    foreach (Categoria categoria in categorias)
                    {
                        servicio.Categorias.Add(categoria);
                    }
                    // Faltan CANDIDATURAS
                    * ## No se ha desarrollado el DAO Candidaturas

                    servicio.Candidaturas = new List<Candidatura>();
                    List<Candidatura> candidaturas = _DaoCandidatura.LoadCandidaturasServicio(servicio);
                    foreach (List<Candidatura> candidatura in candidaturas)
                    {
                        servicio.Candidaturas.Add(candidatura);
                    }
                     */
                    allServicios.Add(servicio);
                }

                return allServicios;

            }
            catch (Exception ex)
            {
                _Errores = ex;
                return null;
            }
        }
        //Modificar un servicio
        //Dar de baja un servicio (Finalizar)
    }
}
