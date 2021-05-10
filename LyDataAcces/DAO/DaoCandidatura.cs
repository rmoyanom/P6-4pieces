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
        //Crear candidatura

        public bool CrearCandicatura(LyBussinesModel.DTO.DTOCandidatura candicatura)
        {

            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda del nombre en BD
                    var query = from b in db.Usuarios
                                where b.id == candicatura.Id
                                select b;



                    //Impide registrar un usuario que ya existe.
                    Debug.Write(query.Count().ToString());


                    if (query.Count() > 0)
                    {
                        throw new Exception("La candicatura ya existe");
                    }

        ORM.Candidatura newcandicatura = new ORM.Candidatura();
                    //esta puesto como un string estado en la base de datos y no int
                    newcandicatura.estado = candicatura.Estado;
                    newcandicatura.fechaInscripcion = candicatura.FechaInscripcion;
                    newcandicatura.idServicio = candicatura.Servicio.Id;
                    newcandicatura.idUsuario = candicatura.Candidato.Id;
                    newcandicatura.horasRequeridas = candicatura.HorasRequeridas;
                    newcandicatura.fechaInscripcion = candicatura.FechaInscripcion;
                    newcandicatura.Candidatura_Finalizada.valoracion = candicatura.Valoracion;
                    newcandicatura.Candidatura_Finalizada.comentarios = candicatura.Comentarios;
                    newcandicatura.Candidatura_Finalizada.horasGanadas = candicatura.HorasGanadas;
                    newcandicatura.Candidatura_Aceptada.fechaAceptacion = candicatura.FechaAceptacion;
                    newcandicatura.Candidatura_Aceptada.fechaAcordadaServicio = candicatura.FechaAcordadaServicio;
                    //Esta puesto como un datetime en la base de datos y no int
                    newcandicatura.Candidatura_Aceptada.horasAcordadas = candicatura.HorasAcordadas;
                    newcandicatura.Candidatura_Cancelada.fechaCancelacion = candicatura.FechaDeCancelacion;
                    newcandicatura.Candidatura_Cancelada.motivoCancelacion = candicatura.MotivoCancelacíon;
                    //No esta en la base de datos pero si esta delcarados en candidatura
                    newcandicatura.Candidatura_Cancelada.AutorCancelado = candicatura.MotivoCancelacíon;

                    db.Candidatura.Add(newcandicatura);
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
        //Cancelar candidatura
        //Aceptar candidatura

    }
}
