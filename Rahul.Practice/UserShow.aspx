<%@ Page Title="" Language="C#" MasterPageFile="~/Default.Master" AutoEventWireup="true" CodeBehind="UserShow.aspx.cs" Inherits="Rahul.Practice.UserShow" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                <asp:GridView ID="gvusers" runat="server" AutoGenerateColumns="false" OnRowCommand="gvusers_RowCommand">
                    <Columns>
                        <asp:TemplateField HeaderText="User ID">
                            <ItemTemplate>
                                <%#Eval("did")%>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Name">
                            <ItemTemplate>
                                <%#Eval("dname") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Gender">
                            <ItemTemplate>
                                <%#Eval("gname") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Email">
                            <ItemTemplate>
                                <%#Eval("demail") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Password">
                            <ItemTemplate>
                                <%#Eval("dpassword") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Qualification">
                            <ItemTemplate>
                                <%#Eval("qname") %>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:TemplateField HeaderText="User Delete">
                            <ItemTemplate>
                                <asp:Button id="btndelete" runat="server" Text="Delete" CommandName="A" CommandArgument='<%#Eval("did") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>

                          <asp:TemplateField HeaderText="User Edit">
                            <ItemTemplate>
                                <asp:Button id="btnEdit" runat="server" Text="Edit" CommandName="B" CommandArgument='<%#Eval("did") %>'/>
                            </ItemTemplate>
                        </asp:TemplateField>
                         
                    </Columns>
                </asp:GridView>
            </td>
        </tr>
    </table>

</asp:Content>
