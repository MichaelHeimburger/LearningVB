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
        Dim db = New SuperMarketTestEntities
        If LblID.Text <> "/" Then
            Dim productUpdate = (From a In db.Products Where a.ProductID = LblID.Text Select a).FirstOrDefault
            productUpdate.Name = TxtName.Text
            productUpdate.Price = TxtPrice.Text
            productUpdate.Brand = TxtBrand.Text
            db.Entry(productUpdate).State = Entity.EntityState.Modified
            db.SaveChanges()
            productFunctions.ShowProduct()
            productFunctions.ClearProductForm()
        Else
            Dim newProduct = New Product
            newProduct.Name = TxtName.Text
            newProduct.Price = TxtPrice.Text
            newProduct.Brand = TxtBrand.Text
            db.Products.Add(newProduct)
            db.SaveChanges()
            productFunctions.ClearProductForm()
            productFunctions.ShowProduct()
        End If
        Form2.GrdAllProducts.DataSource = productFunctions.GetProductViewModels
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        productFunctions.ClearProductForm()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        Dim db = New SuperMarketTestEntities
        If LblID.Text <> "/" Then
            Dim productDelete = (From x In db.Products Where x.ProductID = LblID.Text Select x).FirstOrDefault
            db.Products.Remove(productDelete)
            db.SaveChanges()
        End If
        productFunctions.ClearProductForm()
        productFunctions.ShowProduct()
    End Sub

    Public Sub Programs_Click(sender As Object, e As EventArgs)
        'nothing here
    End Sub

    Public Sub ProgramsProducts_Click(sender As Object, e As EventArgs)

    End Sub

    Public Sub ProgramsStoreInventory_Click(sender As Object, e As EventArgs)

    End Sub

End Class


