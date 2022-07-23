<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Form1.aspx.cs" Inherits="Examen2JosueChavarria.Form1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/Form1.css" rel="stylesheet" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <p class="auto-style3">
            <strong>Informacion de usuario</strong></p>
        <p class="auto-style4">
            &nbsp;</p>
        <p class="auto-style5">
            <span class="auto-style6">Nombre:&nbsp;&nbsp; </span>&nbsp;<asp:TextBox ID="tnombre"  runat="server" Width="344px" required="required"></asp:TextBox>
        </p>
        <p class="auto-style5">
            <span class="auto-style6">Cedula:</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tcedula"  runat="server" Width="344px" OnTextChanged="tcedula_TextChanged" required="required"></asp:TextBox>
        </p>
        <p class="auto-style5">
            <span class="auto-style6">Telefono:&nbsp; </span>&nbsp;<asp:TextBox ID="ttelefono"  runat="server" Width="345px" required="required"></asp:TextBox>
        </p>
        <p class="auto-style5">
            <span class="auto-style6">Direccion: </span>&nbsp;<asp:TextBox ID="Tdireccion"  runat="server" Width="342px" OnTextChanged="tdireccion_TextChanged" required="required"></asp:TextBox>
        </p>
        <p class="auto-style5">
            &nbsp;</p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Iagua" runat="server" Height="130px" ImageUrl="~/Imagenes/agua.png" OnClick="Iagua_Click" Width="160px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Ielectricidad" runat="server" Height="130px" ImageUrl="~/Imagenes/electricidad.png" OnClick="Ielectricidad_Click" Width="155px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Icable" runat="server" Height="130px" ImageUrl="~/Imagenes/cable.png" OnClick="ImageButton4_Click" Width="161px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:ImageButton ID="Itelefono" runat="server" Height="130px" ImageUrl="~/Imagenes/llamada-telefonica.png" OnClick="Itelefono_Click" Width="151px" />

</asp:Content>
