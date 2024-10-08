﻿<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/apps/Uidesk.Master" CodeBehind="TrmA3.aspx.vb" Inherits="ICC.TrmA3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="css/vendors_css.css">
    <link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/skin_color.css">
    <script src="js/jquery-1.9.1.min.js"></script>
    <script src="js/sweetalert.min.js"></script>
    <script src="js/TrmA3.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:HiddenField ID="TrxID" runat="server" />
    <section class="content">
        <div id="Div1" class="row" runat="server">
            <div class="col-xl-12 col-lg-12 col-12">
                <div class="box p-15">
                    <div class="row">
                        <div class="col-md-4" style="margin-top: 10px;">
                            <%--<div class="form-group">
                                <h4 class="box-title">Data User Application</h4>
                            </div>--%>
                            <h4 class="box-title">Detail Menu Application</h4>
                        </div>
                        <div class="col-md-4"></div>
                        <div class="col-md-4">
                            <button type="button" class="btn btn-rounded btn-default float-right" onclick="showAdd();">+ Add Detail Menu Application</button>
                        </div>
                    </div>
                </div>
                <div class="box p-15">
                    <div class="row">
                        <div class="col-md-12">
                            <table id="TrmMenu" class="table mt-0 table-hover no-wrap table-borderless" style="width: 100%; overflow-x: scroll; overflow: scroll;">
                                <thead>
                                    <tr>
                                        <th>ID</th>
                                        <th>Menu Name</th>
                                        <th>Sub Menu Name</th>
                                        <th>Detail Menu Name</th>
                                        <th>Url</th>
                                        <th>Type</th>
                                        <%-- <th>User Create</th>
                                        <th style="width: 200px;">Date Create</th>--%>
                                        <th style="width: 50px;">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <div class="modal center-modal fade" id="ModalChannel" tabindex="-1" data-keyboard="false" data-backdrop="static">
        <div class="modal-dialog">
            <div class="modal-content" style="width: 1000px; margin-left: -250px;">
                <div class="modal-header">
                    <h5 class="modal-title">Form Add Detail Menu Application</h5>
                    <button type="button" class="close" data-dismiss="modal">
                        <span aria-hidden="true">&times;</span>
                    </button>
                </div>
                <div class="modal-body">
                    <div class="row">
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Menu Name</label>
                                <select name="select" id="cmbMenu1" class="form-control" onchange="getWS_CategoryType(1);" style="height:33px;">
                                    <option value="">Select</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Sub Menu Name</label>
                                <select name="select" id="cmbMenu2" class="form-control" onchange="getWS_CategoryTypeDetail(1);" style="height:33px;">
                                    <option value="">Select</option>
                                </select>
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Detail Menu Name</label>
                                <input type="text" class="form-control" id="TxtDetailMenu" placeholder="Detail Menu Name">
                            </div>
                        </div>
                        <div class="col-md-3">
                            <div class="form-group">
                                <label>Type</label>
                                <select name="select" id="cmbType" class="form-control" style="height:33px;">
                                    <option value="">Select</option>
                                    <option value="Y">Yes</option>
                                    <option value="N">No</option>
                                </select>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <div class="form-group">
                                <label>Url</label>
                                <input type="text" class="form-control" id="TxtUrl" placeholder="Url">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer modal-footer-uniform">
                    <button type="button" class="btn btn-rounded btn-danger" data-dismiss="modal">Close</button>
                    <button type="button" class="btn btn-rounded btn-primary float-right" onclick="ActionUpdate()" id="Update">Update</button>
                    <button type="button" class="btn btn-rounded btn-primary float-right" onclick="ActionSimpan()" id="Simpan">Save</button>
                    <button type="button" class="btn btn-rounded btn-primary float-right" onclick="ActionDelete()" id="Delete">Delete</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
