<%@ Page Title="Event Details" Language="C#" MasterPageFile="~/Site.Master"
    AutoEventWireup="true"
    CodeBehind="EventDetails.aspx.cs"
    Inherits="IDU0815Phoning.EventDetails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView ID="eventDetails" runat="server"
        ItemType="IDU0815Phoning.Phoning.T_EVENT" SelectMethod="GetEvents"
        RenderOuterTable="false">
        <ItemTemplate>
            <div>
                <h1><%#:Item.RECORD_EVENT_ID %></h1>
            </div>
            <br />
            <table>
                <tr>
                    
                    <td style="vertical-align: top; text-align: left;">
                        <b>Event number:</b><br />
                        <%#:Item.RECORD_ID %>
                        <br />
                        <span><b>Associated call:</b>&nbsp;<%#: Item.CALL_ID %></span>
                        <br />
                        <span><b>Date and time:</b>&nbsp;<%#:Item.RECORD_DATE
                        %></span>
                        <br />
                    </td>
                </tr>
            </table>
        </ItemTemplate>
    </asp:FormView>
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