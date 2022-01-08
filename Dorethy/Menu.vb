Public Class Menu
    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB_user.Text = DRT_Login.UserName
        Auth_C.Text = DRT_Login.Auth
        If Auth_C.Text = "1" Then
            BtnProducts.Visible = False
            BtbPO.Visible = False
        End If
    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        Dim oForm As DRT_Login
        oForm = New DRT_Login()
        oForm.Show()

        Hide()
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        Dim oForm As Products
        oForm = New Products()
        oForm.Show()

        Hide()
    End Sub

    Private Sub BtnCust_Click(sender As Object, e As EventArgs) Handles BtnCust.Click
        Dim oForm As Customer
        oForm = New Customer()
        oForm.Show()

        Hide()
    End Sub

    Private Sub BtbPO_Click(sender As Object, e As EventArgs) Handles BtbPO.Click
        Dim oForm As Report
        oForm = New Report()
        oForm.Show()

        Hide()
    End Sub

    Private Sub BtnSales_Click(sender As Object, e As EventArgs) Handles BtnSales.Click
        Dim oForm As Sales
        oForm = New Sales()
        oForm.Show()

        Hide()
    End Sub

    Private Sub BtnChkO_Click(sender As Object, e As EventArgs) Handles BtnChkO.Click
        Dim oForm As CheckOut
        oForm = New CheckOut()
        oForm.Show()

        Hide()
    End Sub
End Class