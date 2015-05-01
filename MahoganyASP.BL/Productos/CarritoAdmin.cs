using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MahoganyASP.BO;

namespace MOHAGANY.BL
{
    class CarritoAdmin
    {
        /*_________________________ADMINISTRACIÓN DE CARRITO_________________________ */

        /// <summary>
        /// Permite agregar un nuevo carrito para un usuario
        /// </summary>
        /// <param name="pNuevoCarrito">Ojeto con los datos de un carrito</param>
        public void AgregarCarrito(tbCarrito pNuevoCarrito)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                dc.tbCarrito.InsertOnSubmit(pNuevoCarrito);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }


        /// <summary>
        /// Permite editar la cantidad total del carrito
        /// </summary>
        /// <param name="pEditarCarrito">Ojeto que posee los datos de un carrito</param>
        public void EditarProducto(tbCarrito pEditarCarrito)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbCarrito eCarrito = dc.tbCarrito.First(c => c.idCarrito == pEditarCarrito.idCarrito);

                eCarrito.CantidadTotal = pEditarCarrito.CantidadTotal;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        /*_________________ADMINISTRACIÓN DE PRODUCTOS DEL CARRITO__________________ */

        /// <summary>
        /// Permite listar loS productos incluidos en el carrito
        /// </summary>
        /// <param name="pIdCarrito">id del carrito</param>
        /// <returns></returns>
        public List<tbProductosCarrito> ListProductosCar(int pIdCarrito)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                List<tbProductosCarrito> listProdCarrito = (from c in dc.tbProductosCarrito
                                                           where c.idProductoCarrito == pIdCarrito
                                                           select c).ToList();
                return listProdCarrito;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }

        /// <summary>
        /// Permite agregar un nuevo producto al carrito
        /// </summary>
        /// <param name="pNuevoProductoCar">Ojeto con los datos de un producto</param>
        public void AgregarProductoCar(tbProductosCarrito pNuevoProductoCar)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                dc.tbProductosCarrito.InsertOnSubmit(pNuevoProductoCar);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }

        }


        /// <summary>
        /// Permite editar la cantidad de un producto del carrito
        /// </summary>
        /// <param name="pEditarProductoCar">Ojeto que posee los datos de un producto</param>
        public void EditarProducto(tbProductosCarrito pEditarProductoCar)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbProductosCarrito eProductoCar = dc.tbProductosCarrito.First(c => c.idCarrito == pEditarProductoCar.idCarrito &&
                                                                                   c.idProducto == pEditarProductoCar.idProducto);

                eProductoCar.cantidad = pEditarProductoCar.cantidad;

               
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        /// <summary>
        /// Permite eliminar un producto del carrito
        /// </summary>
        /// <param name="pEliminarProdCar">Ojeto que posee los datos de un producto</param>
        public void EliminarProducto(tbProductosCarrito pEliminarProdCar)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbProductosCarrito eProductoCar = dc.tbProductosCarrito.First(c => c.idCarrito == pEliminarProdCar.idCarrito &&
                                                                                   c.idProducto == pEliminarProdCar.idProducto);

                dc.tbProductosCarrito.DeleteOnSubmit(eProductoCar);
                dc.SubmitChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
