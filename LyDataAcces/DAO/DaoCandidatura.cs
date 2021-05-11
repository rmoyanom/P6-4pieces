using LyBussinesModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    class DaoCandidatura: IDao
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
        /// Crear candidatura
        /// </summary>
        /// <param name="candidatura"></param>
        /// <returns></returns>
        public bool Crearcandidatura(LyBussinesModel.DTO.DTOCandidatura candidatura)
        {

            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    
                    ORM.Candidatura newcandidatura = new ORM.Candidatura();
                    newcandidatura.estado = (int?)LyBussinesModel.Candidatura.EstadoCandidatura.PENDIENTE;
                    newcandidatura.fechaInscripcion = candidatura.FechaInscripcion;
                    newcandidatura.idServicio = candidatura.Servicio.Id;
                    newcandidatura.idUsuario = candidatura.Candidato.Id;
                    newcandidatura.horasRequeridas = candidatura.HorasRequeridas;
                    newcandidatura.fechaInscripcion = candidatura.FechaInscripcion;
                    newcandidatura.Candidatura_Finalizada.valoracion = candidatura.Valoracion;
                    newcandidatura.Candidatura_Finalizada.comentarios = candidatura.Comentarios;
                    newcandidatura.Candidatura_Finalizada.horasGanadas = candidatura.HorasGanadas;
                    newcandidatura.Candidatura_Aceptada.fechaAceptacion = candidatura.FechaAceptacion;
                    newcandidatura.Candidatura_Aceptada.fechaAcordadaServicio = candidatura.FechaAcordadaServicio;
                    newcandidatura.Candidatura_Aceptada.horasAcordadas = candidatura.HorasAcordadas;
                    newcandidatura.Candidatura_Cancelada.fechaCancelacion = candidatura.FechaDeCancelacion;
                    newcandidatura.Candidatura_Cancelada.motivoCancelacion = candidatura.MotivoCancelacíon;
                    newcandidatura.Candidatura_Cancelada.autorCancelado = (int?)candidatura.AutorCancelado;

                    db.Candidatura.Add(newcandidatura);
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

        /// <summary>
        /// Cancelar candidatura
        /// </summary>
        /// <param name="idCandidatura"></param>
        /// <returns></returns>
        public bool CancelarCandidatura(int idCandidatura,Candidatura.CanceladoPor canceladopor,String motivo)
        {
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda de la categoria en BD
                    var query = db.Candidatura.Find(idCandidatura);
                    
                    if (query == null)
                    {
                        _Errores = new Exception("No se ha encontrado el id buscado");
                        return false;
                    }

                    //para cancelar la candidatura no puede estar finalizada
                    Candidatura.EstadoCandidatura estadoAnterior = (Candidatura.EstadoCandidatura)query.estado;
                    if (estadoAnterior == Candidatura.EstadoCandidatura.ACEPTADA || 
                        estadoAnterior == Candidatura.EstadoCandidatura.PENDIENTE)
                    {
                        _Errores = new Exception("La candidatura se encuentra "+ estadoAnterior.ToString());
                        return false;
                    }

                    ORM.Candidatura_Cancelada cancelacion = new ORM.Candidatura_Cancelada();
                    query.estado = (int?)Candidatura.EstadoCandidatura.CANCELADA;
                    query.Candidatura_Cancelada = cancelacion;
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

        /// <summary>
        /// Aceptar Candidatura
        /// </summary>
        /// <param name="idCandidatura"></param>
        /// <param name="fechacordada"></param>
        /// <param name="horascaordadas"></param>
        /// <returns></returns>
        public bool Aceptarcandidatura(int idCandidatura, int horascaordadas, DateTime fechacordada)
        {
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda de la categoria en BD
                    var query = db.Candidatura.Find(idCandidatura);

                    if (query == null)
                    {
                        _Errores = new Exception("No se ha encontrado el id buscado");
                        return false;
                    }

                    Candidatura.EstadoCandidatura estadoAnterior = (Candidatura.EstadoCandidatura)query.estado;
                    if (estadoAnterior != Candidatura.EstadoCandidatura.PENDIENTE)
                    {
                        _Errores = new Exception("La candidatura se encuentra " + estadoAnterior.ToString());
                        return false;
                    }

                    ORM.Candidatura aceptcandidatura = new ORM.Candidatura();
                    ORM.Candidatura_Aceptada aceptada = new ORM.Candidatura_Aceptada();
                    aceptcandidatura.idUsuario = idCandidatura;
                    aceptcandidatura.estado = (int?)Candidatura.EstadoCandidatura.FINALIZADA;
                    aceptada.fechaAceptacion = DateTime.Now;
                    aceptada.horasAcordadas = horascaordadas;
                    aceptada.fechaAcordadaServicio = fechacordada;


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

        public bool FinalizarCandidatura(int idCandidatura, int horasGanadas, int valoracion, String comentarios)
        {
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda de la categoria en BD
                    var query = db.Candidatura.Find(idCandidatura);

                    if (query == null)
                    {
                        _Errores = new Exception("No se ha encontrado el id buscado");
                        return false;
                    }

                    Candidatura.EstadoCandidatura estadoAnterior = (Candidatura.EstadoCandidatura)query.estado;
                    if (estadoAnterior != Candidatura.EstadoCandidatura.ACEPTADA)
                    {
                        _Errores = new Exception("La candidatura se encuentra " + estadoAnterior.ToString());
                        return false;
                    }


                    ORM.Candidatura candidaturafinalizada = new ORM.Candidatura();
                    ORM.Candidatura_Finalizada finalizada = new ORM.Candidatura_Finalizada();
                    candidaturafinalizada.estado = (int)Candidatura.EstadoCandidatura.FINALIZADA;
                    finalizada.valoracion = valoracion;
                    finalizada.comentarios = comentarios;
                    finalizada.horasGanadas = horasGanadas;

                    query.Candidatura_Finalizada = finalizada;
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

    }
}
