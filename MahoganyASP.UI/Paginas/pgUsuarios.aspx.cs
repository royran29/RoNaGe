using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using MahoganyASP.BL.Usuarios;
using MahoganyASP.BO;

namespace MahoganyASP.UI.Paginas
{
    public partial class pgUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbkEdit_Command(object sender, CommandEventArgs e)
        {
            UsuariosAdmin usuariosAdmin = new UsuariosAdmin();
            tbUsuarios usuarios = new tbUsuarios();

            try
            {
                usuarios.nombreCompleto = ((TextBox)fvUsuarios.FindControl("nombreCompletoTextBox")).Text;
                usuarios.telefono1 = ((TextBox)fvUsuarios.FindControl("telefono1TextBox")).Text;
                usuarios.telefono2 = ((TextBox)fvUsuarios.FindControl("telefono2TextBox")).Text;
                usuarios.correoElectronico = ((TextBox)fvUsuarios.FindControl("correoElectronicoTextBox")).Text;
                usuarios.contrasena = ((TextBox)fvUsuarios.FindControl("contrasenaTextBox")).Text;
                usuarios.tipoUsuario = ((TextBox)fvUsuarios.FindControl("tipoUsuarioTextBox")).Text;
                usuarios.idUsuario = Convert.ToInt32(((HiddenField)fvUsuarios.FindControl("idUsuarioHiddenFiels")).Value);

                usuariosAdmin.EditarUsuario(usuarios);

            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btn_Click(object sender, EventArgs e)
        {
            fvUsuarios.ChangeMode(FormViewMode.Edit);
        }
    }
}