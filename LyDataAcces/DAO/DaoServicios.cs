using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LyBussinesModel;
using LyBussinesModel.DTO;

namespace LyDataAcces.DAO
{


    public class DaoServicios : IDao
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

                    ORM.Servicios nuevoServicio = new ORM.Servicios
                    {
                        idCreador = datos.idCreador,
                        titulo = datos.titulo,
                        descripcion = datos.descripcion,
                        fechaCreacion = DateTime.Now,
                        finalizado = false
                    };
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
                        return PeticionListado(queryServicios.ToList());

                    }else {
                        return null; 
                    }

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

                        return PeticionListado(queryResult);
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
                        return PeticionListado(queryServicios.ToList());
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

        public DTOServiciosDetalles GetServiciosDetalles(int idServicio, int idUsuarioQueQuiereSolicitarla = -1)
        {
            try
            {
       
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    DTOServiciosDetalles resultados = null;

                    var queryServicios = from b in db.Servicios where b.id == idServicio select b;

                    if (queryServicios.Count() > 0)
                    {

                        DaoUsuario daoUser = new DaoUsuario();
                        DTOUsuario creador = null;

                        int idCreador = -1;

                        ORM.Servicios sv = queryServicios.FirstOrDefault();
                        if(sv.idCreador != null)
                        {
                            idCreador = (int)sv.idCreador;
                            creador = daoUser.GetDetellaUsuario(idCreador);
                        }
                        
                        int cantidadServicios = 0;
                        ResultadoDetalleServicioPuedeSolicitarse puedeSolicitarse =ResultadoDetalleServicioPuedeSolicitarse.PUEDE;


                        if(sv.Candidatura != null && sv.Candidatura.Count() > 0)
                        {
                            sv.Candidatura.Count();
                            //TODO si tiene candidaturas, se recorren las que esten con estado finalizada y se obtiene
                            //La puntuación para realizar media

                            var candidaturas = sv.Candidatura.Where(x => x.idUsuario == idUsuarioQueQuiereSolicitarla);
                            //Si la función recibe la id de usuario que quiere solicitar se verifica si ya esta solicitada
                            foreach (ORM.Candidatura candidatura in candidaturas)
                            {
                                if((candidatura.estado == (int)EstadoCandidatura.PENDIENTE
                                    ||  candidatura.estado == (int)EstadoCandidatura.ACEPTADA ))
                                {
                                    puedeSolicitarse = ResultadoDetalleServicioPuedeSolicitarse.YA_SOLICITADA;
                                    break;
                                }

                            }

                        }
                        
                        if(creador.HorasAcumuladas <= 0)
                        {
                            puedeSolicitarse = ResultadoDetalleServicioPuedeSolicitarse.HORAS_INSUFICIENTES;
                        }

                        
                        resultados = new DTOServiciosDetalles
                        {
                            id = sv.id,
                            Titulo = sv.titulo,
                            Descripcion = sv.descripcion,
                            CantidadSolicitudes = cantidadServicios,
                            FechaDeInicio = sv.fechaCreacion,
                            SePuedeSolicitar = puedeSolicitarse
                        };

                        if(idCreador > 0)
                        {
                            resultados.Creador = creador;
                        }

                        resultados.Categorias = new List<DTOCategoria>();

                        if(sv.Categorias != null  && sv.Categorias.Count() > 0)
                        {
                            foreach (ORM.Categorias categoria in sv.Categorias)
                            {
                                resultados.Categorias.Add(new DTOCategoria(categoria.id, categoria.nombre));
                            }

                        }

                        return resultados;
                    }else{ 
                        return null; 
                    }

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
        private List<Servicio> PeticionListado(List<ORM.Servicios> queryResult)
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
                                                            (bool)dbservicios.finalizado
                                                    )
                    {


                        //Recogida de las categorias

                        //* # Categorias no tiene el método correcto para devolver el listado de categorias de un servicio.
                        Categorias = new List<Categoria>()
                    };
                    _DaoCategoria.LoadCategoriaServicio(servicio);

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
