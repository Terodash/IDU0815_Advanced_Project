<%@ Page Title="Events" Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="EventList.aspx.cs" Inherits="IDU0815Phoning.EventList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

<script runat="server">

    protected void ResultsList_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Set the page size with the value
        // selected in the DropDownList object
        EventsDataPager.PageSize = Convert.ToInt32(ResultsList.SelectedValue);
    }
</script>

<section>
    <div>
        <hgroup>
            <h2><%: Page.Title %></h2>
        </hgroup>

        <table border="0" width="640px">
            <tr>
                <td align="left">
                    <asp:Label ID="ResultsLabel" runat="server"
                        AssociatedControlID="ResultsList" Text="Results per page:" />
                    <asp:DropDownList runat="server" ID="ResultsList"
                        OnSelectedIndexChanged="ResultsList_SelectedIndexChanged" AutoPostBack="true">
                        <asp:ListItem Value="2" />
                        <asp:ListItem Value="5" Selected="True" />
                        <asp:ListItem Value="10" />
                    </asp:DropDownList>
                </td>
                <td align="right">
                    <asp:DataPager ID="EventsDataPager" runat="server"
                        PagedControlID="eventList" PageSize="5">
                        <Fields>
                            <asp:NumericPagerField />
                        </Fields>
                    </asp:DataPager>
                </td>
            </tr>
        </table>

       
        <asp:ListView ID="eventList" runat="server"
            DataKeyNames="RECORD_ID"
            ItemType="IDU0815Phoning.Phoning.T_EVENT" SelectMethod="GetEventTypes" OnSelectedIndexChanged="eventList_SelectedIndexChanged">

            <%--<LayoutTemplate>
                <asp:LinkButton runat="server" ID="SortButton"
                     Text="Sort" CommandName="Sort" CommandArgument="RECORD_DATE" />
                <table runat="server" id="table1">
                  <tr runat="server" id="itemPlaceholder">
                  </tr>
                </table>
              </LayoutTemplate>--%>


            <EmptyDataTemplate>
                <table>
                    <tr>
                        <td>No data was returned.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            <EmptyItemTemplate>
                <td />
            </EmptyItemTemplate>
            

            <GroupTemplate>
                <tr id="itemPlaceholderContainer" runat="server">
                    <td id="itemPlaceholder" runat="server"></td>
                </tr>
            </GroupTemplate>

                <ItemTemplate>
                    <tr runat="server">
                      <td><a href="/EventDetails.aspx?id=<%#: Item.RECORD_ID %>">
                            <%#: Item.RECORD_EVENT_ID %>
                            <%#: Item.RECORD_DATE %>
                            <%--<%#: Item.AssociatedCall.CALLER%>--%>
                        </a></td>
                    </tr>
                </ItemTemplate>

            <LayoutTemplate>
                <asp:LinkButton runat="server" ID="SortButton"
                                    Text="Sort by date" CommandName="Sort" CommandArgument="RECORD_DATE" />
                <table style="width: 100%;">
                    <tbody>
                        <tr>
                            <td>
                                <table id="groupPlaceholderContainer"
                                    runat="server" style="width: 100%">
                                    <tr id="groupPlaceholder"></tr>
                                </table>
                            </td>
                        </tr>
                        <tr>
                            <td></td>
                        </tr>
                        <tr></tr>
                    </tbody>
                </table>
            </LayoutTemplate>
        </asp:ListView>
    </div>
</section>
</asp:Content>
