<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="pgUsuarios.aspx.cs" Inherits="MahoganyASP.UI.Paginas.pgUsuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="fvUsuarios" runat="server" DataSourceID="ldsMantUsuarios">
        <EditItemTemplate>

            <label>Nombre Completo</label> 
            <asp:TextBox ID="nombreCompletoTextBox" runat="server" Text='<%# Bind("nombreCompleto") %>' />
            <br />
            <label>Contraseña</label>            
            <asp:TextBox ID="contrasenaTextBox" runat="server" Text='<%# Bind("contrasena") %>' />
            <br />
            <label>Correo Electronico</label>             
            <asp:TextBox ID="correoElectronicoTextBox" runat="server" Text='<%# Bind("correoElectronico") %>' />
            <br />
            <label>Telefono 1</label> 
            <asp:TextBox ID="telefono1TextBox" runat="server" Text='<%# Bind("telefono1") %>' />
            <br />
            <label>Telefono 2</label> 
            <asp:TextBox ID="telefono2TextBox" runat="server" Text='<%# Bind("telefono2") %>' />
            <br />
            <label>Tipo Usuario</label> 
            <asp:TextBox ID="tipoUsuarioTextBox" runat="server" Text='<%# Bind("tipoUsuario") %>' />
            <br />
                        
            <asp:HiddenField ID="idUsuarioHiddenFiels" runat="server" Value='<%# Bind("idUsuario") %>' Visible="false"/>
            <br />
            <asp:LinkButton ID="lbkEdit" runat="server" CausesValidation="true" CommandName="Edit" Text="Editar" OnCommand="lbkEdit_Command" />
            <asp:LinkButton ID="UpdateButton" runat="server" CausesValidation="True" CommandName="Update" Text="Actualizar" />
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
        </EditItemTemplate>
        <InsertItemTemplate>
             <label>Nombre Completo</label> 
            <asp:TextBox ID="nombreCompletoTextBox" runat="server" Text='<%# Bind("nombreCompleto") %>' />
            <br />
            <label>Contraseña</label>            
            <asp:TextBox ID="contrasenaTextBox" runat="server" Text='<%# Bind("contrasena") %>' />
            <br />
            <label>Correo Electronico</label>             
            <asp:TextBox ID="correoElectronicoTextBox" runat="server" Text='<%# Bind("correoElectronico") %>' />
            <br />
            <label>Telefono 1</label> 
            <asp:TextBox ID="telefono1TextBox" runat="server" Text='<%# Bind("telefono1") %>' />
            <br />
            <label>Telefono 2</label> 
            <asp:TextBox ID="telefono2TextBox" runat="server" Text='<%# Bind("telefono2") %>' />
            <br />
            <label>Tipo Usuario</label> 
            <asp:TextBox ID="tipoUsuarioTextBox" runat="server" Text='<%# Bind("tipoUsuario") %>' />
            <br />
                        
            <asp:HiddenField ID="idUsuarioHiddenFiels" runat="server" Value='<%# Bind("idUsuario") %>' Visible="false"/>
            <br />
            <%--<asp:LinkButton ID="InsertButton" runat="server" CausesValidation="True" CommandName="Insert" Text="Insertar" />
            &nbsp;<asp:LinkButton ID="InsertCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />--%>
        </InsertItemTemplate>
        <ItemTemplate>
             <label>Nombre Completo</label> 
            <asp:label ID="nombreCompletoLabel" runat="server" Text='<%# Bind("nombreCompleto") %>' />
            <br />
            <label>Contraseña</label>            
            <asp:label  ID="contrasenaLabel" runat="server" Text='<%# Bind("contrasena") %>' />
            <br />
            <label>Correo Electronico</label>             
            <asp:label  ID="correoElectronicoLabel" runat="server" Text='<%# Bind("correoElectronico") %>' />
            <br />
            <label>Telefono 1</label> 
            <asp:label  ID="telefono1Label" runat="server" Text='<%# Bind("telefono1") %>' />
            <br />
            <label>Telefono 2</label> 
            <asp:label  ID="telefono2Label" runat="server" Text='<%# Bind("telefono2") %>' />
            <br />
            <label>Tipo Usuario</label> 
            <asp:label  ID="tipoUsuarioLabel" runat="server" Text='<%# Bind("tipoUsuario") %>' />
            <br />
                        
            <asp:HiddenField ID="idUsuarioHiddenFiels" runat="server" Value='<%# Bind("idUsuario") %>' Visible="false"/>
            <br />

            
            &nbsp;<asp:LinkButton ID="UpdateCancelButton" runat="server" CausesValidation="False" CommandName="Cancel" Text="Cancelar" />
            <asp:Button ID="btn" runat="server" OnClick="btn_Click" Text="Editar"/>
        </ItemTemplate>
    </asp:FormView>
    <asp:LinqDataSource ID="ldsMantUsuarios" runat="server" ContextTypeName="MahoganyASP.BO.DBMahoganyDataContext" EntityTypeName="" Select="new (idUsuario, nombreCompleto, correoElectronico, telefono2, telefono1, contrasena, tipoUsuario)" TableName="tbUsuarios" Where="idUsuario == @idUsuario">
        <WhereParameters>
            <asp:Parameter DefaultValue="1" Name="idUsuario" Type="Int32" />
        </WhereParameters>
    </asp:LinqDataSource>
</asp:Content>
