<%@ Page Title="CallList" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="CallList.aspx.cs"
    Inherits="IDU0815Phoning.CallList" %>

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
    <%--<div><%=CheckStateOfCall()%></div>--%>
    <asp:TextBox ID="textCaller" runat="server" Visible="false"></asp:TextBox>
    <asp:TextBox ID="textEvent" runat="server" Visible="false"></asp:TextBox>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="RECORD_ID,Expr1" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" Width="40%" HorizontalAlign="Center" AllowPaging="true" >
        <Columns>
            <asp:BoundField DataField="EVENT_NAME" HeaderText="Event"  />
            <asp:BoundField DataField="RECORD_DATE" HeaderText="Date" SortExpression="RECORD_DATE" />
            <asp:BoundField DataField="RECEIVER" HeaderText="Receiver" SortExpression="RECEIVER" />
        </Columns>
        <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
        <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
        <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
        <RowStyle BackColor="White" ForeColor="#003399" />
        <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
        <SortedAscendingCellStyle BackColor="#EDF6F6" />
        <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
        <SortedDescendingCellStyle BackColor="#D6DFDF" />
        <SortedDescendingHeaderStyle BackColor="#002876" />
    </asp:GridView>

   


    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:IDU0815Phoning %>" SelectCommand="SELECT T_EVENT.RECORD_ID, T_EVENT.RECORD_DATE, T_EVENT.CALL_ID, T_CALL.CALL_ID AS Expr1, T_CALL.CALLER, T_CALL.RECEIVER, T_EVENT_TYPE.EVENT_NAME FROM T_EVENT INNER JOIN T_CALL ON T_EVENT.CALL_ID = T_CALL.CALL_ID INNER JOIN T_EVENT_TYPE ON T_EVENT.RECORD_EVENT_ID = T_EVENT_TYPE.EVENT_ID" FilterExpression="CALLER = '{0}' AND EVENT_NAME = '{1}'">
    <FilterParameters>
         <asp:ControlParameter Name="CALLER" ControlID="textCaller" PropertyName="Text" />
         <asp:ControlParameter Name="RECORD_EVENT_ID" ControlID="textEvent" DefaultValue="Pick-up" PropertyName="Text" />
     </FilterParameters>
    </asp:SqlDataSource>
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