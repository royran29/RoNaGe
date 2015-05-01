using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MahoganyASP.BO;

namespace MahoganyASP.BL.Ordenes
{
    public class OrdenAdmin
    {
        /*_________________________ADMINISTRACIÓN DE ORDENES_________________________ */


        /// <summary>
        /// Permite listar ordenes activas
        /// </summary>
        /// <param name="pidUsuario">Id del usuario</param>
        /// <returns></returns>
        public List<tbOrdenes> ListarOrdenes(int pidUsuario)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                List<tbOrdenes> listOrdenes = new List<tbOrdenes>();

                string estado = "I";

                listOrdenes = (from c in dc.tbOrdenes
                               where c.estado.Contains(estado) && c.idUsuario == pidUsuario
                               select c).ToList();
                return listOrdenes;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        /// <summary>
        /// Listar detalle de orden
        /// </summary>
        /// <param name="pidOrden">Id de la orden</param>
        /// <returns></returns>
        public List<tbDetalleOrden> listarDetalleOrden(int pidOrden)
        {

            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                List<tbDetalleOrden> listDetails = new List<tbDetalleOrden>();

                listDetails = (from c in dc.tbDetalleOrden
                               where c.idOrden == pidOrden
                               select c).ToList();

                return listDetails;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }



        //FILTRAR ORDENES SEGUN UN INTERVALO DE TIEMPO 

        //AGREGAR ORDENES
        public void AgregarOrden(tbOrdenes pOrdenesInsert)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                //dc.tbOrdenes.InsertAllOnSubmit(pOrdenesInsert);

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        /// <summary>
        /// FUNCIÓN QUE PERMITE EDITAR UNA ORDEN 
        /// </summary>
        /// <param name="pOrdenes">UN OBJETO TIPO TBORDENES QUE SERA EDITADO</param>

        public void EditarOrden(tbOrdenes pOrdenes)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbOrdenes orders = dc.tbOrdenes.First(p => p.idOrden == pOrdenes.idOrden);

                orders.idDireccionFacturacion = pOrdenes.idDireccionFacturacion;
                orders.idMetodoPagoUsuario = pOrdenes.idMetodoPagoUsuario;
                orders.estado = orders.estado;
                orders.subTotal = pOrdenes.subTotal;
                orders.totalPagar = pOrdenes.totalPagar;

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        public void EditarDetalleOrden(tbDetalleOrden pDetalleOrdenes)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                tbDetalleOrden dOrders = dc.tbDetalleOrden.First(x => x.idOrden == pDetalleOrdenes.idOrden);

                dOrders.cantidad = pDetalleOrdenes.cantidad;
                dOrders.total = pDetalleOrdenes.total;

                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //ELIMINAR ORDEN 
        public void EliminarOrden(tbOrdenes pOrdenes)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                tbOrdenes eOrder = dc.tbOrdenes.First(c => c.idOrden == pOrdenes.idOrden);

                eOrder.estado = pOrdenes.estado;

                dc.SubmitChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }
    }
}
