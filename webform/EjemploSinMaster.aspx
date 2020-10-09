<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EjemploSinMaster.aspx.cs" Inherits="webform.EjemploSinMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Ejemplo SIN Master</h2>
        </div>
        <hr />
        <div class="container">
            <div class="row">
                <div class="col">
                     <% foreach (Dominio.Pokemon item in listaPokemon)
                         { %>

                            <div class="card-columns">
                                <div class="card">
                                    <img src="<% = item.UrlImage %>"" class="card-img-top" alt="...">
                                    <div class="card-body">
                                        <h5 class="card-title"><% = item.Nombre %></h5>
                                        <%--<p class="card-text">This is a longer card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>--%>
                                    </div>
                                </div>
                            </div>

                        <% } %>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <a href="DetallePokemon.aspx" class="btn btn-primary">content</a>
                </div>
            </div>

           
        </div>
    </form>
</body>
</html>
