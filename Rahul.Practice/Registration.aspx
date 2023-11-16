<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Rahul.Practice.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>Name :</td>
            <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
        </tr>

        <tr>
            <td>Gender :</td>
            <td><asp:RadioButtonList ID="rblgender" runat="server"></asp:RadioButtonList></td>
        </tr>

         <tr>
            <td>Email :</td>
            <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Password :</td>
            <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
        </tr>

          <tr>
            <td>Qualification :</td>
            <td><asp:DropDownList ID="ddlqualification" runat="server"></asp:DropDownList></td>
        </tr>

         <tr>
            <td></td>
            <td><asp:Button ID="btnsubmit" runat="server" Text="Submit" BackColor="Red" ForeColor="White" OnClick="btnsubmit_Click"/></td>
        </tr>


    </table>
</asp:Content>
