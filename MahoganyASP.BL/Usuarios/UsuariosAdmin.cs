using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MahoganyASP.BO;

namespace MahoganyASP.BL.Usuarios
{
   public class UsuariosAdmin
    {
        public List<tbUsuarios> ListUsuarios(int pidUsuario)
        {

            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();
                List<tbUsuarios> users = new List<tbUsuarios>();

                users = (from p in dc.tbUsuarios
                         where p.idUsuario == pidUsuario
                         select p).ToList();

                return users;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }


        //AGREGAR USUARIO

        public void AgregarUsuario(tbUsuarios pNuevoUsuario)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                //Si no existe nadie con este e-mail, de lo contrario se informa que el correo esta siendo usado
                if (dc.tbUsuarios.First(i => i.correoElectronico.Contains(pNuevoUsuario.correoElectronico)) == null)
                {
                    //dc.tbUsuarios.InsertAllOnSubmit(pNuevoUsuario); //ESTO ME DA ERROR NO SE PQ PUTAS                   
                    dc.SubmitChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        }

        //EDITAR USUARIO

        public void EditarUsuario(tbUsuarios pEditarUsuario)
        {
            try
            {
                DBMahoganyDataContext dc = new DBMahoganyDataContext();

                tbUsuarios eUsers = dc.tbUsuarios.First(x => x.idUsuario == pEditarUsuario.idUsuario);

                eUsers.nombreCompleto = pEditarUsuario.nombreCompleto;
                eUsers.correoElectronico = pEditarUsuario.correoElectronico;
                eUsers.contrasena = pEditarUsuario.contrasena;
                eUsers.telefono1 = pEditarUsuario.telefono1;
                eUsers.telefono2 = pEditarUsuario.telefono2;
                eUsers.tipoUsuario = pEditarUsuario.tipoUsuario;

                dc.SubmitChanges();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message.ToString());
            }
        } 
    }
}
