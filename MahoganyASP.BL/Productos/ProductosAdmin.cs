using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MahoganyASP.BO;

namespace MOHAGANY.BL
{
    class ProductosAdmin
    {

        /*_________________________ADMINISTRACIÓN DE PRODUCTOS_________________________ */

        /// <summary>
        /// Permite listar los productos segun la subcategoria y descrpción del producto
        /// </summary>
        /// <param name="pIdSubCategoria">id de la subcategoria del producto</param>
        /// <param name="pDescripcionProd">Descripción del producto</param>
        /// <returns></returns>
        public List<tbProductos> ListProductos(int pIdSubCategoria, string pDescripcionProd)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                List<tbProductos> listProductos = (from c in dc.tbProductos
                                                   where c.idSubCategoria == pIdSubCategoria && c.descripcion == pDescripcionProd
                                                   select c).ToList();
                return listProductos;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        /// <summary>
        /// Permite agregar un nuevo producto
        /// </summary>
        /// <param name="pNuevoProducto">Ojeto con los datos de un producto</param>
        public void AgregarProducto(tbProductos pNuevoProducto)
        {
            try 
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                dc.tbProductos.InsertOnSubmit(pNuevoProducto);
                dc.SubmitChanges();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
            
        }


        /// <summary>
        /// Permite editar los datos de un producto
        /// </summary>
        /// <param name="pEditarProducto">Ojeto que posee los datos de un producto</param>
        public void EditarProducto(tbProductos pEditarProducto)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbProductos eProducto = dc.tbProductos.First(c=> c.idProducto==pEditarProducto.idProducto);

                eProducto.descripcion = pEditarProducto.descripcion;
                eProducto.nombre = pEditarProducto.nombre;
                eProducto.precio = pEditarProducto.precio;
                eProducto.precioEnvio = pEditarProducto.precioEnvio;
                eProducto.descuento = pEditarProducto.descuento;
                eProducto.cantidadDisponible = pEditarProducto.cantidadDisponible;
                eProducto.estado = pEditarProducto.estado;
                eProducto.peso = pEditarProducto.peso;
                eProducto.ancho = pEditarProducto.ancho;
                eProducto.alto = pEditarProducto.alto;
                eProducto.largo = pEditarProducto.largo;
                eProducto.pesoEnvio = pEditarProducto.pesoEnvio;
                eProducto.condiciones = pEditarProducto.condiciones;
                eProducto.promedioReviews = pEditarProducto.promedioReviews;
                eProducto.idSubCategoria = pEditarProducto.idSubCategoria;
                eProducto.vendidoPor = pEditarProducto.vendidoPor;
                eProducto.modificadoPor = pEditarProducto.modificadoPor;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
