<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EjemploConMaster.aspx.cs" Inherits="webform.EjemploConMaster" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Ejemplo Con Master</h2>
    <div>
    <asp:Label Text="Nombre" ID="lblNombre" runat="server" />
    </div>
    <asp:TextBox ID="txtNombre" runat="server" />
    <asp:Button CssClass="btn btn-primary" Text="Aceptar" ID="btnAceptar" OnClick="btnAceptar_Click" runat="server" />
    
    <hr />
    <asp:GridView CssClass="table" ID="dgvPokemones" runat="server"></asp:GridView>

</asp:Content>
