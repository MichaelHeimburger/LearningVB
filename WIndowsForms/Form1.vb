Public Class Form1
    Private productFunctions As New ProductFunctions

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        productFunctions.ShowProduct()
    End Sub

    Private Sub ProductData_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProductData.CellContentClick
        LblID.Text = ProductData.SelectedRows(0).Cells(0).Value.ToString 'id 
        TxtName.Text = ProductData.SelectedRows(0).Cells(1).Value.ToString 'name
        TxtPrice.Text = ProductData.SelectedRows(0).Cells(2).Value.ToString 'price
        TxtBrand.Text = ProductData.SelectedRows(0).Cells(3).Value.ToString 'brand
        BtnCreate.Text = "Update"
    End Sub

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click

        If LblID.Text <> "/" Then

            Dim db = New SuperMarketTestEntities
            Dim productUpdate = (From a In db.Products Where a.ProductID = LblID.Text Select a).FirstOrDefault
            productUpdate.Name = TxtName.Text
            productUpdate.Price = TxtPrice.Text
            productUpdate.Brand = TxtBrand.Text
            db.Entry(productUpdate)
            db.SaveChanges()
            productFunctions.ShowProduct()
            productFunctions.ClearProductForm()

        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        productFunctions.ClearProductForm()
    End Sub
End Class


