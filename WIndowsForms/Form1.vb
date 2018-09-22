Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Look at this text")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As SuperMarketTestEntities = New SuperMarketTestEntities()
        Dim products = db.Products.ToList
        Dim ProductViewList = New List(Of ProductView)
        For Each product As Product In products
            Dim cv = New ProductView
            cv.Name = product.Name
            cv.Price = product.Price
            cv.Brand = product.Brand
            cv.ID = product.ProductID
            ProductViewList.Add(cv)
        Next
        ProductData.DataSource = ProductViewList
        'Instead of returning all products right from data base we are sending in a viewmmodel beucase by default it shows foregin keys also?
    End Sub
End Class


