﻿Public Class TrmVendorDashboard
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        TrxVendorID.Value = Session("VendorID")
    End Sub

End Class