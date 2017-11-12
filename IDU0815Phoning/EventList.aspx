<%@ Page Title="Events" Language="C#" MasterPageFile="~/Site.Master"
AutoEventWireup="true"
CodeBehind="EventList.aspx.cs" Inherits="IDU0815Phoning.EventList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
<section>
  <div>
    <hgroup>
      <h2><%: Page.Title %></h2>
    </hgroup>
    <asp:ListView ID="eventList" runat="server"
    DataKeyNames="RECORD_ID" GroupItemCount="2"
    ItemType="IDU0815Phoning.Phoning.T_EVENT" SelectMethod="GetEventTypes">
    <EmptyDataTemplate>
      <table >
        <tr>
          <td>No data was returned.</td>
        </tr>
      </table>
    </EmptyDataTemplate>
    <EmptyItemTemplate>
      <td/>
    </EmptyItemTemplate>
    <GroupTemplate>
      <tr id="itemPlaceholderContainer" runat="server">
        <td id="itemPlaceholder" runat="server"></td>
      </tr>
    </GroupTemplate>
    <ItemTemplate>
      <td runat="server">
        <table>
          <%--<tr>
            <td>
              <a
              href="EventsDetails.aspx?RECORD_ID=<%#:Item.RECORD_ID%>
              <img src="/Catalog/Images/Thumbs/<%#:Item.ImagePath%>"
              width="100" height="75" style="border:
              solid" /></a>
            </td>
          </tr> --%>
          <tr>
            <td>
              <%--<a href="/EventList.aspx?id=<%#: Item.RECORD_ID %>">
                     <%#: Item.RECORD_EVENT_ID %>
                     <%#: Item.RECORD_DATE %>
                     </a>--%>
                <a href="/EventDetails.aspx?id=<%#: Item.RECORD_ID %>">
                     <%#: Item.RECORD_EVENT_ID %>
                     <%#: Item.RECORD_DATE %>
                     </a>
            <%--<br />
            <span>
              <b>Date: </b><%#:Item.RECORD_DATE%>
            </span>
            <br />--%>
          </td>
        </tr>
        <tr>
          <td>&nbsp;</td>
        </tr>
      </table>
    </p>
  </td>
</ItemTemplate>
<LayoutTemplate>
  <table style="width:100%;">
    <tbody>
      <tr>
        <td>
          <table id="groupPlaceholderContainer"
          runat="server" style="width:100%">
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
