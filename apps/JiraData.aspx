<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/apps/Uidesk.Master" CodeBehind="JiraData.aspx.vb" Inherits="ICC.JiraData" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/sweetalert.min.js"></script>
    <script src="js/1_doticket.js"></script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="content">
        <div class="row">
            <div class="col-md-3">
                <div class="form-group">
                    <label>Product</label>
                    <select name="select" id="IdProduct" class="form-control" style="height: 33px;">
                        <option value="">Select</option>
                    </select>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label>Mobile Apps Version</label>
                    <input type="text" id="MobileApp" class="form-control" placeholder="MobileApp" />

                </div>
            </div>


            <div class="col-md-3">
                <div class="form-group">
                    <label>Flatform</label>
                    <select name="select" id="IdFlatform" class="form-control" style="height: 33px;">
                        <option value="">Select</option>
                    </select>
                </div>
            </div>
            <div class="col-md-3">
                <div class="form-group">
                    <label>Browser</label>
                    <select name="select" id="IdBrowser" class="form-control" style="height: 33px;">
                        <option value="">Select</option>
                    </select>
                </div>
            </div>
        </div>
    </div>


    <script src="js/1_doticket.js"></script>

</asp:Content>

