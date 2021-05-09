using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LyDataAcces.DAO
{
    public class DaoCategoria: IDao
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



        //Mostrar Categorias
        //Mostrar Categorias de un usuario
        //Crear Categoria
        public bool CrearCategoria(String nombre)
        {
            try
            {
                using (ORM.EFBancoTiempo db = new ORM.EFBancoTiempo())
                {
                    //Se realiza una busqueda del nombre en BD
                    var query = from b in db.Categorias
                                where b.nombre == nombre
                                select b;


                    if (query.Count() > 0)
                    {
                        _Errores = new Exception("Esta categoría ya existe");
                        return false;
                    }

                    ORM.Categorias nuevaCategoria = new ORM.Categorias();
                    nuevaCategoria.nombre = nombre;
                    db.Categorias.Add(nuevaCategoria);
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
        //Eliminar Categoria
    }
}
