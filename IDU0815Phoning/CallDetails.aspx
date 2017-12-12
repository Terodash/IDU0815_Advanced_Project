<%@ Page Title = "oui" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="CallDetails.aspx.cs"
    Inherits="IDU0815Phoning.CallDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%--<asp:FormView ID="callDetails" runat="server"
        ItemType="IDU0815Phoning.Phoning.T_CALL" SelectMethod="GetCalls"
        RenderOuterTable="false" OnPageIndexChanging="callDetails_PageIndexChanging">
        <ItemTemplate>
            <div>
                <h1><%#:Item.CALL_ID %></h1>
            </div>
            <br />
            <table>
                <tr>
                   
                    <td style="vertical-align: top; text-align: left;">
                        <b>Call number:</b><br />
                        <%#:Item.CALL_ID %>
                        <br />
                        <span><b>Caller:</b>&nbsp;<%#: Item.CALLER %></span><br /><span><b>Receiver:</b>&nbsp;<%#:Item.RECEIVER %></span><br /></td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>--%>
    <div style="font-weight: 700"><%=CheckStateOfCall()%> call. </div>
    <asp:TextBox ID="txtSearch" runat="server" Visible="false"></asp:TextBox>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RECORD_ID,Expr1" DataSourceID="SqlDataSource1" CellPadding="4" ForeColor="#333333" GridLines="None" Width="50%" HorizontalAlign="Center">
        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
            <asp:BoundField DataField="CALL_ID" HeaderText="Call ID" SortExpression="CALL_ID" />
            <asp:BoundField DataField="CALLER" HeaderText="Caller" SortExpression="CALLER" />
            <asp:BoundField DataField="EVENT_NAME" HeaderText="Event" SortExpression="RECORD_EVENT_ID" />
            <asp:BoundField DataField="RECORD_DATE" HeaderText="Date" SortExpression="RECORD_DATE" />
            <asp:BoundField DataField="RECEIVER" HeaderText="Receiver" SortExpression="RECEIVER" />
        </Columns>
        <RowStyle HorizontalAlign="Left" />
        <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />        <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#E9E7E2" />
        <SortedAscendingHeaderStyle BackColor="#506C8C" />
        <SortedDescendingCellStyle BackColor="#FFFDF8" />
        <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
    </asp:GridView>
    <br />
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALL_ID AS Expr1, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CALL_ID = '{0}'">
    <FilterParameters>
         <asp:ControlParameter Name="CALL_ID" ControlID="txtSearch" PropertyName="Text" />
     </FilterParameters>
    </asp:SqlDataSource>
    <div style="font-weight: 700"><%=GetTimestamp()%></div>
    </asp:Content>











<%--﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IDU0815Phoning;
using System.Web.ModelBinding;

namespace IDU0815Phoning
{
  public partial class EventDetails : System.Web.UI.Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public IQueryable<t_event> GetEvent(
                        [QueryString("RECORD_ID")] int? recordId,
                        [RouteData] string typeEvent)
    {
      var _db = new IDU0815Phoning.Phoning.CallContext();
      IQueryable<T_EVENT>
      query = _db.Events;
      if (recordId.HasValue && recordId > 0)
      {
        query = query.Where(p => p.RECORD_ID == recordId);
      }
      else if (!String.IsNullOrEmpty(typeEvent))
      {
        query = query.Where(p =>
                  String.Compare(p.RECORD_EVENT_ID, typeEvent) == 0);
      }
      else
      {
        query = null;
      }
      return query;
    }
  }
}--%>